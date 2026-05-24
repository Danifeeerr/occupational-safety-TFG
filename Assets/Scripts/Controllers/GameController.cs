using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject locomotorDeactivation;
    [SerializeField] private GameObject teleportDeactivation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (locomotorDeactivation != null)
        {
            locomotorDeactivation.SetActive(false);
        }
        if (teleportDeactivation != null)
        {
            teleportDeactivation.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
