using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMainTitle : MonoBehaviour
{
    [SerializeField] GameObject mainTile;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.SetParent(mainTile.transform);
    }
}
