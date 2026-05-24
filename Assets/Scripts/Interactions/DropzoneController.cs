using UnityEngine;

public class DropZoneController : MonoBehaviour
{
    [Header("Expected piece")]
    public PieceID pieceID;
    public float rotationTolerance = 15f;
    public bool setParent = true;

    [Header("Haptics")]
    [Range(0f, 1f)] public float hapticFrequency = 0.5f;
    [Range(0f, 1f)] public float hapticAmplitude = 0.4f;

    public UnityEngine.Events.UnityEvent onObjectPlaced;

    private bool _filled = false;
    private Renderer[] _renderers;

    private void Awake()
    {
        _renderers = GetComponentsInChildren<Renderer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (_filled) return;
        var dropable = other.GetComponentInParent<DropableObject>();
        if (dropable == null) return;
        if (dropable.objectPieceID != pieceID) return;

        bool aligned = Quaternion.Angle(dropable.transform.rotation, transform.rotation) <= rotationTolerance;

        if (!aligned || !dropable.IsGrabbed)
        {
            StopHaptics();
        }

        if (!aligned) return;

        if (dropable.IsGrabbed)
        {
            OVRInput.SetControllerVibration(hapticFrequency, hapticAmplitude, OVRInput.Controller.Touch);
            return;
        }

        _filled = true;
        StopHaptics();
        foreach (var r in _renderers) r.enabled = false;
        if (setParent) dropable.transform.SetParent(transform);
        dropable.SetPosition(transform);
        onObjectPlaced.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponentInParent<DropableObject>() != null)
            StopHaptics();
    }

    private void StopHaptics()
    {
        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.Touch);
    }
}
