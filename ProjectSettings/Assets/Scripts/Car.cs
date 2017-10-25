using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    Rigidbody2D rig;
    Animator ani;
    private GameObject obj;
    Vector2 vt = new Vector2(5, 0);
    Vector2 scale;
    // Use this for initialization
    void Start()
    {
        obj = this.gameObject;
        rig = this.GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(-vt * Time.deltaTime, 0);


    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Right")
        {
            Destroy(this.gameObject);
        }




    }
}