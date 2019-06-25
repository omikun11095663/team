using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoutouMove : MonoBehaviour
{
    public float rotateSpeed = 0;
    public float seconds;
    public float rotationSmooth = 1;
    private Transform Player;
    //List<int> sp = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        //sp.Add((int)-0.5f);
        //sp.Add((int)0.5f);
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(Player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime
             * rotationSmooth);
    }
}
