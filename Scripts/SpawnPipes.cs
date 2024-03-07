using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipes;
    public GameObject firstGround;

    // Start is called before the first frame update
    void Awake()
    {
        SpawnItem();
    }

    void SpawnItem()
    {
        GameObject newPipe1 = Instantiate(pipes, new Vector2(this.transform.position.x - 0.575f, Random.Range(-5.75f, -1f)), Quaternion.identity);
        newPipe1.transform.SetParent(firstGround.transform);

        GameObject newPipe2 = Instantiate(pipes, new Vector2(this.transform.position.x + 2.8f, Random.Range(-5.75f, -1f)), Quaternion.identity);
        newPipe2.transform.SetParent(firstGround.transform);

        Debug.Log("Pipe Spawned [" + this.name + "]");
    }
}
