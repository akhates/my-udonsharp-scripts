
using System;
using Cinemachine.Utility;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class CarcassonneTileSnap : UdonSharpBehaviour
{
    void OnDrop()
    {
        Vector3 pos = gameObject.transform.position;
		
		// making so tile snaps only ay integer cord
        gameObject.transform.position = new Vector3(Mathf.Round(pos.x),0,Mathf.Round(pos.z));
		
		// adjusting rotation so tiles stay at being multiples of 90
        gameObject.transform.rotation = Quaternion.Euler(0, adjustRotation(), 0);
		
		// making so taking it away from zone will respawn tile at center
        if ((gameObject.transform.position.x < 1) || (gameObject.transform.position.x > 19) || (gameObject.transform.position.z < 1) || (gameObject.transform.position.z > 19))
            gameObject.transform.position = new Vector3(10, 1, 10);
    }

    private int adjustRotation()
    {
        float y = gameObject.transform.rotation.eulerAngles.y;
        if (y <= 44)
        {
            return 0;
        }
        if (y >= 45 && y <= 135)
        {
            return 90;
        }
        if (y >= 136 && y <= 225)
        {
            return 180;
        }
        if (y >= 226 && y <= 315)
        {
            return 270;
        }
        if (y >= 316)
        {
            return 360;
        }
        else
        {
			// this shouldn't happen, right?
            Debug.Log("thanks udon");
            return 0;
        }
    }
}
