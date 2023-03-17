using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPopUp : MonoBehaviour
{
    [SerializeField] private float amp;
    [SerializeField] private float freq;
    [SerializeField] private Transform player;
    [SerializeField] private Transform camera;
    [SerializeField] private float thresh = 1;
    [SerializeField] private GameObject TextObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera.position);
        if (Vector3.Distance(player.position, transform.position) < thresh)
        {
            TextObject.SetActive(true);
            Hill();
        } else
        {
            TextObject.SetActive(false);
        }
    }


    void Hill()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + Mathf.Sin(Time.time * freq) * amp, transform.position.z);
    }
}
