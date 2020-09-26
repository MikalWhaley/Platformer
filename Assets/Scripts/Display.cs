using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Display : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI time;
    public TextMeshProUGUI coins;

    private float timeLimit = 999;
    private int coinCount = 0;
    private int scoreCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= (Time.deltaTime);
        time.text = "TIME \n" + (timeLimit.ToString()).Substring(0, 3);
        ;
    }
}
