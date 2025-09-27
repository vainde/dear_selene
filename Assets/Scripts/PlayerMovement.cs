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
      MoveBackward();
      MoveLeft();
      MoveRight();
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

    void MoveForward()
    {
      if (Input.GetKey(KeyCode.W))
      {
        float speed = GetSpeed();
        transform.Translate(Time.deltaTime * speed * Vector3.forward);
      }
    }

    void MoveBackward()
    {
      if (Input.GetKey(KeyCode.S))
      {
        float speed = GetSpeed();
        transform.Translate(Time.deltaTime * speed * Vector3.back);
      }
    }

    void MoveLeft()
    {
      if (Input.GetKey(KeyCode.A)){
        float speed = GetSpeed();
        transform.Translate(Time.deltaTime * speed * Vector3.left);
      }
    }

    void MoveRight()
    {
      if (Input.GetKey(KeyCode.D))
      {
        float speed = GetSpeed();
        transform.Translate(Time.deltaTime * speed * Vector3.right);
      }
    }
}
