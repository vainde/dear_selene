using UnityEngine;

public class Player : MonoBehaviour
{
    // value stored in player is shared by all instances of player
    public static Player Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // can call Player from any script and is not destroyed when scene changes

    private void Awake()
    {
      if (Instance != null)
      {
        Destroy(gameObject);
        return;
      }
      Instance = this;
      DontDestroyOnLoad(gameObject);
    }
}
