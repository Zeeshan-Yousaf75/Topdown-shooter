using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollusion : MonoBehaviour
{
    public static int score = 0;
    public static int stars = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Animal")
        {
             score++;
            if ( score % 3 == 0)
            {
                stars++;

            }
            //Debug.Log("Collision Dected");
            collision.gameObject.SetActive(false);
            this.gameObject.SetActive(false);

        }
    }
}
