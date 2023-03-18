using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Sprite> pages;
    List<Vector2[]> StampResults;
    List<Sprite> pagesResults;
    void Awake()
    {
        StampResults = new List<Vector2[]>();
        pagesResults = new List<Sprite>();
    }
    public void UpdatePage()
    {
        GameObject page = GameObject.FindWithTag("Page");
        Sprite s = page.GetComponent<SpriteRenderer>().sprite;

        // remove page from the avialable pages list
        pages.Remove(s);


        Vector2[] allPos = new Vector2[page.transform.childCount];
        for (int i = 0; i < allPos.Length; i++) {
            allPos[i] = page.transform.GetChild(i).position;
            Destroy(page.transform.GetChild(i).gameObject);
        }

        StampResults.Add(allPos);
        pagesResults.Add(s);
        UIJuiseElment element = page.GetComponent<UIJuiseElment>();
        element.enabled = false;
        element.enabled = true;

        PickNewPage();
    }
    void PickNewPage()
    {
        GameObject page = GameObject.FindWithTag("Page");
        SpriteRenderer sr = page.GetComponent<SpriteRenderer>();
        sr.sprite = pages[Random.Range(0, pages.Count)];

    }

}
