using UnityEngine;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;

[RequireComponent(typeof(Rigidbody))]
public class DropableObject : MonoBehaviour
{
    public PieceID objectPieceID;

    private Vector3 _initPos;
    private Quaternion _initRot;
    private Transform _target;
    private Rigidbody _rb;
    private Grabbable _grabbable;

    public bool IsGrabbed => _grabbable != null && _grabbable.SelectingPointsCount > 0;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _grabbable = GetComponent<Grabbable>();
        _initPos = transform.position;
        _initRot = transform.rotation;
    }

    public void SetPosition(Transform target)
    {
        SetGrabEnabled(false);
        _rb.linearVelocity = Vector3.zero;
        _rb.angularVelocity = Vector3.zero;
        _rb.isKinematic = true;
        _target = target;
    }

    public void EnableGrab()
    {
        transform.SetParent(null);
        _rb.isKinematic = false;
        SetGrabEnabled(true);
    }

    public void ReturnToInitPos()
    {
        _target = null;
        transform.SetParent(null);
        transform.SetPositionAndRotation(_initPos, _initRot);
        _rb.isKinematic = false;
        SetGrabEnabled(true);
    }

    private void SetGrabEnabled(bool value)
    {
        if (_grabbable != null) _grabbable.enabled = value;
        foreach (var g in GetComponentsInChildren<GrabInteractable>())
            g.enabled = value;
        foreach (var g in GetComponentsInChildren<DistanceGrabInteractable>())
            g.enabled = value;
        foreach (var g in GetComponentsInChildren<HandGrabInteractable>())
            g.enabled = value;
        foreach (var g in GetComponentsInChildren<DistanceHandGrabInteractable>())
            g.enabled = value;
    }

    void Update()
    {
        if (_target == null) return;
        transform.SetPositionAndRotation(
            Vector3.Lerp(transform.position, _target.position, Time.deltaTime * 10f),
            Quaternion.Slerp(transform.rotation, _target.rotation, Time.deltaTime * 10f)
        );
        if (Vector3.Distance(transform.position, _target.position) < 0.005f)
        {
            transform.SetPositionAndRotation(_target.position, _target.rotation);
            _target = null;
        }
    }
}
