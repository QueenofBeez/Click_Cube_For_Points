using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeBehavior : MonoBehaviour
{
    public int id = -1;
    public Generator manager;

    bool mouseOver = false; 

    private float lifeSpan;
    public int points;

    void Start()
    {
        lifeSpan = Random.Range(2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {

        lifeSpan -= 0.001f;

        if (Input.GetMouseButtonUp(0) && mouseOver)
        {
            manager.score += points;
            Debug.Log(manager.score);
            Destroy(gameObject);
            Debug.Log("Boom");
        }

        if (lifeSpan <=0f)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseOver()
    {
        //transform.localScale = new Vector3(1, 2, 1);
        mouseOver = true;

    }

    void OnMouseExit()
    {
        //transform.localScale = Vector3.one;
        mouseOver = false;
    }

}