using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float PlayerSpeed;
    private Rigidbody2D rb;
    private Vector2 player_posi;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirY = Input.GetAxisRaw("Vertical");
        player_posi = new Vector2(0, dirY).normalized;


    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, player_posi.y*PlayerSpeed);

    }
}
