using UnityEngine;
using System.Collections;
using Oculus.Interaction;
using UnityEngine.Events;

public class ExtinguisherBoxController : MonoBehaviour
{
    [SerializeField] private string myStep;
    [SerializeField] private GameObject extinguisher;
    public UnityEvent<string> extinguisherGrabbed;

    private Vector3 _initPos;
    private Quaternion _initRot;
    private Rigidbody _rb;
    private Grabbable _grabbable;
    private bool _ExtShouldBeInside;

    private void Start()
    {
        _initPos = extinguisher.transform.position;
        _initRot = extinguisher.transform.rotation;
        _rb = extinguisher.GetComponent<Rigidbody>();
        _grabbable = extinguisher.GetComponent<Grabbable>();
        _ExtShouldBeInside = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == extinguisher && _ExtShouldBeInside)
            extinguisherGrabbed.Invoke(myStep);
        
    }

    public void checkStep(string step)
    {
        if (step != myStep && _ExtShouldBeInside)
            StartCoroutine(WaitAndReset());
        else
            _ExtShouldBeInside = false;

    }

    private IEnumerator WaitAndReset()
    {
        while (_grabbable.SelectingPointsCount > 0)
            yield return null;

        _rb.isKinematic = true;
        extinguisher.transform.SetPositionAndRotation(_initPos, _initRot);
        yield return new WaitForFixedUpdate();
        _rb.isKinematic = false;
        _rb.linearVelocity = Vector3.zero;
        _rb.angularVelocity = Vector3.zero;
    }
}
