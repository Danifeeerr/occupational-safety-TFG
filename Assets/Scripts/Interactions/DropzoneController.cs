using UnityEngine;

public class DropZoneController : MonoBehaviour
{
    [Header("Expected piece")]
    public PieceID pieceID;
    public float rotationTolerance = 15f;
    public bool setParent = true;

    public UnityEngine.Events.UnityEvent onObjectPlaced;

    private bool _filled = false;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (_filled) return;
        if (!other.TryGetComponent<DropableObject>(out var dropable)) return;
        if (dropable.objectPieceID != pieceID) return;
        if (Quaternion.Angle(other.transform.rotation, transform.rotation) > rotationTolerance) return;
        if (dropable.IsGrabbed) return;

        _filled = true;
        if (_renderer != null) _renderer.enabled = false;
        dropable.SetPosition(transform);
        if (setParent) other.transform.SetParent(transform);
        onObjectPlaced.Invoke();
    }
}
