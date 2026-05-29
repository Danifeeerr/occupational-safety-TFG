using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json.Linq;

public class ApiController : MonoBehaviour
{
    public static ApiController Instance { get; private set; }

    private const string BASE_URL = "http://10.244.217.1:8000"; //only works with the VPN on

    public string Token { get; private set; }

    void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
        Token = null;
        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator Login(string user, string pass, System.Action<bool> callback)
    {
        string json = $"{{\"username\":\"{user}\",\"password\":\"{pass}\"}}";
        byte[] body = Encoding.UTF8.GetBytes(json);

        using var request = new UnityWebRequest($"{BASE_URL}/login", "POST");
        request.uploadHandler   = new UploadHandlerRaw(body);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        request.timeout = 10;

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Token = JObject.Parse(request.downloadHandler.text)["access_token"].ToString();
            Debug.Log($"[Login] Token: {Token}");
            callback(true);
        }
        else
        {
            Debug.LogWarning($"[Login] Error {request.responseCode}: {request.downloadHandler.text}");
            callback(false);
        }
    }

    public void LogOut()
    {
        Token = null;
    }

    public void registerTry(int mistakes, int trainingID, float timeSpent)
    {
        StartCoroutine(intTry(mistakes, trainingID, timeSpent));
    }

    public IEnumerator intTry(int mistakes, int trainingID, float timeSpent)
    {
        // 1. Obtener el userid a partir del token
        using var userReq = UnityWebRequest.Get($"{BASE_URL}/user?token={Token}");
        userReq.timeout = 10;
        yield return userReq.SendWebRequest();

        if (userReq.result != UnityWebRequest.Result.Success)
        {
            Debug.LogWarning($"[intTry] No se pudo obtener el usuario: {userReq.downloadHandler.text}");
            yield break;
        }

        int userId = (int)JObject.Parse(userReq.downloadHandler.text)["id"];

        // 2. Comprobar que el training está asignado al usuario
        using var assignReq = UnityWebRequest.Get($"{BASE_URL}/assignation/{userId}");
        assignReq.timeout = 10;
        yield return assignReq.SendWebRequest();

        if (assignReq.result != UnityWebRequest.Result.Success)
        {
            Debug.LogWarning($"[intTry] El training {trainingID} no está asignado al usuario {userId}");
            yield break;
        }

        bool assigned = false;
        foreach (var a in JArray.Parse(assignReq.downloadHandler.text))
        {
            if ((int)a["trainingid"] == trainingID) { assigned = true; break; }
        }

        if (!assigned)
        {
            Debug.LogWarning($"[intTry] El training {trainingID} no está asignado al usuario {userId}");
            yield break;
        }

        // 3. Registrar el intento
        int t = (int)timeSpent;
        string timeStr = $"{t / 3600:D2}:{t % 3600 / 60:D2}:{t % 60:D2}";
        string timestamp = System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");
        string json = $"{{\"userid\":\"{Token}\",\"trainingid\":{trainingID},\"time_spent\":\"{timeStr}\",\"number_errors\":{mistakes},\"timestamp\":\"{timestamp}\"}}";
        byte[] body = Encoding.UTF8.GetBytes(json);

        using var attemptReq = new UnityWebRequest($"{BASE_URL}/attempt/new", "POST");
        attemptReq.uploadHandler   = new UploadHandlerRaw(body);
        attemptReq.downloadHandler = new DownloadHandlerBuffer();
        attemptReq.SetRequestHeader("Content-Type", "application/json");
        attemptReq.timeout = 10;
        yield return attemptReq.SendWebRequest();

        if (attemptReq.result == UnityWebRequest.Result.Success)
            Debug.Log("[intTry] Intento registrado correctamente");
        else
            Debug.LogWarning($"[intTry] Error {attemptReq.responseCode}: {attemptReq.downloadHandler.text}");
    }
}
