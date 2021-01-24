using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class intro_script : MonoBehaviour
{
    private int step = 1;
    private int maxSteps = 3;
    private string[] textStrings = { "Boss: Hi Dr. Researcher, Our company assembles art supplies sets, we have a worker in the other room assembling painting sets, that contain papers, pencils, brushes and colors and sending them out to the customers.", "Boss: However, the process seems to take a little too long, so is there anything you could do about it?", "You: Sounds like a job for testing!!" };
    public TextMeshProUGUI DialogText;

    public void iterateStep()
    {
        if (step < maxSteps)
        {
            step++;
            DialogText.text = textStrings[step - 1];
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    void Start()
    {
        DialogText.text = textStrings[0];

    }

    void Update()
    {

    }
}
