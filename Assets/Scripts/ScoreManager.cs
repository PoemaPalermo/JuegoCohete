using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    float timeAlive;
    public Text scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive = Time.timeSinceLevelLoad;
        scoreTxt.text = ((int)timeAlive).ToString();
    }
}
