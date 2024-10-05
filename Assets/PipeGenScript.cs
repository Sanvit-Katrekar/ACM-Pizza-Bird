using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    public float deadZone = -45;


    void Start()
    {
        Instantiate(pipe, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float highestPoint = transform.position.y + heightOffset;
            float lowestPoint = transform.position.y - heightOffset;
            Vector3 pipePosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);
            Instantiate(pipe, pipePosition, transform.rotation);
            timer = 0;
        }
        
    }
}
