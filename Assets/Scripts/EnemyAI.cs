using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    #region Editor Data
    [Header("Movement Attributes")]
    [SerializeField] float _walkSpeed = 3f;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Rigidbody2D damienRB;
    public AudioSource walkSound;
    public float maxSoundDist;
    Animator animator;
    #endregion

    #region Internal Data
    private Vector2 _moveDir = Vector2.zero;
    private Vector2 zeroPoint = Vector2.zero;
    #endregion

    void Start()
    {
        animator = GetComponent<Animator>();
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
        
        _moveDir = damienRB.GetRelativePoint(zeroPoint)-_rb.GetRelativePoint(zeroPoint);
        if(_moveDir.magnitude > maxSoundDist)
        {
            walkSound.volume = 0;
        }
        else
        {
            walkSound.volume = 1 - (_moveDir.magnitude / maxSoundDist);
        }
    }
    #endregion

    private void MovementUpdate()
    {
        _moveDir.Normalize();
        _rb.AddForce(_moveDir * _walkSpeed * Time.fixedDeltaTime);

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
}
