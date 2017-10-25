using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour {

    [SerializeField]
    private GameObject obj;
    Vector3 position;
    // Use this for initialization
    void Start()
    {
        position = this.gameObject.transform.position;
        StartCoroutine(Car());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Car()
    {

        yield return new WaitForSeconds(2);
        Vector3 temp = new Vector3(position.x, Random.Range(-1f, 4f), 0);
        Instantiate(obj, temp, Quaternion.identity);
        StartCoroutine(Car());

    }
}