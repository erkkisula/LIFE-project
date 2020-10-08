using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_btns : MonoBehaviour
{
    // TODO: Add play game functionality

    public void QuitGame() {
        Debug.Log("Game quit event triggered");
        Application.Quit();
    }
}
