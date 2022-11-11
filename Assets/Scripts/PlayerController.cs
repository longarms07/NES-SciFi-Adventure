using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovableObject))]
public class PlayerController : MonoBehaviour
{

    public MovableObject movable;
    public Sword sword;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) movable.MoveUp();
        else if (Input.GetKey(KeyCode.A)) movable.MoveLeft();
        else if (Input.GetKey(KeyCode.S)) movable.MoveDown();
        else if (Input.GetKey(KeyCode.D)) movable.MoveRight();
        else if (Input.GetKey(KeyCode.Space)) sword.Stab();

    }


    


}
