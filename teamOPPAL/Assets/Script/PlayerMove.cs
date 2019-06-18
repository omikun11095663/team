using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float x;
    public float z;
    public Vector3 direction;
    public float speed;
    private GameObject Houtou;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        
        direction.Normalize();

       
        //Houtou.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);

    }
}
