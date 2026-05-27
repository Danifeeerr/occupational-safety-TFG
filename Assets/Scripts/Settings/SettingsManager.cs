using System.IO;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager Instance { get; private set; }

    public GameSettings Settings { get; private set; }

    [SerializeField] private AudioMixer audioMixer;

    private string _savePath;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        _savePath = Path.Combine(Application.persistentDataPath, "settings.json");
        Load();

        if (!File.Exists(_savePath))
            Save();
    }

    private void Start()
    {
        ApplySettings();
    }

    public void ApplySettings()
    {
        if (audioMixer == null) return;

        audioMixer.SetFloat("Master", ToDecibels(Settings.masterVolume));
        audioMixer.SetFloat("Music",  ToDecibels(Settings.musicVolume));
        audioMixer.SetFloat("SFX",    ToDecibels(Settings.sfxVolume));
    }

    private float ToDecibels(float linearValue)
    {
        return Mathf.Log10(Mathf.Max(linearValue, 0.0001f)) * 20f;
    }

    public void Save()
    {
        string json = JsonUtility.ToJson(Settings, prettyPrint: true);
        File.WriteAllText(_savePath, json);
    }

    public void Load()
    {
        if (File.Exists(_savePath))
        {
            string json = File.ReadAllText(_savePath);
            Settings = JsonUtility.FromJson<GameSettings>(json);
        }
        else
        {
            Settings = new GameSettings();
        }
    }

    public void ResetToDefaults()
    {
        Settings = new GameSettings();
        Save();
        ApplySettings();
    }
}
