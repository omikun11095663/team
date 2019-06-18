using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float shotTime;
    public GameObject TamaPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Shot"))
        {
            Shot();
            
        }

    }

    void Shot()
    {
        GameObject Tama = Instantiate(TamaPrefab, transform.position, Quaternion.identity);
        Rigidbody tamarigidbody = Tama.GetComponent<Rigidbody>();
        tamarigidbody.AddForce(transform.forward * shotTime);
    }
}
