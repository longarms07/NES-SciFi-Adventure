using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class MovableObject : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    public Rigidbody2D rigidBody2D;
    public Animator movableAnimator;
    public float moveSpeed = 1f;

    private Vector3 target;

    private string animBoolMoving = "moving";
    private string animTriggerFacingUp = "facingUp";
    private string animTriggerFacingLeft = "facingLeft";
    private string animTriggerFacingRight = "facingRight";
    private string animTriggerFacingDown = "facingDown";



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    #region Movement

    private void Move(Vector3 dirVector)
    {
        movableAnimator.SetBool(animBoolMoving, true);
        float width = boxCollider2D.size.x;
        float height = boxCollider2D.size.y;
        dirVector.x *= width;
        dirVector.y *= height;
        target = this.transform.localPosition + dirVector;
        Vector3 newPos = Vector3.MoveTowards(this.transform.localPosition, target, 0.05f);
        rigidBody2D.MovePosition(newPos);
    }

    public void MoveUp()
    {
        movableAnimator.SetTrigger(animTriggerFacingUp);
        Move(new Vector3(0, moveSpeed, 0));
    }

    public void MoveDown()
    {
        movableAnimator.SetTrigger(animTriggerFacingDown);
        Move(new Vector3(0, -moveSpeed, 0));
    }

    public void MoveLeft()
    {
        movableAnimator.SetTrigger(animTriggerFacingLeft);
        Move(new Vector3(-moveSpeed, 0, 0));
    }

    public void MoveRight()
    {
        movableAnimator.SetTrigger(animTriggerFacingRight);
        Move(new Vector3(moveSpeed, 0, 0));
    }

    public void StopMoving()
    {
        movableAnimator.SetBool(animBoolMoving, false);
    }

    #endregion
}
