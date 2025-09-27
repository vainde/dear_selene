using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float walkingSpeed = 5.0f;
    public float runningSpeed = 10.0f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      MoveForward();
    }

    // Checks if the player is holding left shift.
    bool IsRunning()
    {
      return Input.GetKey(KeyCode.LeftShift);
    }

    // Retrieves the correct speed based on the player walking or running
    float GetSpeed()
    {
      return IsRunning() ? runningSpeed : walkingSpeed;
    }

    // Moves the player forward if they are holding down W
    void MoveForward()
    {
      if (Input.GetKey(KeyCode.W))
      {
        float speed = GetSpeed();
        transform.Translate(Time.deltaTime * speed * Vector3.forward);
      }
    }
}
