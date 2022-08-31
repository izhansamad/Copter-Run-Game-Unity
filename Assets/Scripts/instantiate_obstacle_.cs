using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate_obstacle_ : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject obstacleWithRing;
    public float timeRate;
    public float repeatRate;

    // Start is called before the first frame update
    void Start()
    {
       
        InvokeRepeating("Spawner",timeRate*Time.deltaTime,repeatRate*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawner()
    {
        int randomHeight = Random.Range(80, 120);
        obstacle.transform.localScale = new Vector3(15f, randomHeight, 15f);
        obstacleWithRing.transform.localScale = new Vector3(15f, randomHeight, 15f);

        int RingCheck = Random.Range(0, 20);
        if (RingCheck == 1)
        {
            Instantiate(obstacleWithRing, gameObject.transform.position, Quaternion.identity);
            Instantiate(obstacle, gameObject.transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(obstacle, gameObject.transform.position, Quaternion.identity);
        }

    }
}
