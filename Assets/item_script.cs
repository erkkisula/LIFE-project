using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_script : MonoBehaviour
{
    public Vector2 position = new Vector2(0, 0);
    public string itemName = null;
    public int itemId = 0;

    void Start()
    {
        setPosition(position);
    }

    void Update()
    {
    }

    public void setPosition(Vector2 newPos) {
        position = newPos;
        transform.position = position;
    }
}
