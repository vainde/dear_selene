using UnityEngine;

public class NPC : InteractableObject
{
  void Start()
  {
    SetInteraction();
  }

  void Update()
  {
  }

  public override void SetInteraction()
  {
    interaction = "Press E to talk.";
  }

  public override void Interact()
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      Debug.Log($"Player pressed E when interacting with {gameObject.name}");
    }
  }
}
