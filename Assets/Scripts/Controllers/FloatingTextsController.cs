using System.Collections.Generic;
using UnityEngine;

public class FloatingTextsController : MonoBehaviour
{
    [SerializeField] private List<string> keys;
    private TextController _tC;

    void OnEnable()
    {
        TryGetComponent<TextController>(out _tC); 
    }
}
