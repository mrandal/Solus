using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    #region Editor Data
    [Header("Movement Attributes")]
    [SerializeField] float _walkSpeed = 3f;
    [SerializeField] float _sprintSpeed = 6f;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] private Animator anim;
    [SerializeField] private float meleeSpeed;
    float timeUntilMelee;
    public Image StaminaBar;
    public Animator animator;
    public float Stamina, MaxStamina;
    public float RunCost;
    public float swordCost;
    public float StaminaRegen;
    public AudioSource walkSound;
    private Coroutine recharge;
    public GameObject sword;

    #endregion

    #region Internal Data
    private Vector2 _moveDir = Vector2.zero;
    #endregion

    void Start()
    {

    }
    #region Tick
    private void Update()
    {
        GatherInput();
        if(_moveDir != Vector2.zero && Time.timeScale == 1)
        {
            if(!walkSound.isPlaying)
            {
                walkSound.Play();
            }
        }
        else
        {
            walkSound.Pause();
        }
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
        if(sword.activeSelf && timeUntilMelee <= 0f && Input.GetMouseButtonDown(0) && Stamina-swordCost >= 0)
        {
            anim.SetTrigger("Attack");
            timeUntilMelee = meleeSpeed;
            Stamina -= swordCost;
            StaminaBar.fillAmount = Stamina / MaxStamina;
            if(recharge != null)
            {
                StopCoroutine(recharge);
            }
            recharge = StartCoroutine(RechargeStamina());
        }
        else
        {
            timeUntilMelee -= Time.deltaTime;
        }
        
        
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

        
        //animate
        // Directions: 0 = no movement, 1 = left, 2 = up, 3 = right, 4 = down
        if(Mathf.Abs(_moveDir.x) > 0 && Mathf.Abs(_moveDir.x) >= Mathf.Abs(_moveDir.y))
        {
            if(_moveDir.x > 0)
            {
                animator.SetInteger("walkDirection", 3);
            }
            else
            {
                animator.SetInteger("walkDirection",1);
            }
        }
        else if(Mathf.Abs(_moveDir.y)> 0)
        {
            if(_moveDir.y > 0)
            {
                animator.SetInteger("walkDirection", 2);
            }
            else
            {
                animator.SetInteger("walkDirection", 4);
            }
        }
        else
        {
            animator.SetInteger("walkDirection",0);
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
