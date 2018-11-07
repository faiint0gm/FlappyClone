﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<BirdController>()!= null)
        {
            GM.instance.BirdScored();
        }
    }
}
