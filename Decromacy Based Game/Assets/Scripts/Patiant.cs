using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Patiant : MonoBehaviour
{
    int randomNumber;
    int randomSeat;

    public GameObject[] seats;
    public GameObject[] takenSeats;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 15);
        randomSeat = Random.Range(0, seats.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (randomNumber < 2)
        {
            print("gay");
        }
        else if (randomNumber > 2 && randomNumber < 5)
        {
            print("black");
        }
        else if (randomNumber > 5 && randomNumber < 7)
        {
            print("women");
        } else
        {
            print("man white man");
        }


        print(seats[randomSeat].name);
    }
    public Vector3 getSeat()
    {
        int randomSeatIndex = Random.Range(0, seats.Length);
        return seats[randomSeatIndex].transform.position;
        
    }

}
