using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject TamaPrefab;
    public int TamaDeadth;
    //public ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        TamaDeadth = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Enemy")
            || collision.gameObject.CompareTag("Tama") || collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            Destroy(TamaPrefab);
            //Explode();
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            TamaDeadth += 1;
            if (TamaDeadth == 2)
            {
                Destroy(TamaPrefab);
                //Explode();
            }
        }
    }

    //void Explode()
    //{
    //    var exp = GetComponent<ParticleSystem>();
    //    exp.Play();
    //}

}
