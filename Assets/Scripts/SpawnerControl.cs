using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControl : MonoBehaviour
{
    [SerializeField]private float speed= 180;
    int a=0;
    int randomTime;
    void Start()
    {
        Invoke("MoveSpawner",2 * Time.deltaTime);
    }

    private void Update()
    {
        if (a == 1)
        {
            transform.Translate(0, speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(0, -speed * Time.deltaTime, 0, 0);
        }
    }

    void MoveSpawner()
    {
        if (a==1)
        {
            a = 0;
        }
        else
        {
            a = 1;
        }
        randomTime = Random.Range(1, 7);
        //Debug.Log(randomTime);
        Invoke("MoveSpawner",randomTime * Time.deltaTime);
    }
}
