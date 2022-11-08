using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{

    public BoxCollider2D boxCollider2D;

    private bool moving = false;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            Vector3 newPos = Vector3.MoveTowards(this.transform.localPosition, target, 0.01f);
            this.transform.localPosition = newPos;
            if (newPos == target) moving = false;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.W)) MoveUp();
            else if (Input.GetKeyDown(KeyCode.A)) MoveLeft();
            else if (Input.GetKeyDown(KeyCode.S)) MoveDown();
            else if (Input.GetKeyDown(KeyCode.D)) MoveRight();
        }


    }


    #region Movement

    private void Move(Vector3 dirVector)
    {
        float width = boxCollider2D.size.x;
        float height = boxCollider2D.size.y;
        dirVector.x *= width;
        dirVector.y *= height;
        target = this.transform.localPosition + dirVector;
        moving = true;
    }

    public void MoveUp()
    {
        Move(new Vector3(0, 2.5f, 0));
    }

    public void MoveDown()
    {
        Move(new Vector3(0, -2.5f, 0));
    }

    public void MoveLeft()
    {
        Move(new Vector3(-2.5f, 0, 0));
    }

    public void MoveRight()
    {
        Move(new Vector3(2.5f, 0, 0));
    }

    #endregion


}
