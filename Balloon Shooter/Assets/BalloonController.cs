using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BalloonController : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 startingPosition;
    public GameController gameController;
    public int scoreAmount;
    public GameObject pop;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();

        if (transform.position.y > startingPosition.y * -1)
        {
            Destroy(this.gameObject);
            gameController.SubtractHealth();
        }

        if (gameController.health == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void Move()
    {
        Vector2 moveDirection = new Vector2(0f, moveSpeed * Time.deltaTime);
        transform.Translate(moveDirection);
    }

    private void OnMouseDown()
    {
        Instantiate(pop, transform.position, Quaternion.identity);

        if (gameObject.name == "BalloonPink")
        {
            pop.GetComponent<ParticleSystem>().startColor = Color.magenta;
        }


        Destroy(gameObject);
        gameController.AddScore(scoreAmount);
    }
}
