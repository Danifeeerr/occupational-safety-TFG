using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent onButtonPressed;
    [SerializeField] private float pressDepth = 0.02f;
    [SerializeField] private float pressSpeed = 0.08f;

    private bool _isPressed = false;
    private Vector3 _initLocalPos;

    private void Start()
    {
        _initLocalPos = transform.localPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_isPressed) return;
        if (!HasTagInParents(other.transform, "hand")) return;

        _isPressed = true;
        onButtonPressed.Invoke();
        StartCoroutine(PressAnimation());
    }

    private IEnumerator PressAnimation()
    {
        Vector3 pressedPos = _initLocalPos - Vector3.up * pressDepth;
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / pressSpeed;
            transform.localPosition = Vector3.Lerp(_initLocalPos, pressedPos, t);
            yield return null;
        }
        transform.localPosition = pressedPos;
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
