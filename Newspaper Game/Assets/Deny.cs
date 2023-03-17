
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deny : MonoBehaviour
{
    public GameObject DenyImage;
    public Transform DenyParent;
    public RectTransform[] Colliders;
    void Update()
    {
        transform.position = Input.mousePosition;
        if (Input.GetMouseButton(0))
            transform.localScale = Vector3.one * 0.9f;
        else
            transform.localScale = Vector3.one;
    }
    public void PressedIt(GameObject idk)
    {
        print(" PRESS IT");
        Instantiate(DenyImage, transform.position, transform.rotation, DenyParent);
        Destroy(idk);
    }
}
