using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterControler : MonoBehaviour {
public static bool isRight = true;
	//public float playerspeed = 24;
private Rigidbody2D rb2D;
	public float jump = 1;
	private bool Onground = false;
	public float maxspeed = 1;
	private Animator anim;
	private GameObject zanki;
	private GameObject Camera;
	float h;
	bool jumping = false;
	[SerializeField] LayerMask groundLayer;
	// Update is called once per frame
	 void Start(){
	 	rb2D = GetComponent<Rigidbody2D>();
	 	anim = GetComponent<Animator>();
	 	zanki = GameObject.Find("zanki");
	 	Camera = GameObject.Find("Main Camera");
	}

	void Update () 
	{
		if (Time.timeScale == 0) return;
		if (transform.position.y <= -840){
			zanki.GetComponent<unitmaneger>().death();
            Gamemaneger.boss = false;
		}

		if (transform.position.y <= -840)return;
//左右キーの入力
        if (Input.GetButtonDown("Fire1")){
        	anim.SetTrigger("throw");
        }

		JumpCheck();
	}



	void FixedUpdate ()
	{
		h = Input.GetAxis("Horizontal");
		
		rb2D.AddForce(new Vector2 (h * 2000, 0));
	    
	    if (rb2D.velocity.x >= maxspeed * 600 || rb2D.velocity.x <= -maxspeed * 600){
	    	rb2D.AddForce(new Vector2(h * -2000, 0));
	    }

	    if (h != 0){
	    	anim.SetBool("run", true);
	    }else{
	    	anim.SetBool("run", false);
	    }
	    
        if ((Input.GetButtonDown("Jump")|| Input.GetButtonDown("jump") )&& jumping){
        	//Debug.Log("Jump");
        	rb2D.AddForce(new Vector2 (0, jump*50000));
        }


		if((h > 0 && !isRight) || (h < 0 && isRight))
		{
			//右を向いているかどうかを、入力方向をみて決める
			isRight = (h > 0);
			//localScale.xを、右を向いているかどうかで更新する
			transform.rotation = Quaternion.AngleAxis((isRight ? 0 : 180), Vector2.up);
		}
	}

	void JumpCheck ()
	{
		Debug.DrawLine(transform.position - (transform.up * 70f), transform.position - (transform.up * 80f), Color.red);

		jumping = Physics2D.Linecast(
			transform.position - (transform.up * 70f),
			transform.position - (transform.up * 80f),
			groundLayer
			);
			print(jumping);
	}

    void OnTriggerEnter2D(Collider2D other){
    	
    	if(other.gameObject.tag == "Finish"){
    		Camera.GetComponent<Gamemaneger>().NextStage();
    	}
    }
}