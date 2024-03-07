using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < -6f)
            Destroy(gameObject);
    }
}
