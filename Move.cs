using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //«доровье Ќпс
    public int health = 5;

    //”ровень Ќпс
    public int level = 1;

    //—корость Ќпс
    public float speed = 1.2f;


    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("«доровье игрока: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
