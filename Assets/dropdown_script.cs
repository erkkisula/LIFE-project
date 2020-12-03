using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dropdown_script : MonoBehaviour
{
    public int previousValue = 0;
    public int selectedValue = 0;

    public bool isUiEvent = true;

    public TMP_Dropdown thisDropdown;

    private GameObject controller;

    private GameObject objectController;

    void Start()
    {
        controller = GameObject.Find("Menu_Panel");
        objectController = GameObject.Find("Game_UI_elements");
    }

    public void handleInput(int val)
    {
        if (isUiEvent)
        {
            controller.GetComponent<int_menu_script>().swapObjects(val, selectedValue, objectController.GetComponent<game_ui>().gameObjects);
            previousValue = selectedValue;
            selectedValue = val;
        }
        else
        {
            isUiEvent = true;
        }

    }

    public void setDropdownValue(int newVal)
    {
        isUiEvent = false;
        previousValue = selectedValue;
        selectedValue = newVal;
        thisDropdown.value = selectedValue;
    }
}
