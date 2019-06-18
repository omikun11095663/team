using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float shotTime;
    public GameObject TamaPrefab;
    public float seconds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;

        if (seconds >= 2)
        {
            Shot();
            seconds = 0;
        }

    }

    void Shot()
    {
        GameObject Tama = Instantiate(TamaPrefab, transform.position, Quaternion.identity);
        Rigidbody tamarigidbody = Tama.GetComponent<Rigidbody>();
        tamarigidbody.AddForce(transform.forward * shotTime);
    }
}
