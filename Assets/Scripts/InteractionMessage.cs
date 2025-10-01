using UnityEngine;
using TMPro;

public class InteractionMessage : MonoBehaviour
{
    public TMP_Text message;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      message.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMessage()
    {
      gameObject.SetActive(true);
    }

    public void HideMessage()
    {
      gameObject.SetActive(false);
    }

    public void SetMessage(string interaction)
    {
       message.text = interaction;
    }
}
