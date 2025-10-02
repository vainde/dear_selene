using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    Vector3 cameraOffset = new(0, 2, -5);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
      transform.position = player.transform.position + cameraOffset;
    }
}
