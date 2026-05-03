using UnityEngine;

public class NPCSystem : MonoBehaviour
{
    bool playerDetection = false; 

    // Update is called once per frame
    void Update()
    {
        if (playerDetection)
        {
            Debug.Log("NPC is interacting with the player.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerDetection = true;
            Debug.Log("Player detected!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerDetection = false;
            Debug.Log("Player lost!");
        }
    }
}
