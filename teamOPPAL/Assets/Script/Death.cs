using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject TamaPrefab;
    public int TamaDeadth;

    // Start is called before the first frame update
    void Start()
    {
        TamaDeadth = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(TamaPrefab);
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            TamaDeadth += 1;
            if (TamaDeadth == 2)
            {
                Destroy(TamaPrefab);
            }
        }
    }



}
