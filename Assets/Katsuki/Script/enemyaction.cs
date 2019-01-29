using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyaction : MonoBehaviour {

    string enemyclass;
    private bool isRight = false;
    public float walksp = -1;
    public float upspeed = 0.5f;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start () {
        enemyclass = gameObject.name;
        rb2d = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        if (Time.timeScale == 0) return;
        if (enemyclass == "Bloslime(Clone)")
        {
            transform.Translate(new Vector2(walksp, 0));
        }
        else if (enemyclass == "daikon(Clone)")
        {
            rb2d.AddForce(new Vector2(0, upspeed));
            rb2d.constraints = RigidbodyConstraints2D.FreezeRotation |
        RigidbodyConstraints2D.FreezePositionX;
            if (transform.position.y >= -400)
            {
                rb2d.constraints = RigidbodyConstraints2D.FreezePositionY |
                RigidbodyConstraints2D.FreezePositionX |
                RigidbodyConstraints2D.FreezeRotation;
            }
        } else if (enemyclass == "ame(Clone)")
        {
            rb2d.AddForce(new Vector2(0, -500));

            if (transform.position.y <= -810)
            {
                Destroy(this.gameObject);
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "kabe")
        {
            walksp *= -1;
            print("reflect!");
            transform.rotation = Quaternion.AngleAxis((isRight ? 0 : 180), Vector2.up);//向きの変換
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground" && enemyclass == "ame(Clone)")
        {
            transform.Translate(new Vector2(walksp, 0));
        }
    }
}
