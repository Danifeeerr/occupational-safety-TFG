using UnityEngine;
using System.Collections;

public class LeverController : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent onLeverPulled;
    private bool _isPulled = false;
    public bool rotateX;
    [SerializeField] private float rotationDuration = 0.3f;
    [SerializeField] private float rotationDegrees = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (_isPulled) return;
        if (!HasTagInParents(other.transform, "hand")) return;
        _isPulled = true;
        Vector3 targetRotation = rotateX ? new Vector3(-rotationDegrees, 0f, 0f) : new Vector3(0f, 0f, -rotationDegrees);
        StartCoroutine(RotateLever(targetRotation));
    }

    private IEnumerator RotateLever(Vector3 deltaRotation)
    {
        Quaternion startRot = transform.localRotation;
        Quaternion endRot = startRot * Quaternion.Euler(deltaRotation);
        float elapsed = 0f;

        while (elapsed < rotationDuration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / rotationDuration;
            t = Mathf.SmoothStep(0f, 1f, t); 
            transform.localRotation = Quaternion.Lerp(startRot, endRot, t);
            yield return null;
        }

        transform.localRotation = endRot;
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