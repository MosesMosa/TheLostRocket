using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unblock : MonoBehaviour
{
    void Update()
    {
        if (Score.count  == 0)
        {
            Destroy(gameObject);
        }
    }
}
