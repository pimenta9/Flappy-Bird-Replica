using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdLife : MonoBehaviour
{
    [SerializeField] private AudioSource hitSFX;
    [SerializeField] private AudioSource dieSFX;
    private BirdMovement birdMovement;
    [SerializeField] private GameObject mainGround;
    [SerializeField] private Text pressSpaceMsg;

    private bool die;

    private float restartGameDelay;

    private void Start()
    {
        birdMovement = GetComponent<BirdMovement>();

        die = true;

        restartGameDelay = 2f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (die)
        {
            hitSFX.Play();
            if (collision.gameObject.CompareTag("Pipe 1"))
            {
                dieSFX.Play();
                Debug.Log("FALL AUDIO");
            }
            mainGround.GetComponent<PipeMovement>().speed = 0f;
            mainGround.GetComponent<PipeMovement>().speedIncrease = 0f;

            birdMovement.jump = false;

            die = false;
        }
    }

    private void Update()
    {
        if (!die)
        {
            restartGameDelay -= Time.deltaTime;
        }
        if (restartGameDelay < 0f)
            SceneManager.LoadScene("Game");
    }
}
