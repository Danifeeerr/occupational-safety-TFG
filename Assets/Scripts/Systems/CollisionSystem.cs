using UnityEngine;
using System;

public class CollisionEventSystem : MonoBehaviour
{
    public event Action<GameObject> OnTriggerEntered;
    public event Action<GameObject> OnTriggerEnteredOnce;
    public event Action<GameObject> OnCollisionEntered;
    public event Action OnTriggerExited;
    public event Action<GameObject> OnTriggerExitedGO;

    private void OnTriggerStay(Collider other)
    {
        OnTriggerEntered?.Invoke(other.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnCollisionEntered?.Invoke(collision.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        OnTriggerExited?.Invoke();
        OnTriggerExitedGO?.Invoke(other.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        OnTriggerEnteredOnce?.Invoke(other.gameObject);
    }
}