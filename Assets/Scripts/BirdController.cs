using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    public float upForce = 200f;
    public float rotationDivider = 15f;
    private Rigidbody2D rb2d;
    private bool isDead = false;
    private Animator anim;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	if (isDead == false)
        {
            float angleRotation = 0f;
            if(rb2d.velocity.y<0)
            {
                angleRotation = Mathf.Lerp(0, -89, (-rb2d.velocity.y/rotationDivider));
            }
            transform.rotation = Quaternion.Euler(0, 0, angleRotation);

            if(Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero; // Za każdym razem gdy gracz "skacze", resetujemy prędkość do zera
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }
	}

    void OnCollisionEnter2D()
    {
        isDead = true;
        anim.SetTrigger("Die");
        GM.instance.BirdDie();
    }
}
