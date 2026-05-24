using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    [SerializeField] private GameObject floatingMenu;
    [SerializeField] private GameObject mainPage;
    [SerializeField] private GameObject optionsPage;
    [SerializeField] private InputActionReference inputActionReference_Menu;

    private void OnEnable()
    {
        inputActionReference_Menu.action.performed += OpenCloseMenu;
    }

    private void OnDisable()
    {
        inputActionReference_Menu.action.performed -= OpenCloseMenu;
    }

    public void OpenCloseMenu(InputAction.CallbackContext ctx)
    {
        floatingMenu.SetActive(!floatingMenu.activeSelf);
        mainPage.SetActive(true);
        optionsPage.SetActive(false);
    }
}
