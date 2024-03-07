using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField] private AudioSource jumpSoundEffect;
    private Transform transform;

    [SerializeField] private float jumpForce = 9.5f;
    [SerializeField] private float rotationSpeed = 100f;

    public bool jump;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        jumpSoundEffect = GetComponent<AudioSource>();
        jump = true;
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && jump)
        {
            rigidBody.velocity = new Vector2(0, jumpForce);
            jumpSoundEffect.Play();
        }
    }
}
