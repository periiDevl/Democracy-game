
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Deny : MonoBehaviour
{

    public GameObject ApproveImage;
    public GameObject DenyImage;
    public Transform DenyParent;
    public bool isHolding;
    public Collider2D[] options;
    public GameManager gm;
    public int denyAmount = 3;
    public TMP_Text text;
    void Update()
    {
        text.text = denyAmount.ToString();

        if (ApproveImage.GetComponent<Collider2D>().OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            gm.UpdatePage();
            denyAmount = 3;
        }

        ApproveImage.transform.position = new Vector2(ApproveImage.transform.position.x, ApproveImage.transform.position.y + Mathf.Sin(Time.time * 10) / 80);

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
        if (denyAmount > 0 )
        {
            Instantiate(DenyImage, transform.position, transform.rotation, DenyParent);
            denyAmount--;
        }

    }
    public void ChangeHoldState() {
        isHolding = !isHolding;
    }
}
