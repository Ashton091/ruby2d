using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyConttroller : MonoBehaviour
{ 
    Rigidbody2D rigidbody2d;
    float horizontal; 
    float vertical;

    public int maxHealth = 5;
    int currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

       
    }
    void FixedUpdate ()
    {
        Vector2 position = rigidbody2d.position; 
        position.x = position.x + 3f * horizontal * Time.deltaTime;
        position.y = position.y + 3f * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

}
