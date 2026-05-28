using UnityEngine;

public class TriggerZonesController : MonoBehaviour
{

    [SerializeField] private bool mistake;
    [SerializeField] private string myStep;

    public UnityEngine.Events.UnityEvent<string> enteredStepZone;
    public UnityEngine.Events.UnityEvent enteredMistakeZone;
    public UnityEngine.Events.UnityEvent exitedMistakeZone;

    private bool stepCompleted;

    private void Start()
    {
        stepCompleted = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (mistake)
        {
            enteredMistakeZone.Invoke();
        }
        else
        {
            if (!stepCompleted)
            {
                enteredStepZone.Invoke(myStep); 
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        exitedMistakeZone.Invoke();
    }

    public void checkStep(string step)
    {
        if (step != myStep) return;
        stepCompleted = true;
    }
}
