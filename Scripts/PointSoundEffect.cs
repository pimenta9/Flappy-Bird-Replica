using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PointSoundEffect : MonoBehaviour
{
    private AudioSource pointSoundEffect;

    private bool play = true;

    public Score points;

    // Start is called before the first frame update
    void Start()
    {
        pointSoundEffect = GetComponent<AudioSource>();
        points = this.GetComponentInParent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < .35f && play)
        {
            pointSoundEffect.Play();
            play = false;
            points.score++;
        }
    }
}
