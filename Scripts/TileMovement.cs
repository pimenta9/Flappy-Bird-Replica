using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float speedIncrease = .01f;

    private float newX;

    private bool start;

    [SerializeField] private Rigidbody2D birdRB;

    [SerializeField] private Text pressSpaceMsg;
    [SerializeField] private SpriteRenderer startGameDisplay;
    [SerializeField] private BirdMovement birdMovementScript;

    private bool toggleMessage;
 
    private void Start()
    {
        start = false;
        toggleMessage = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            start = true;
            birdRB.gravityScale = 2.5f;
            if (birdMovementScript.jump)
                birdRB.velocity = new Vector2(0, 7);
        }

        if (start)
        {
            if (toggleMessage)
            {
                pressSpaceMsg.enabled = false;
                toggleMessage = false;
            }
            startGameDisplay.enabled = false;

            newX = this.transform.position.x - speed * Time.deltaTime;
            this.transform.position = new Vector3(newX, this.transform.position.y, this.transform.position.z);

            // increase speed
            speed += speedIncrease * Time.deltaTime;
        }
    }
}
