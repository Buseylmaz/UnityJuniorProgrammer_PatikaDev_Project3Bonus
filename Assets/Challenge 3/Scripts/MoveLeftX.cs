using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    /// <summary>
    /// Bomba para ve arkaplanın sola hareketi için
    /// </summary>

    public float speed;
    private float leftBound = -20;

    private PlayerControllerX playerControllerScript;
    

    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    
    void Update()
    {
        // If game is not over, move to the left
        if (playerControllerScript.gameOver==false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
