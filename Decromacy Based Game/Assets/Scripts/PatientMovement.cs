using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatientMovement : MonoBehaviour
{
    [SerializeField] public Patiant patientMain;
    [SerializeField] public NavMeshAgent agent;
    void Start()
    {
        agent.SetDestination(patientMain.getSeat());

    }
    void Update()
    {
    }
}
