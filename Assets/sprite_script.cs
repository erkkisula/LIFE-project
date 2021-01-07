using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class sprite_script : MonoBehaviour
{
    private GameObject controller;
    public int moveCheck = 1;
    public Boolean isTestRunning = false;
    public Boolean isWalking = false;


    DateTime workStartTime = new DateTime(1970, 1, 1);
    DateTime testStartTime = new DateTime(1970, 1, 1);
    DateTime testEndTime = new DateTime(1970, 1, 1);

    public GameObject finishScreen;

    public GameObject failScreen;

    void Start()
    {
        controller = GameObject.Find("Game_UI_elements");
        print(controller);
    }

    void Update()
    {
        runTest();
    }

    public void startTest()
    {
        if (!isTestRunning)
        {
            isTestRunning = true;
            isWalking = true;
            testStartTime = DateTime.Now;
        }
        else
        {
            print("A test is currently under way");
        }
    }

    public void runTest()
    {
        if (!isTestRunning) return;
        checkIfCanMoveAgain();
        if (isWalking) movement();

    }

    void movement()
    {
        if (moveCheck == 0)
        {
            Vector2 posToMove = new Vector2(700, 0);
            transform.position = posToMove;
            checkIfAtPos(posToMove, 1);
            isWalking = true;
        }
        else if (moveCheck == 1)
        {
            Vector2 posToMove = controller.GetComponent<game_ui>().gameObjects[0].GetComponent<item_script>().position;
            moveToPos(posToMove);
            faceTarget(posToMove);
            checkIfAtPos(posToMove, 2);
        }
        else if (moveCheck == 2)
        {
            Vector2 posToMove = controller.GetComponent<game_ui>().gameObjects[1].GetComponent<item_script>().position;
            moveToPos(posToMove);
            faceTarget(posToMove);
            checkIfAtPos(posToMove, 3);
        }
        else if (moveCheck == 3)
        {
            Vector2 posToMove = controller.GetComponent<game_ui>().gameObjects[2].GetComponent<item_script>().position;
            moveToPos(posToMove);
            faceTarget(posToMove);
            checkIfAtPos(posToMove, 4);
        }
        else if (moveCheck == 4)
        {
            Vector2 posToMove = controller.GetComponent<game_ui>().gameObjects[3].GetComponent<item_script>().position;
            moveToPos(posToMove);
            faceTarget(posToMove);
            checkIfAtPos(posToMove, 5);
        }
        else if (moveCheck == 5)
        {
            Vector2 posToMove = new Vector2(-700.0f, -50.0f);
            moveToPos(posToMove);
            faceTarget(posToMove);
            checkIfAtPos(posToMove, 6);
        }
    }

    void moveToPos(Vector2 newPos)
    {
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), newPos, 300 * Time.deltaTime);
    }

    void checkIfAtPos(Vector2 posToCheck, int newPosIndex)
    {
        if (Convert.ToInt32(transform.position.x) == posToCheck[0] && Convert.ToInt32(transform.position.y) == posToCheck[1])
        {
            isWalking = false;
            workStartTime = DateTime.Now;
            moveCheck = newPosIndex;
            if (moveCheck == 6)
            {
                isTestRunning = false;
                moveCheck = 0;
                testEndTime = DateTime.Now;
                checkResult();
            }
        }
    }

    void checkIfCanMoveAgain()
    {
        if (!isWalking)
        {
            TimeSpan span = DateTime.Now - workStartTime;
            if (span.TotalMilliseconds > 3000.0)
            {
                isWalking = true;
            }
        }
    }

    void faceTarget(Vector2 targetDir)
    {
        Vector2 dir = new Vector2(targetDir.x - transform.position.x, targetDir.y - transform.position.y);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void checkResult()
    {
        TimeSpan span = testEndTime - testStartTime;
        print(span.TotalMilliseconds);
        if (span.TotalMilliseconds < 22500.0)
        {
            finishScreen.SetActive(true);
        }
        else
        {
            failScreen.SetActive(true);
        }
    }
}
