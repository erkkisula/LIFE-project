using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dropdown_script : MonoBehaviour
{
    public int selectedValue = 0;

    public void handleInput(int val) {
        selectedValue = val;
        print(val);
    }
}
