using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
    public Animator anim;
    public Rigidbody2D rig;
    public Slider sliderInstance;
    public GameObject en;
    int atime;
    int jumptime;
    int attackframe = 0;
    bool crouch = false;
    int runjump = 0;
    int ptime = 50;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
    
    

    // Update is called once per frame
    void Update()
    {
        
        
        if (transform.position.y <= -2.2f) { rig.gravityScale = 0f; rig.velocity = new Vector2(0, 0); }
        if (transform.position.y >= -2.2f) { rig.gravityScale = 1f; rig.velocity = new Vector2(0, 0); }
        float pos1 = (transform.position.x);
        float pos2 = (en.transform.position.x);
        float total = pos1 - pos2;
        if (runjump <= 30 && runjump > 20) { transform.Translate(0.3f, 0.3f, 0); rig.velocity = new Vector2(0, 0); }
        else if(runjump <= 20 && runjump >8 ) { transform.Translate(0, -0.2f, 0); rig.velocity = new Vector2(0, 0); }
        else if(jumptime <= 30 && jumptime >20) { transform.Translate(0, 0.3f, 0); }
        else if(jumptime <= 20 && jumptime >5) { transform.Translate(0, -0.2f, 0); }
        if(atime == 10) { transform.Translate(0, -0.5f, 0); }
        else if(atime == 30) { transform.Translate(0, 0.5f, 0); }
        
        if (attackframe > 1) { attackframe -= 1; }
        else if (ptime < 50) { ptime++; }
        else if (jumptime >= 1) { }
        else
        {
            if (Input.GetKey(KeyCode.X))
            {
                if (sliderInstance.value >= 100f)
                {
                    anim.Play("power");
                    ptime = 0;
                }
            }
            else if (total >= -1.5)
            {
                attackframe = 50;
            }
                if (Input.GetMouseButtonDown(0)) { anim.Play("attack1"); attackframe = 35; atime = 0; }
            else if (Input.GetKey(KeyCode.Space))
            {
                if (Input.GetKey(KeyCode.D))
                {
               runjump = 40;
               anim.Play("jump");
                }
                else
                {
                     anim.Play("jump");
                    jumptime = 50;
                }
            }
            else if (Input.GetKey(KeyCode.A))
            {
                anim.Play("running");
                transform.Translate(-0.3f, 0, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                anim.Play("runningRight");
                transform.Translate(0.3f, 0, 0);
            }
            else
            {
                anim.Play("idle");
            }
        }atime++;jumptime--;runjump--;
    }
}
