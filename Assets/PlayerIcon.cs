using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIcon : MonoBehaviour
{
    private float checkTime = 0.001f;
    private Vector2 oldPos;
    public PlayerMovement mapIcon;
    // Update is called once per frame
    void Update()
    {
        if (checkTime <= 0)
        {
            oldPos = transform.position;
            checkTime = 0.1f;
        }
        else
        {
            checkTime -= Time.deltaTime;
        }

        if(Vector2.Distance(transform.position, oldPos) < 0.1f)
        {
            mapIcon.speed = 0;
        }
        else
        {
            mapIcon.speed = 18;
        }
    }
}
