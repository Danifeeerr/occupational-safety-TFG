using UnityEngine;
using Newtonsoft.Json.Linq;

public class ProtocolController : MonoBehaviour
{
    [SerializeField] private TextAsset jsonFile;

    private string[] _steps;
    private int _pointer = 0;
    public UnityEngine.Events.UnityEvent<string> stepDone;
    public UnityEngine.Events.UnityEvent<string> incorrectStep;
    public UnityEngine.Events.UnityEvent finishedProtocol;

    public AudioClip errorSound;
    public AudioClip correctSound;


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
            if (_pointer >= _steps.Length)
            {
                finishedProtocol.Invoke();
            }
            stepDone.Invoke(step);
            AudioController.Instance.PlaySFX(correctSound);
        }
        else
        {
            Debug.LogWarning($"Wrong step. Expected: {_steps[_pointer]}, got: {step}");
            incorrectStep.Invoke(step);
            MistakeMade();
        }
    }

    public void MistakeMade()
    {
        mistakeCounter += 1;
        AudioController.Instance.PlaySFX(errorSound);
    }
}
