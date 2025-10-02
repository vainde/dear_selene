using TMPro;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour {
  public InteractionMessage message;
  protected string interaction = "";
  public abstract void SetInteraction();

  public abstract void Interact();

  private void OnTriggerStay(Collider other)
  {
    Debug.Log($"Player collided with {gameObject.name}.");
    message.SetMessage(interaction);
    message.ShowMessage();
    Interact();
  }

  private void OnTriggerExit(Collider other)
  {
    Debug.Log($"Player is no longer near the {gameObject.name}.");
    message.SetMessage("");
    message.HideMessage();
  }
}
