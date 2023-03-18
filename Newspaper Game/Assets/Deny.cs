
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deny : MonoBehaviour
{

    public GameObject DenyImage;
    public Transform DenyParent;
    public bool isHolding;
    public Collider2D[] options;
    public GameManager gm;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            gm.UpdatePage();

        if (isHolding)
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward;
        
        if (Input.GetMouseButtonDown(0) && isHolding)
            transform.localScale *= 0.9f;
        if (Input.GetMouseButtonUp(0) && isHolding)
                transform.localScale *= 1.11111111111111111111111111111111111111f;

        if (Input.GetMouseButtonDown(1) && isHolding)
            isHolding = false;

        if (Input.GetMouseButtonDown(0) && isHolding)
            UsedStamp();
        else
            if (Input.GetMouseButtonUp(0) && !isHolding && gameObject.GetComponent<Collider2D>().OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
            isHolding = true;
    }
    public void UsedStamp()
    {
        Instantiate(DenyImage, transform.position, transform.rotation, DenyParent);

    }
    public void ChangeHoldState() {
        isHolding = !isHolding;
    }
}
