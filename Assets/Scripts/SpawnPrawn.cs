using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrawn : MonoBehaviour
{
    private float t, height;
    public GameObject foodObject;
    public float spawnTime, maxHeight;

    // Start is called before the first frame update
    void Start()
    {
        t = 0f;
    }

    private void Update()
    {

        t += Time.deltaTime;
        if (t >= spawnTime && UiStuff.isStarted)
        {
            height = Random.Range(-maxHeight, maxHeight);
            Spawn1Prawn();
            t = 2f;
        }
    }

    private void Spawn1Prawn()
    {
        GameObject gameObject1 = Instantiate(foodObject, transform.position + new Vector3(height, 0, 0), transform.rotation);
    }
}

