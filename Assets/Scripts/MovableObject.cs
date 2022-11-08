using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class MovableObject : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    public Rigidbody2D rigidBody2D;
    public float moveSpeed = 2.5f;

    private bool moving = false;
    private Vector3 target;
    private Vector3 prevPos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            Vector3 newPos = Vector3.MoveTowards(this.transform.localPosition, target, 0.05f);
            rigidBody2D.MovePosition(newPos);
            if (newPos == target)
            {
                moving = false;
            }
        }
    }


    #region Movement

    private void Move(Vector3 dirVector)
    {
        if (!moving)
        {
            float width = boxCollider2D.size.x;
            float height = boxCollider2D.size.y;
            dirVector.x *= width;
            dirVector.y *= height;
            prevPos = this.transform.localPosition;
            target = this.transform.localPosition + dirVector;
            moving = true;
        }
    }

    public void MoveUp()
    {
        Move(new Vector3(0, moveSpeed, 0));
    }

    public void MoveDown()
    {
        Move(new Vector3(0, -moveSpeed, 0));
    }

    public void MoveLeft()
    {
        Move(new Vector3(-moveSpeed, 0, 0));
    }

    public void MoveRight()
    {
        Move(new Vector3(moveSpeed, 0, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("boom!");
        moving = true;
        target = prevPos;
    }

    #endregion
}
