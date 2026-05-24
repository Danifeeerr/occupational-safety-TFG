using Oculus.Interaction.Locomotion;
using UnityEngine;

public class SettingsApplier : MonoBehaviour
{
    //Aquest script s'ha creat per a poder aplicar les settings del jugador a banda de les d'àudio
    //ja que no es vol que s'apliquin els canvis de moviment al lobby, només a les escenes a on
    //l'usuari es pot moure
    [SerializeField] private TurnerEventBroadcaster turnerEventBroadcaster;
    [SerializeField] private GameObject controllerSlideInteractor;

    private void Start()
    {
        ApplyAll();
    }
    //Mètode per aplicar els canvis fets als checkboxes
    public void ApplyAll()
    {
        GameSettings s = SettingsManager.Instance.Settings;
        ApplySmoothCameraMovement(s.smoothCameraMovement);
        ApplyStickMovement(s.stickMovement);
    }

    private void ApplySmoothCameraMovement(bool smooth)
    {
        turnerEventBroadcaster.TurnMethod = smooth ? TurnerEventBroadcaster.TurnMode.Smooth : TurnerEventBroadcaster.TurnMode.Snap;
    }

    private void ApplyStickMovement(bool enabled)
    {
        if (controllerSlideInteractor != null)
            controllerSlideInteractor.SetActive(enabled);
    }
}
