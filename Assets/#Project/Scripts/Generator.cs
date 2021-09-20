using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int timeloop;
    public int score;
    public GameObject cube;
    public GameObject bluecube;
    public int min, max;
    public float Timer = 1;

    void Start()
    {

    }

    Vector3 GeneratedPosition()
    {
        int x,y,z;
        x = Random.Range(min,max);
        y = Random.Range(min,max);
        z = Random.Range(min,max);
        return new Vector3(x,y,z);
    }

    void Update ()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            GameObject cuba;
            timeloop++;
            Timer = 1;
            if (timeloop == 5)
            {
                cuba = Instantiate(bluecube, GeneratedPosition(), Quaternion.identity);
                cuba.GetComponent<CubeBehavior>().manager = this;
                timeloop = 0;
            }
            else
            {
                cuba = Instantiate(cube, GeneratedPosition(), Quaternion.identity);
                cuba.GetComponent<CubeBehavior>().manager = this;
            }
        }

        if (score >= 30)
        {
            Debug.Log("YOU WIN!");
        }
    }
}
