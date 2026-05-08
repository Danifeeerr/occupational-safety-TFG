using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public TMP_InputField inputUsername;
    public TMP_InputField inputPassword;
    public TMP_Text textopantalla;
    public GameObject loginMenu;
    public GameObject mainMenu;
    public GameObject optionMenu;

    private void Awake()
    {
        if (!string.IsNullOrEmpty(ApiController.Instance.Token))
        {
            loginMenu.SetActive(false);
            mainMenu.SetActive(true);
            optionMenu.SetActive(false);
        }
        else
        {
            loginMenu.SetActive(true);
            mainMenu.SetActive(false);
            optionMenu.SetActive(false);
        }
    }
    public void login()
    {
        StartCoroutine(ApiController.Instance.Login(
            //inputUsername.text,
            //inputPassword.text,
            "admin",
            "admin",
            success =>
            {
                if (success)
                {
                    loginMenu.SetActive(false);
                    mainMenu.SetActive(true);
                }
                else
                {
                    textopantalla.SetText("NonValidUser");
                }
            }
        ));
    }
    public void setScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenOptions()
    {
        loginMenu.SetActive(false);
        mainMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void MainMenu()
    {
        loginMenu.SetActive(false);
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);
    }

    public void LogOut()
    {
        ApiController.Instance.LogOut();
        mainMenu.SetActive(false);
        optionMenu.SetActive(false);
        loginMenu.SetActive(true);
    }
}
