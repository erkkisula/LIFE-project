using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class int_menu_script : MonoBehaviour
{

    //.GetComponent<item_script>()
    public List<GameObject> dropdowns = new List<GameObject>();

    void Start()
    {
        populateDropdowns(dropdowns);
    }

    private void populateDropdowns(List<GameObject> dropdowns)
    {
        GameObject newDropdown;
        newDropdown = GameObject.Find("Item_1_dropdown");
        dropdowns.Add(newDropdown);
        newDropdown = GameObject.Find("Item_2_dropdown");
        dropdowns.Add(newDropdown);
        newDropdown = GameObject.Find("Item_3_dropdown");
        dropdowns.Add(newDropdown);
        newDropdown = GameObject.Find("Item_4_dropdown");
        dropdowns.Add(newDropdown);
    }

    public void swapObjects(int id1, int id2, List<GameObject> gameObjects)
    {
        int obj1Index = gameObjects.FindIndex(o => o.GetComponent<item_script>().itemId == id1);
        int obj2Index = gameObjects.FindIndex(o => o.GetComponent<item_script>().itemId == id2);
        Vector2 helper = gameObjects[obj2Index].GetComponent<item_script>().position;
        gameObjects[obj2Index].GetComponent<item_script>().setPosition(gameObjects[obj1Index].GetComponent<item_script>().position);
        gameObjects[obj1Index].GetComponent<item_script>().setPosition(helper);
        updateDropdown(id1, id2);
    }

    public void updateDropdown(int id, int newId)
    {
        int dropdownIndex = dropdowns.FindIndex(d => d.GetComponent<dropdown_script>().selectedValue == id);
        dropdowns[dropdownIndex].GetComponent<dropdown_script>().setDropdownValue(newId);
    }
}
