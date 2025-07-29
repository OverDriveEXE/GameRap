using UnityEngine;
using Unity.Cinemachine;

public class HorrorCamZone : MonoBehaviour
{
    [SerializeField] private CinemachineCamera horrorCam; 
    [SerializeField] private int activePriority = 20;
    [SerializeField] private int defaultPriority = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець увійшов у хорор-зону");
            horrorCam.Priority = activePriority;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець вийшов з хорор-зони");
            horrorCam.Priority = defaultPriority;
        }
    }
}