using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LockpickGame : MonoBehaviour
{
    public Text pin1Text;
    public Text pin2Text;
    public Text pin3Text;
    public Text timerText;
    public UnityEngine.UI.Button toolButton1;
    public UnityEngine.UI.Button toolButton2;
    public UnityEngine.UI.Button toolButton3;
    public GameObject winPanel;
    public GameObject losePanel;

    private int pin1Value = 3;
    private int pin2Value = 6;
    private int pin3Value = 8;
    private float timer = 30f;

    void Start()
    {
        toolButton1.onClick.AddListener(ToolButton1Click);
        toolButton2.onClick.AddListener(ToolButton2Click);
        toolButton3.onClick.AddListener(ToolButton3Click);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Round(timer).ToString();

        if (timer <= 0f)
        {
            Time.timeScale = 0f; // Остановка времени игры
            losePanel.SetActive(true);
        }

        if (pin1Value == 5 && pin2Value == 5 && pin3Value == 5)
        {
            WinGame();
        }
    }

    void ToolButton1Click()
    {
        pin1Value = Mathf.Clamp(pin1Value + 1, 0, 10);
        pin2Value = Mathf.Clamp(pin2Value - 1, 0, 10);
        pin3Value = Mathf.Clamp(pin3Value - 0, 0, 10);
        UpdatePinTexts();
    }

    void ToolButton2Click()
    {
        pin1Value = Mathf.Clamp(pin1Value - 1, 0, 10);
        pin2Value = Mathf.Clamp(pin2Value + 2, 0, 10);
        pin3Value = Mathf.Clamp(pin3Value - 1, 0, 10);
        UpdatePinTexts();
    }

    void ToolButton3Click()
    {
        pin1Value = Mathf.Clamp(pin1Value - 1, 0, 10);
        pin2Value = Mathf.Clamp(pin2Value + 1, 0, 10);
        pin3Value = Mathf.Clamp(pin3Value + 1, 0, 10);
        UpdatePinTexts();
    }

    void UpdatePinTexts()
    {
        pin1Text.text = pin1Value.ToString();
        pin2Text.text = pin2Value.ToString();
        pin3Text.text = pin3Value.ToString();
    }

    private void WinGame()
    {
        winPanel.SetActive(true);
    }

    private void LoseGame()
    {
        losePanel.SetActive(true);
    }
}