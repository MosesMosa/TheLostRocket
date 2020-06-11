using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int count = 14;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
        score.text = count.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        score.text = count.ToString();
    }
}
