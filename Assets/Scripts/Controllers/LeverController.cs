using UnityEngine;

public class LeverController : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent onLeverPulled;
    private bool _isPulled = false;

    private void OnTriggerEnter(Collider other)
    {
        if (_isPulled) return;
        if (!HasTagInParents(other.transform, "hand")) return;

        _isPulled = true;
        transform.Rotate(90f, 0f, 0f);
        onLeverPulled.Invoke();
    }

    private bool HasTagInParents(Transform t, string tag)
    {
        while (t != null)
        {
            if (t.CompareTag(tag)) return true;
            t = t.parent;
        }
        return false;
    }
}
