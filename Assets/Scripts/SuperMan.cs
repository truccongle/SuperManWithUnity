using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperMan : MonoBehaviour {
    Rigidbody2D rig;
    Animator ani;
    AudioSource audio;
    GameObject obj;
    Vector2 vt = new Vector2(4, 0);
    public static SuperMan instance;
    private bool state= true;
    public int score= 0;
    [SerializeField] private Text textScore;
    [SerializeField] private AudioClip flyClip,pingClip,DiedClip;
    private int highScore= 0;
    [SerializeField] private GameObject GameOverShow;
   


    // Use this for initialization
    void Start()
    {
        obj = this.gameObject;
        rig = this.GetComponent<Rigidbody2D>();
        ani=this.GetComponent<Animator>();
        audio=this.GetComponent<AudioSource>();
        
        



    }

    // Update is called once per frame
    void Update()
    {
        //{
        //    if (state)
        //    {
        //        float angle;

        //        if (rig.velocity.y > 0)
        //        {
        //            angle = Mathf.Lerp(0, 0, rig.velocity.y / 7);
                  
        //            transform.rotation = Quaternion.Euler(0, 0, angle);
        //        }
        //        else
        //        {
        //            angle = Mathf.Lerp(0, 10, -rig.velocity.y / 7);
                    
        //            transform.rotation = Quaternion.Euler(0, 0, -angle);
        //        }


        //        //if (Input.GetKey(KeyCode.UpArrow))
        //        //{
        //        //    rig.velocity = new Vector3(0, 4, 0);
        //        //    //       obj.transform.Translate(0, 4 * Time.deltaTime, 0);



        //    }
            
        //    }
        }
    public void ScreenTap()
    {
        if(state)
        {
            audio.PlayOneShot(flyClip);
            rig.velocity = new Vector3(0, 6, 0);
        }
    }

    void makeInstance()
    {
        if (instance == null) instance = this;
    }
    void OnTriggerEnter2D(Collider2D tag)
    {
        if (tag.gameObject.tag == "Car")
        {
            Destroy(gameObject);
            GameController.instance.GameOverShow();
        
          

        }
    }
            void OnTriggerExit2D(Collider2D tag){
                if(tag.gameObject.tag=="Coin")
                {
                    
                    audio.PlayOneShot(pingClip);
                    score++;
                    textScore.text= "" + score;
                   
                }

            }
    
public bool getState()
{
    return this.state;
}
    public int getScore(){
        return this.score;
    }
}
