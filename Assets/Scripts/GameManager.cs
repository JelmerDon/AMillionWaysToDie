using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Player player;

    // Start is called before the first frame update
    private void Awake ()
    {
        Instance = this;
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Player : MonoBehaviour
    {

    }
}
