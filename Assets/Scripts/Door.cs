using UnityEngine;
using TMPro;

public class Door : InteractableObject
{  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      SetInteraction();
    }

    // Update is called once per frame
    void Update()
    {
      DisplayMessage();
    }

    public override void SetInteraction()
    {
      interaction = "Press E to open.";
    }

    private void OnTriggerEnter(Collider other)
    {
      Debug.Log("Player collided with door.");
      collided = true;
    }

    private void OnTriggerExit(Collider other)
    {
      Debug.Log("Player is no longer near the door.");
      collided = false;
    }
}
