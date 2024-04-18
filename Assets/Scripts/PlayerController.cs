using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScript : MonoBehaviour
{
    #region Editor Data
    [Header("Movement Attributes")]
    [SerializeField] float _walkSpeed = 3f;
    [SerializeField] float _sprintSpeed = 6f;
    [SerializeField] Rigidbody2D _rb;
    public Image StaminaBar;
    public float Stamina, MaxStamina;
    public float RunCost;
    public float StaminaRegen;
    private Coroutine recharge;

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
        if(Input.GetKey(KeyCode.LeftShift) && Stamina > 0)
        {
            _rb.AddForce(_moveDir * _sprintSpeed * Time.fixedDeltaTime);
            if(_moveDir != Vector2.zero)
            {
                Stamina -= RunCost * Time.fixedDeltaTime;
                if(Stamina < 0)
                {
                    Stamina = 0;
                }
                StaminaBar.fillAmount = Stamina / MaxStamina;

                if(recharge != null)
                {
                    StopCoroutine(recharge);
                }
                recharge = StartCoroutine(RechargeStamina());
            }
        }
        else
        {
            _rb.AddForce(_moveDir * _walkSpeed * Time.fixedDeltaTime);
        }
    }
    
    private IEnumerator RechargeStamina()
    {
        yield return new WaitForSeconds(1f);

        while(Stamina < MaxStamina)
        {
            Stamina += StaminaRegen * Time.fixedDeltaTime;
            StaminaBar.fillAmount = Stamina / MaxStamina;
            yield return new WaitForFixedUpdate();
        }
    }
}
