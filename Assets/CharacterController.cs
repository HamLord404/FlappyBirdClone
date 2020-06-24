using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{

    double gravity = 1;
    float jumpStrength = 10;
    public Rigidbody2D rb2d;
    int score = 0;

    public GameObject scoreCount;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 jumpVector = new Vector2(0,jumpStrength);
            rb2d.AddForce(jumpVector,ForceMode2D.Impulse);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        
        if (collision.gameObject.tag == "Hazard")
        {
            Debug.Log("Dead");
            gameOver.SetActive(true);
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "PointZone")
        {
            Debug.Log("Point Earned");
            score++;
            scoreCount.GetComponent<Text>().text = score + "";
        }
    }
}
