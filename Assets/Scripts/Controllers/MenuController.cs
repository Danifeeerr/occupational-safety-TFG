using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class MenuController : MonoBehaviour
{
    private const string API_URL = "http://10.244.217.1:8000/login";

    public TMP_InputField inputUsername;
    public TMP_InputField inputPassword;
    public TMP_Text textopantalla;

    private string username;
    private string password;
    private string token;

    public void login()
    {
        username = inputUsername.text;
        password = inputPassword.text;
        StartCoroutine(LoginRequest(username, password));
    }

    private IEnumerator LoginRequest(string user, string pass)
    {
        string json = $"{{\"username\":\"{user}\",\"password\":\"{pass}\"}}";
        byte[] body = Encoding.UTF8.GetBytes(json);

        using UnityWebRequest request = new UnityWebRequest(API_URL, "POST");
        request.uploadHandler   = new UploadHandlerRaw(body);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        request.timeout = 10;

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            token = request.downloadHandler.text.Trim('"');
            Debug.Log($"[Login] Token: {token}");
            textopantalla.SetText("Inicio sesion correcto");
        }
        else
        {
            Debug.LogWarning($"[Login] Error {request.responseCode}: {request.downloadHandler.text}");
            if(request.responseCode == 0)
            {
                textopantalla.SetText("No respone");
            }
            textopantalla.SetText("NonValidUser");
        }
    }
}
