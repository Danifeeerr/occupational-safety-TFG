using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuController : MonoBehaviour
{
    [Header("Sliders de Volumen")]
    [SerializeField] private Slider sliderMasterVolume;
    [SerializeField] private Slider sliderMusicVolume;
    [SerializeField] private Slider sliderSFXVolume;

    [Header("Toggles")]
    [SerializeField] private Toggle toggleStickMovement;
    [SerializeField] private Toggle toggleSmoothCameraMovement;

    private void OnEnable()
    {
        // Cada vez que se abre el menú, carga los valores actuales
        LoadValuesIntoUI();
    }

    private void LoadValuesIntoUI()
    {
        var s = SettingsManager.Instance.Settings;

        // Sliders
        sliderMasterVolume.SetValueWithoutNotify(s.masterVolume);
        sliderMusicVolume.SetValueWithoutNotify(s.musicVolume);
        sliderSFXVolume.SetValueWithoutNotify(s.sfxVolume);

        // Toggles
        toggleStickMovement.SetIsOnWithoutNotify(s.stickMovement);
        toggleSmoothCameraMovement.SetIsOnWithoutNotify(s.smoothCameraMovement);
    }

    // ── Sliders ──────────────────────────────────────────

    public void OnMasterVolumeChanged(float value)
    {
        SettingsManager.Instance.Settings.masterVolume = value;
        SettingsManager.Instance.Save();
        SettingsManager.Instance.ApplySettings();
    }

    public void OnMusicVolumeChanged(float value)
    {
        SettingsManager.Instance.Settings.musicVolume = value;
        SettingsManager.Instance.Save();
        SettingsManager.Instance.ApplySettings();
    }

    public void OnSFXVolumeChanged(float value)
    {
        SettingsManager.Instance.Settings.sfxVolume = value;
        SettingsManager.Instance.Save();
        SettingsManager.Instance.ApplySettings();
    }

    // ── Toggles ──────────────────────────────────────────

    public void OnStickMovementChanged(bool value)
    {
        SettingsManager.Instance.Settings.stickMovement = value;
        SettingsManager.Instance.Save();
    }

    public void OnSmoothCameraMovementChanged(bool value)
    {
        SettingsManager.Instance.Settings.smoothCameraMovement = value;
        SettingsManager.Instance.Save();
    }

    // ── Utilidades ───────────────────────────────────────

    public void ResetToDefaults()
    {
        SettingsManager.Instance.ResetToDefaults();
        LoadValuesIntoUI();
    }
}