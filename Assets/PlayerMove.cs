using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // ###############################################
    //             NAME : KimJaeMin                      
    //             MAIL : woals1566@gmail.com         
    // ###############################################
    [SerializeField]
    private Transform Cameraposition;
    
    private PlayerInput _playerInput;
    private Vector3 _moveVec;
    public float MoveSpeed = 5f;
    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        
    }
    // Update is called once per frame
    void Update()
    {
        _moveVec = new Vector3(_playerInput.Movex, 0, _playerInput.Movez);
        transform.position += transform.rotation * _moveVec;
    }

    
}


