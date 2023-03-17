using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIJuiseElment : MonoBehaviour
{
    public Transform p;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        popUp();
        
    }


    void popUp()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0.8f, 0.8f, 0), 0.05f);
        transform.position = Vector3.Lerp(transform.position, p.position, 0.05f);
    }
}
