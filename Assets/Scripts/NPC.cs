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
}
