using UnityEngine;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

public class ProtocolController : MonoBehaviour
{
    [SerializeField] private TextAsset jsonFile;

    private string[] _steps;
    private int _pointer = 0;
    public UnityEngine.Events.UnityEvent<string> stepDone;
    public UnityEngine.Events.UnityEvent<string> incorrectStep;
    public UnityEngine.Events.UnityEvent finishedProtocol;

    public int trainingId;

    public AudioClip errorSound;
    public AudioClip correctSound;

    [SerializeField] private List<GameObject> _indicators;


    private int mistakeCounter;
    private float _trainingTime;

    private void Start()
    {
        _steps = JObject.Parse(jsonFile.text)["steps"].ToObject<string[]>();
        mistakeCounter = 0;
        _pointer = 0;
        _trainingTime = 0f;
    }

    private void Update()
    {
        if (_pointer < _steps.Length)
            _trainingTime += Time.deltaTime;
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
            if (_indicators[_pointer] != null) _indicators[_pointer].SetActive(false);
            _pointer++;
            if (_pointer < _indicators.Count && _indicators[_pointer] != null) _indicators[_pointer].SetActive(true);
            if (_pointer >= _steps.Length)
            {
                finishedProtocol.Invoke();
                ApiController.Instance.registerTry(mistakeCounter, trainingId, _trainingTime);
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
