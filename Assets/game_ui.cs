using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_ui : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();

    private void populateGameObjects(List<GameObject> gameObjects)
    {
        GameObject newObject;
        newObject = GameObject.Find("Item_1");
        gameObjects.Add(newObject);
        newObject = GameObject.Find("Item_2");
        gameObjects.Add(newObject);
        newObject = GameObject.Find("Item_3");
        gameObjects.Add(newObject);
        newObject = GameObject.Find("Item_4");
        gameObjects.Add(newObject);
    }

    void Start()
    {
        populateGameObjects(gameObjects);
    }
}
