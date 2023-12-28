using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject[] projectilePrefab;

    public int scoreText = 0;
    public  int starsText = 0;

    public TextMeshProUGUI uiScoreText;
    public TextMeshProUGUI uiStarsText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText = ObjectCollusion.score;
        uiScoreText.text = scoreText.ToString();

        starsText = ObjectCollusion.stars;
        uiStarsText.text = starsText.ToString();
        
        int randomValue = Random.Range(0,4);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange , transform.position.y,transform.position.z);

        }
        
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player 
            Instantiate(projectilePrefab[randomValue], transform.position, projectilePrefab[randomValue].transform.rotation);
        }
        
    }
}
