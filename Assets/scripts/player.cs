using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    Rigidbody2D rbody;
    public float speed;
    public GameObject restartButton;
    public float derece;
    private bool isDead=false;
    private float score = 0f;
    public Text scoreText;
    public GameObject tabTOStart;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0f;
        Time.timeScale = 0f;
        isDead = false;
    }

    void Update()
    {
        if (!isDead)
        {
            if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
            {
                rbody.velocity = Vector2.up * speed;
                rbody.gravityScale = 1f;
                Time.timeScale = 1f;
                tabTOStart.SetActive(false);            }
            transform.Rotate(0, 0, 6 * derece * Time.deltaTime);

            scoreText.text = score.ToString();
        }
    

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="engel") {
            Time.timeScale = 0;
            restartButton.SetActive(true);
            isDead = true;

        }
     
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "scoreUp")
        {
            score++;
        }
    }
}
