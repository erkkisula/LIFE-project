using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class sprite_script : MonoBehaviour
{
    public Vector2 aPosition1 = new Vector2(-385, -180);
    public Vector2 aPosition2 = new Vector2(-385, 100);
    public Vector2 aPosition3 = new Vector2(385, 100);
    public Vector2 aPosition4 = new Vector2(385, -100);
    public string MoveCheck = "1";
    void Start()
    {
        
    }

    void Update()
    {   
        print(aPosition1);
        if (MoveCheck == "4") {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition1, 300 * Time.deltaTime);
            if (Convert.ToInt32(transform.position.x) == aPosition1[0] && Convert.ToInt32(transform.position.y) == aPosition1[1]) {
                print(aPosition1);
                MoveCheck = "1";
            }
        } else if (MoveCheck == "1"){
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition2, 300 * Time.deltaTime);
            if (Convert.ToInt32(transform.position.x) == aPosition2[0] && Convert.ToInt32(transform.position.y) == aPosition2[1]) {
                MoveCheck = "2";
            }
        } else if (MoveCheck == "2") {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition3, 300 * Time.deltaTime);
            if (Convert.ToInt32(transform.position.x) == aPosition3[0] && Convert.ToInt32(transform.position.y) == aPosition3[1]) {
                MoveCheck = "3";
            }
        } else if (MoveCheck == "3") {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition4, 300 * Time.deltaTime);
            if (Convert.ToInt32(transform.position.x) == aPosition4[0] && Convert.ToInt32(transform.position.y) == aPosition4[1]) {
                MoveCheck = "4";
            }
        }
        
    }
}
