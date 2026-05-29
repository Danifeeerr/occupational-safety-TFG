using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float amplitude = 0.1f;
    [SerializeField] private float speed = 2f;

    private Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void Update()
    {
        transform.position = _startPos + Vector3.up * (Mathf.Sin(Time.time * speed) * amplitude);
    }
}
