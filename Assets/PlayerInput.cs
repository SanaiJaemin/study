using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput instance;
    // ###############################################
    //             NAME : KimJaeMin                      
    //             MAIL : woals1566@gmail.com         
    // ###############################################

    
    

    [HideInInspector]
    public float Movex { get; set; }
    [HideInInspector]
    public float Movez { get; set; }
    [HideInInspector]
    public float MouseX { get; set; }
    [HideInInspector]
    public float MouseY { get; set; }

    private PlayerCamera _playerCamera;
    private PlayerMove _playermove;

    private void Awake()
    {
       
        //게임오즈젝트 비워주기
        _playerCamera = GetComponent<PlayerCamera>();
        _playermove = GetComponent<PlayerMove>();

    }

    // Update is called once per frame
    void Update()
    {

        RotateUpdate();
        MoveUpdate();
       
    }

    void RotateUpdate()
    {
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");
        _playerCamera.PlayerYRotate(MouseX, MouseY);
        _playerCamera.CameraUpDown(MouseX, MouseY);
    }
    void MoveUpdate()
    {
        Movex = Input.GetAxis("Horizontal");
        Movez = Input.GetAxis("Vertical");
        

    }
}
