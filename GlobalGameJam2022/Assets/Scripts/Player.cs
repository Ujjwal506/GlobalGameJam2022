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
            if(groundCheck)
                rigibody.velocity = new Vector3(0, speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            ChangeForm();
        }
    }
    void ChangeForm() {
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
            groundCheck = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
            groundCheck = false;
    }
}
