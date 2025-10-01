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
}
