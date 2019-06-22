using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Installation : MonoBehaviour
{
    public float detonationTime;
    public float radius;
    public float pawer;
    public GameObject LandminePrefab;

    // Start is called before the first frame update
    void Start()
    {
        detonationTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Bomb"))
        {
            Detonation();
        }
    }

    void Detonation()
    {
        GameObject landmine = Instantiate(LandminePrefab, transform.position, Quaternion.identity);
        detonationTime += Time.deltaTime;

        if (detonationTime >= 5)
        {
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if(rb != null)
                {
                    rb.AddExplosionForce(pawer, explosionPos, radius, 3.0f);
                }
            }

            detonationTime = 0;
        }
    }
}
