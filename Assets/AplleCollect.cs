using UnityEngine;

public class AppleCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered by: " + other.name); // <- see this in Console
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}