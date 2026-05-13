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
            if (loginMenu != null) loginMenu.SetActive(false);
            if (mainMenu != null) mainMenu.SetActive(true);
            if (optionMenu != null) optionMenu.SetActive(false);
        }
        else
        {
            if (loginMenu != null) loginMenu.SetActive(true);
            if (mainMenu != null) mainMenu.SetActive(false);
            if (optionMenu != null) optionMenu.SetActive(false);
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
                    if (loginMenu != null) loginMenu.SetActive(false);
                    if (mainMenu != null) mainMenu.SetActive(true);
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
        if (loginMenu != null) loginMenu.SetActive(false);
        if (mainMenu != null) mainMenu.SetActive(false);
        if (optionMenu != null) optionMenu.SetActive(true);
    }

    public void MainMenu()
    {
        if (loginMenu != null) loginMenu.SetActive(false);
        if (mainMenu != null) mainMenu.SetActive(true);
        if (optionMenu != null) optionMenu.SetActive(false);
    }

    public void LogOut()
    {
        ApiController.Instance.LogOut();
        if (mainMenu != null) mainMenu.SetActive(false);
        if (optionMenu != null) optionMenu.SetActive(false);
        if (loginMenu != null) loginMenu.SetActive(true);
    }

    public void activateDeactivateGameObject(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }
}
