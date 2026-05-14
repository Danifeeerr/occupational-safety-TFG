using System;
using System.Collections.Generic;

public static class Translations
{
    public static event Action OnLanguageChanged;
    private static readonly Dictionary<string, Dictionary<string, string>> _STRINGS = new()
    {
        ["ca"] = new Dictionary<string, string>
        {
            //Menu de login
            ["login_title"] = "Inici de sessió",
            ["username_placeholder"] = "Nom d'usuari",
            ["pass_placeholder"] = "Contrasenya",
            ["login_button"] = "Entrar",

            //Menu principal 
            ["main_menu_title"] = "Entrenament PRL en RV",
            ["tutorial_button"] = "Tutorial",
            ["start_training_button"] = "Entrenament",
            ["main_options_button"] = "Opcions",
            ["log_out_button"] = "Tanca sessió",

            //Menu opcions lobby
            ["options_title"] = "Opcions",
            ["master_volume_lbl"] = "Volum general",
            ["music_volume_lbl"] = "Volum música",
            ["sfx_volume_lbl"] = "Volum efectes",
            ["joystick_mvm_label"] = "Moviment amb palanca",
            ["smooth_cam_label"] = "Camera suau",
            ["return_button"] = "Torna",

            ["resume_button"] = "Continuar",
            ["go_lobby_button"] ="Lobby",

        },
        ["es"] = new Dictionary<string, string>
        {
            //Menu de login
            ["login_title"] = "Inicia sesión",
            ["username_placeholder"] = "Nombre de usuario",
            ["pass_placeholder"] = "Contraseña",
            ["login_button"] = "Entrar",

            //Menu principal 
            ["main_menu_title"] = "Entrenamiento PRL en RV",
            ["tutorial_button"] = "Tutorial",
            ["start_training_button"] = "Entrenamiento",
            ["main_options_button"] = "Opciones",
            ["log_out_button"] = "Cerrar sesión",

            //Menu opcions lobby
            ["options_title"] = "Opciones",
            ["master_volume_lbl"] = "Volumen general",
            ["music_volume_lbl"] = "Volumen música",
            ["sfx_volume_lbl"] = "Volumen efectos",
            ["joystick_mvm_label"] = "Movimiento con palanca",
            ["smooth_cam_label"] = "Camara suave",
            ["return_button"] = "Volver",

            ["resume_button"] = "Continuar",
            ["go_lobby_button"] ="Lobby",
        },
        ["en"] = new Dictionary<string, string>
        {
            //Menu de login
            ["login_title"] = "Log in",
            ["username_placeholder"] = "Username",
            ["pass_placeholder"] = "Password",
            ["login_button"] = "Enter",

            //Menu principal
            ["main_menu_title"] = "VR OHS Training",
            ["tutorial_button"] = "Tutorial",
            ["start_training_button"] = "Training",
            ["main_options_button"] = "Options",
            ["log_out_button"] = "Log out",

            //Menu opcions lobby
            ["options_title"] = "Options",
            ["master_volume_lbl"] = "Master volume",
            ["music_volume_lbl"] = "Music volume",
            ["sfx_volume_lbl"] = "SFX volume",
            ["joystick_mvm_label"] = "Joystick movement",
            ["smooth_cam_label"] = "Smooth camera",
            ["return_button"] = "Return",

            ["resume_button"] = "Resume",
            ["go_lobby_button"] ="Lobby",
        },
    };

    public static string Get(string key)
    {
        string lang = SettingsManager.Instance.Settings.lang;
        if (_STRINGS.TryGetValue(lang, out var dict) && dict.TryGetValue(key, out var value))
            return value;
        if (_STRINGS["ca"].TryGetValue(key, out var fallback))
            return fallback;
        return key;
    }

    public static void SetLang(string lang)
    {
        if (!_STRINGS.ContainsKey(lang)) return;
        SettingsManager.Instance.Settings.lang = lang;
        SettingsManager.Instance.Save();
        OnLanguageChanged?.Invoke();
    }

    public static string GetLang() => SettingsManager.Instance.Settings.lang;
}