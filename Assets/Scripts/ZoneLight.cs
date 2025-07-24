using UnityEngine;

public class ZoneLight : MonoBehaviour
{

    [SerializeField] private Light zoneLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            zoneLight.enabled = true;
            Debug.Log("Включити світло");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            zoneLight.enabled = false;
            Debug.Log("Погасити світло!");
        }
    }

}
