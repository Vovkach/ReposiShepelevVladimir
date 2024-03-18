using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text timerText;
    public GameObject losePanel;
    
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStart.ToString();
        losePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();
        if(timeStart > 0)
        {

        } else
        {
            losePanel.SetActive(true);
            timeStart = 0;
        }
    }
}
