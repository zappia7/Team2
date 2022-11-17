using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float n =0;
    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward*Time.deltaTime *2);
        //transform.Translate(0,0,0);

        n = n+1;
        if(n > 10000 ){
            transform.Translate(0,0, -10000*Time.deltaTime*2);
            n=0;
        }
    

    }
}
