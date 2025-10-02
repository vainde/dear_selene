using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : InteractableObject
{
    public string scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      SetInteraction();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void SetInteraction()
    {
      interaction = "Press E to open.";
    }

    public override void Interact()
    {
      if (Input.GetKeyDown(KeyCode.E))
      {
        Debug.Log($"Loading scene {scene}");
        SceneManager.LoadScene(scene);
      }
    }
}
