using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    // ###############################################
    //             NAME : KimJaeMin                      
    //             MAIL : woals1566@gmail.com         
    // ###############################################
    public Transform Robot;
    public Transform Robot2;
    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log($"{GameManager.instance.SecondRobotOn}");
        //if (GameManager.instance.SecondRobotOn == false)
        //{
        //    transform.position = new Vector3(Robot.position.x, Robot.position.y + 2.5f, Robot.position.z - 8.1f);
        //}
        //else
        //{
        //    transform.position = new Vector3(Robot2.position.x - 0.2f, Robot2.position.y + 2.5f, Robot2.position.z - 8.1f);
        //}


    }
}
