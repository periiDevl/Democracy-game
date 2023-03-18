using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudFade : MonoBehaviour
{
    public Transform cloudObject;
    bool able;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (able)
        {
            cloudObject.localScale = Vector3.Lerp(cloudObject.localScale, new Vector3(3, 3, 3), 0.2f * Time.deltaTime * 100);
            cloudObject.localScale = Vector3.Lerp(cloudObject.localScale, new Vector3(1,1,1), 0.2f * Time.deltaTime * 100);
        }
    }

    public void StartCouldFade()
    {
        able = true;
    }

   
}
