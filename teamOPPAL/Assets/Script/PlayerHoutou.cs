using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoutou : MonoBehaviour
{
    Plane plane = new Plane();//3D空間での2Dの表現
    float distance = 0;
    public GameObject Houtou;

    // Start is called before the first frame update
    void Start()
    {
        //Houtou.transform.LookAt(Houtou.transform.position);

        plane.SetNormalAndPosition(Vector3.back, transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        //カメラとマウスの位置をもとにRayを用意
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        //プレイヤーの高さにPlaneを更新して、カメラの情報をもとに
        //地面の判定をして距離を取得
        plane.SetNormalAndPosition(Vector3.up, transform.localPosition);

        //Vector3 targetPos =  Houtou.transform.position;
        //targetPos.x = Houtou.transform.position.x;
        //Houtou.transform.LookAt(targetPos);

        if (plane.Raycast(ray, out distance))
        {
            //距離をもとに交差を計算し、交点の方を向く
            var lookPoint = ray.GetPoint(distance);
            
            transform.LookAt(lookPoint);

           
        }
    }
}
