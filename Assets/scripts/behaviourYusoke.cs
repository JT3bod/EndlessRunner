using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class behaviourYusoke : MonoBehaviour
{
    public Slider sliderInstance;
    public Rigidbody2D rig2;
    public Animator anim2;
    public Animator anim;
    public GameObject yu;
    public GameObject en;

    public bool death = false;
    public bool attacked = false;
    public bool swordDeath = false;
    public int time = 0;
    public int dtime = 0;
    public int otime = 61;
    int attacktime = 5;
    int start = 0;
    int attackframe;
    // Use this for initialization
    void Start()
    {
        anim2 = GetComponent<Animator>();
        anim2.Play("enterEnemy");
        time = 30;
        rig2.gravityScale = 0.5f;


    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= -2f) { rig2.gravityScale = 0f; rig2.velocity = new Vector2(0, 0); }
        if (transform.position.y >= -2f) { rig2.gravityScale = 1f; }
        float pos1 = (yu.transform.position.x);
        float pos2 = (transform.position.x);
        float total = pos1 - pos2;

        if (attackframe > 1) { attackframe--; }
        else if (time > 1) { time--; }
        else if (dtime > 1) { dtime--; }
        else if (otime < 60) { otime++; }
        else if (otime == 60) { en.SetActive(false); }
        else if (death) { anim2.Play("deathstay"); }
        else if (swordDeath) {
            anim2.Play("death");
            time = 30;
            dtime = 30;
            transform.Translate(0, -1.5f, 0);
            death = true;
        }
        else
        {
            if (attacktime == 0)
            {
                anim2.Play("attackYusoke");
                attacktime = 120;
                attackframe = 50;
            }
            else if (Input.GetMouseButtonDown(0))
            {
                if (total >= -3.5)
                {
                    swordDeath = true;


                }


            }

            else if (total >= 1)
            {
                anim2.Play("outro");
                otime = 0;
            }
            else if (total >= -1.5 && !attacked)
            {
                anim2.Play("attackYusoke");
                anim.Play("hit");
                attackframe = 50;
                attacked = true;
            }
            else
            {
                anim2.Play("walking");
                transform.Translate(-0.05f, 0, 0);



            }
            if (Input.GetKey(KeyCode.X))
            {
                if (sliderInstance.value == 100f)
                {

                    anim2.Play("death");
                    dtime = 30;
                    transform.Translate(0, -1.5f, 0);
                    death = true;
                    // this.GameObject.SetActive(false);
                }
            }
        }
            attacktime--;
    }
}
