using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBckgnd : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float groundHorizontalLength = 20.44f;
	void Start () {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBckgnd();
        }
	}

    private void RepositionBckgnd()
    {
        Vector2 groundOffset = new Vector2((groundHorizontalLength * 2f)-.02f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
