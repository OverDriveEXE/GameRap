using UnityEngine;

public class UmbrellaCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Зіткнення з: " + other.name);

        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreManager>().AddPoint();
            gameObject.SetActive(false);
        }
    }
}