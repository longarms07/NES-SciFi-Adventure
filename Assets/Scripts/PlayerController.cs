using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovableObject))]
public class PlayerController : MonoBehaviour
{

    public MovableObject movable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) movable.MoveUp();
        else if (Input.GetKeyDown(KeyCode.A)) movable.MoveLeft();
        else if (Input.GetKeyDown(KeyCode.S)) movable.MoveDown();
        else if (Input.GetKeyDown(KeyCode.D)) movable.MoveRight();


    }


    


}
