using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler : MonoBehaviour
{
    public Text timerText;
    private float currentTime;
    public Text lapsText;
    private int lapsNumber = 0;
    public Text lapsTimeText;
    private float currentLapTime;
    public Text previousLapTimeText;
    private float previousLapTime;

    void Start()
    {
  
    }
    void Update()
    {
        currentTime = Mathf.Round(Time.time);
        timerText.text = currentTime.ToString();
    }

    public void LapsFinishedButtonClick()
    {
        CalculateRaceData();
        DisplayRaceData();
    }

    private void CalculateRaceData()
    {
        previousLapTime = currentLapTime;
        currentLapTime = currentTime;
        lapsNumber = lapsNumber + 1;
    }

    private void DisplayRaceData()
    {
        lapsTimeText.text = currentLapTime.ToString();
        previousLapTimeText.text = previousLapTime.ToString(); 
        lapsText.text = lapsNumber.ToString();
    }

}
