using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class intro_script : MonoBehaviour
{
    private int step = 1;
    private int maxSteps = 3;
    private string[] textStrings = {"STRING_1", "STRING_2", "STRING_3"};
    public TextMeshProUGUI DialogText;

    public void iterateStep() {
        if(step < 3) {
            step++;
            DialogText.text = textStrings[step - 1];
        } else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    
    void Start()
    {
        DialogText.text = textStrings[0];
        
    }

    void Update () {

    }
}
