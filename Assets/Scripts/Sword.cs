using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Sword : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    public Rigidbody2D rigidBody2D;
    public SpriteRenderer spriteRenderer;
    public Animator swordAnimator;

    public float stabDuration = 1f;

    private bool stabbing;
    public float stabTimeElapsed;

    private string animSwordTrigger = "UseSword";



    // Start is called before the first frame update
    void Start()
    {
        EnableComponents(false);
    }

    

    public void Stab()
    {
        swordAnimator.SetTrigger(animSwordTrigger);

    }

  

    public void EnableComponents(bool enable)
    {
        this.gameObject.SetActive(enable);
    }

}
