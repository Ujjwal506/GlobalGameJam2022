using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float lightSpeed = 5, darkSpeed = 3;
    float speed;
    Rigidbody2D rigibody;
    SpriteRenderer spriteRenderer;
    bool changeForm = true;
    bool groundCheck = false;
    bool lookingLeft;
    void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        ChangeForm();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(transform.right * -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            groundCheck = false;
            if (groundCheck) {
                if (!changeForm)
                    rigibody.velocity = new Vector3(0, speed * 2, 0);
                else { 
                    if(lookingLeft)
                        rigibody.velocity = new Vector3(-speed * 2, speed + 1, 0);
                    else
                        rigibody.velocity = new Vector3(speed * 2, speed + 1, 0);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            ChangeForm();
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            lookingLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            lookingLeft = false;
        }
    }
    void ChangeForm() {
        groundCheck = true;
        changeForm = !changeForm;
        if (changeForm) { 
            spriteRenderer.color = Color.black;
            speed = darkSpeed;
        }
        else { 
            spriteRenderer.color = Color.white;
            speed = lightSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
        {
            groundCheck = true; rigibody.velocity = Vector2.zero;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
            groundCheck = false;
    }
}
