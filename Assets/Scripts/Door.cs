using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    string interaction;
    bool collided = false;
    BoxCollider boxCollider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      GetCollided();
    }

    public void SetInteraction()
    {
      interaction = "Press E to open.";
    }

    public bool GetCollided()
    {
      return collided;
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
