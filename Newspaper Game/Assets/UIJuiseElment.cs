using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIJuiseElment : MonoBehaviour
{
    public Vector3 startPos, origin, wantedScale;
    // Start is called before the first frame update
    void Awake()
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
        transform.localScale = Vector3.Lerp(transform.localScale, wantedScale, 3 * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, origin, 3 * Time.deltaTime);
    }
}
