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
}
