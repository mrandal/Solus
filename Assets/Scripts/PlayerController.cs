using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    #region Editor Data
    [Header("Movement Attributes")]
    [SerializeField] float _walkSpeed = 3f;
    [SerializeField] float _sprintSpeed = 6f;
    [SerializeField] Rigidbody2D _rb;
    #endregion

    #region Internal Data
    private Vector2 _moveDir = Vector2.zero;
    #endregion

    #region Tick
    private void Update()
    {
        GatherInput();
    }

    private void FixedUpdate()
    {
        MovementUpdate();
    }
    #endregion

    #region Input Logic
    private void GatherInput()
    {
        _moveDir.x = Input.GetAxisRaw("Horizontal");
        _moveDir.y = Input.GetAxisRaw("Vertical");
    }
    #endregion

    private void MovementUpdate()
    {
        _moveDir.Normalize();
        if(Input.GetKey(KeyCode.LeftShift))
        {
            _rb.AddForce(_moveDir * _sprintSpeed * Time.fixedDeltaTime);
        }
        else
        {
            _rb.AddForce(_moveDir * _walkSpeed * Time.fixedDeltaTime);
        }
        
    }
}
