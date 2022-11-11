using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class MovableObject : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    public Rigidbody2D rigidBody2D;
    public float moveSpeed = 1f;

    private Vector3 target;


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


    #endregion
}
