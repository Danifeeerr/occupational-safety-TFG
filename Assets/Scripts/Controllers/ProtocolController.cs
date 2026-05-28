using UnityEngine;
using Newtonsoft.Json.Linq;

public class ProtocolController : MonoBehaviour
{
    [SerializeField] private TextAsset jsonFile;

    private string[] _steps;
    private int _pointer = 0;
    public UnityEngine.Events.UnityEvent<string> stepDone;
    private int mistakeCounter;


    private void Start()
    {
        _steps = JObject.Parse(jsonFile.text)["steps"].ToObject<string[]>();
        mistakeCounter = 0;
        _pointer = 0;
    }

    public void ReceiveStep(string step)
    {
        if (_pointer >= _steps.Length)
        {
            Debug.Log("Protocol already completed");
            return;
        }

        if (_steps[_pointer] == step)
        {
            Debug.Log("Correct step");
            _pointer++;
            stepDone.Invoke(step);
        }
        else
        {
            Debug.LogWarning($"Wrong step. Expected: {_steps[_pointer]}, got: {step}");
        }
    }
}
