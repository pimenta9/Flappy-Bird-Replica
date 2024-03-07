using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public int x = 17;

    void Start()
    {
        int dezena = x / 10;

        Debug.Log(dezena);
    }
}