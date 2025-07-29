using UnityEngine;
using Unity.Cinemachine;

public class CameraZoneSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineCamera shoulderCam;
    [SerializeField] private int activePriority = 15;
    [SerializeField] private int defaultPriority = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець увійшов у зону");
            shoulderCam.Priority = activePriority;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець вийшов з зони");
            shoulderCam.Priority = defaultPriority;
        }
    }
}