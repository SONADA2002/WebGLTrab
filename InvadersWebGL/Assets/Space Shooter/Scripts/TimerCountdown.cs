using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{

    public GameObject textDisplay;
    public int secondsLeft = 60;
    public bool takingAway = false;

    private void Start()
    {
        textDisplay.GetComponent<Text>().text = "00 : " + secondsLeft.ToString();
    }

    private void Update()
    {
        if (takingAway == false && secondsLeft >0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft.ToString();
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + secondsLeft.ToString();
        }
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft.ToString();
        takingAway = false;
    }
}
