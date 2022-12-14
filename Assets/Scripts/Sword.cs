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

    public float stabDuration = 1f;

    private bool stabbing;
    public float stabTimeElapsed;

    public Vector3 upLocalPosition = new Vector3(0.0f, 0.1f, 0.0f);
    public Vector3 downLocalPosition = new Vector3(0.0f, -0.1f, 0.0f);
    public Vector3 leftLocalPosition = new Vector3(-0.1f, 0.0f, 0.0f);
    public Vector3 rightLocalPosition = new Vector3(0.1f, 0.0f, 0.0f);

    public Quaternion upLocalRotation = new Quaternion(0.0f, 0.0f, 0.7f, 0.7f);
    public Quaternion downLocalRotation = new Quaternion(0.0f, 0.0f, -0.7f, 0.7f);
    public Quaternion leftLocalRotation = new Quaternion(0.0f, 0.0f, 1.0f, 0.0f);
    public Quaternion rightLocalRotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);



    // Start is called before the first frame update
    void Start()
    {
        EnableComponents(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (stabbing)
        {
            stabTimeElapsed += Time.deltaTime;
            if (stabTimeElapsed >= stabDuration) Sheath();
        }

        Debug.Log(this.transform.localPosition);
    }

    public void Stab()
    {
        if (!stabbing)
        {
            EnableComponents(true);
            stabbing = true;
        }

    }

    public void Sheath()
    {
        if (stabbing)
        {
            stabbing = false;
            EnableComponents(false);
            stabTimeElapsed = 0f;
        }
    }

    public void RotateSword()
    {
        // Stubbed
    }

    public void EnableComponents(bool enable)
    {
        this.spriteRenderer.enabled = enable;
        this.boxCollider2D.enabled = enable;
    }

}
