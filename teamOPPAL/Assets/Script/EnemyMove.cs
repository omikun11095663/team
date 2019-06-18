using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MoveSpeed;
    public float angle;
    public Vector3 GoalPos;
    //Random rnd = new Random();
    List<Vector3> GoalPosList = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        GoalPos = new Vector3(Random.Range(95, -95), 0, Random.Range(48, - 48));

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        
    }
}
