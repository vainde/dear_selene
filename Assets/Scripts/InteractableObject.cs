using TMPro;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour {
  public InteractionMessage message;
  protected bool collided = false;
  protected string interaction = "";
  public abstract void SetInteraction();

  public void DisplayMessage()
  {
    if (collided == true)
    {
      message.SetMessage(interaction);
      message.ShowMessage();
    }
    else
    {
      message.SetMessage("");
      message.HideMessage();
    }
  }
  private void OnTriggerEnter(Collider other)
  {
    Debug.Log($"Player collided with {gameObject.name}.");
    collided = true;
  }

  private void OnTriggerExit(Collider other)
  {
    Debug.Log($"Player is no longer near the {gameObject.name}.");
    collided = false;
  }
}
