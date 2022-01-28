using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector3 respawnPoint;
    public GameObject deathFX;
    public GameObject WinFX;
    private int score;


    void Start()
    {
 
        respawnPoint = transform.position;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Instantiate(deathFX, col.gameObject.transform.position, col.gameObject.transform.rotation);
            transform.position = respawnPoint;

        }


        if (col.tag == "Win")
        {
           Instantiate(WinFX, col.gameObject.transform.position, col.gameObject.transform.rotation);
            ScoreScript.score +=  1;
            Debug.Log("est ce que ça marche");
           transform.position = respawnPoint;
        }
 
    }

}



//faire fx quand le perso bouge, finir particle death,