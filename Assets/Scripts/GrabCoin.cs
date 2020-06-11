using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabCoin : MonoBehaviour
{
    public Text score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        FindObjectOfType<AudioManager>().Play("GrabCoin");
        Score.count -= 1;

        //Score.scoreValue += 1;
    }
}
