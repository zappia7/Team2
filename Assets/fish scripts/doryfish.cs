using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doryfish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float n =0;
    private float parse = 1500;
    private float speed = 2;
    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward*Time.deltaTime *speed);
        //transform.Translate(0,0,0);

        n = n+1;
        if(n > 1500 ){
            transform.Translate(0,0,-parse*Time.deltaTime *speed);
            n=0;
        }
    

    }
}
