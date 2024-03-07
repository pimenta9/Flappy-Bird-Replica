using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTile : MonoBehaviour
{
    public GameObject tile;

    private bool create = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < 6f && create)
        {
            GameObject newTile = Instantiate(tile, new Vector2(this.transform.position.x + 6.575f, this.transform.position.y), Quaternion.identity);
            newTile.transform.SetParent(this.transform.parent.transform);
            create = false;
            Debug.Log(this.name + " " + this.transform.position.x);
        }
    }
}
