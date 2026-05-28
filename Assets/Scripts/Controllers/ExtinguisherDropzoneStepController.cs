using UnityEngine;

public class ExtinguisherDropzoneStepController : MonoBehaviour
{
    [SerializeField] private string myStep;

    public UnityEngine.Events.UnityEvent<string> extinguisherStepDone;
    public UnityEngine.Events.UnityEvent stepCompleted;
    public UnityEngine.Events.UnityEvent incorrectStep;
    
    public void callProtocol()
    {
        extinguisherStepDone.Invoke(myStep);
    }

    public void checkStep(string step)
    {
        if (step == myStep)
        {
            stepCompleted.Invoke();
            Debug.Log("Se ha completado correctamente");
        }
    }

    public void checkIncorrectStep(string step)
    {
        if (step == myStep)
        {
            incorrectStep.Invoke();    
            Debug.Log("No era el paso que tocaba, se invoca al incorrectStep");
        }
    }

}
