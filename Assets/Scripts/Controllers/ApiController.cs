using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

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
            Token = request.downloadHandler.text.Trim('"');
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
}
