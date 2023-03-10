using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlap : MonoBehaviour
{

    public Rigidbody2D bird;
    [Range(3f,12f)] [SerializeField] private float flap = 5f;
    public bool isAlive = true;
    public Logic logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
            bird.velocity = Vector2.up * flap;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}
