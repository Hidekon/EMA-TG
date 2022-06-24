using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 10f;

    [SerializeField] TextMeshProUGUI countdownText;

    private void Start()
    {
        currentTime = startTime;
    }

    private void Update()
    {

        if (currentTime >= 0)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("00.00");
        }
        else
        {
            countdownText.text = "00.00";
        }
    }
}
