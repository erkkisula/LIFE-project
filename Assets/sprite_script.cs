using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class sprite_script : MonoBehaviour
{
  public Vector2 aPosition1 = new Vector2(-385, -200);
  public Vector2 aPosition2 = new Vector2(-385, 100);
  public Vector2 aPosition3 = new Vector2(385, 100);
  public Vector2 aPosition4 = new Vector2(385, -200);
  public int MoveCheck = 1;
  public Boolean isTestRunning = false;
  public Boolean isWalking = true;

  DateTime workStartTime = new DateTime(1970, 1, 1);

  void Start()
  {

  }

  void Update()
  {
    runTest();
  }

  public void startTest()
  {
    isTestRunning = true;
  }

  public void runTest()
  {
    if (!isTestRunning) return;
    checkIfCanMoveAgain();
    if (isWalking) movement();

  }

  void movement()
  {
    if (MoveCheck == 4)
    {
      moveToPos(aPosition1);
      checkIfAtPos(aPosition1, 1);
    }
    else if (MoveCheck == 1)
    {
      moveToPos(aPosition2);
      checkIfAtPos(aPosition2, 2);
    }
    else if (MoveCheck == 2)
    {
      moveToPos(aPosition3);
      checkIfAtPos(aPosition3, 3);
    }
    else if (MoveCheck == 3)
    {
      moveToPos(aPosition4);
      checkIfAtPos(aPosition4, 4);
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
      MoveCheck = newPosIndex;
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
}
