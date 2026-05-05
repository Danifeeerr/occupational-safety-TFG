using System.IO;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager Instance { get; private set; }

    public GameSettings Settings { get; private set; }

    private string _savePath;

    private void Awake()
    {
        // Singleton
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        _savePath = Path.Combine(Application.persistentDataPath, "settings.json");
        Load();

        if(!File.Exists(_savePath))
        {
            Save(); // Guarda los valores por defecto si no existe el archivo
        }
    }

    public void Save()
    {
        string json = JsonUtility.ToJson(Settings, prettyPrint: true);
        File.WriteAllText(_savePath, json);
        Debug.Log($"[Settings] Guardado en: {_savePath}");
    }

    public void Load()
    {
        if (File.Exists(_savePath))
        {
            string json = File.ReadAllText(_savePath);
            Settings = JsonUtility.FromJson<GameSettings>(json);
            Debug.Log("[Settings] Cargado correctamente.");
        }
        else
        {
            Settings = new GameSettings(); // valores por defecto
            Debug.Log("[Settings] No existe archivo, usando valores por defecto.");
        }
    }

    public void ResetToDefaults()
    {
        Settings = new GameSettings();
        Save();
    }
}
