using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    // ###############################################
    //             NAME : KimJaeMin                      
    //             MAIL : woals1566@gmail.com         
    // ###############################################

    [SerializeField]
    private GameObject FirstRobot;
    [SerializeField]
    private GameObject SecondRobot;
    //public GameObject CameraPlace;

    public bool SecondRobotOn { get; private set; }



    private void Awake()
    {
        instance = this;
        //CameraPlace.transform.position = new Vector3(6, 12.6f, -26.4f);
        FirstRobot.GetComponent<PlayerInput>().enabled = false;
        SecondRobot.GetComponent<PlayerInput>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1)) // 1������ ��ǲ������Ʈ�� ù��°�κ� �Ҵ�
        {
            SecondRobotOn = false ;
            
            FirstRobot.GetComponent<PlayerInput>().enabled = true;
            SecondRobot.GetComponent<PlayerInput>().enabled = false;
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // 2������ ��ǲ������Ʈ�� ù��°�κ� �Ҵ�
        {
            SecondRobotOn =true ;
            FirstRobot.GetComponent<PlayerInput>().enabled = false;
            SecondRobot.GetComponent<PlayerInput>().enabled = true;
            
        }
        
    }
}
