using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class TextController : MonoBehaviour
{
    public string key;

    void OnEnable()
    {
        Translations.OnLanguageChanged += Refresh;
        Refresh();
    }

    void Start()
    {
        Refresh();
    }

    void OnDisable()
    {
        Translations.OnLanguageChanged -= Refresh;
    }

    void Refresh()
    {
        GetComponent<TMP_Text>().text = Translations.Get(key);
    }
}