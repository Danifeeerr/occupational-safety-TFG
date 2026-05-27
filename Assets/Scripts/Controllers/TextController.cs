using TMPro;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class TextController : MonoBehaviour
{
    [SerializeField] private string key;
    [SerializeField] private List<string> keys;
    private int index;

    void OnEnable()
    {
        Translations.OnLanguageChanged += Refresh;
        Refresh();
        index = 0;
    }

    void Start()
    {
        Translations.OnLanguageChanged += Refresh;
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

    public void RefreshWithNextList()
    {
        if (index < keys.Count -1) ++index;
        GetComponent<TMP_Text>().text = Translations.Get(keys[index]);
    }

    public void RefreshWithPreviousList()
    {
        if (index > 0) --index;
        GetComponent<TMP_Text>().text = Translations.Get(keys[index]);
    }
}