using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSquare : MonoBehaviour
{
    // Start is called before the first frame update
    private ArduinoConnector ard;
   

    private float moveChar;
    private Rigidbody2D rb;
    private Vector2 direction;
    public GameObject exclamationMark;

    float counter =  0;
    float waitSec = 2;
    void Start()
    {
        GameObject ardManager = GameObject.Find("ArduinoManager");
        ard = ardManager.GetComponent<ArduinoConnector>();

        rb = GetComponent<Rigidbody2D>();
       // exclamationMark = GameObject.Find("exlamation");
      //  exclamationMark.SetActive(false);
         

    }

    // Update is called once per frame
    void Update()
    {
        moveChar = ard.inputValues.y;
            if(moveChar<130)
            transform.position = new Vector2(transform.position.x - (((moveChar)) * Time.deltaTime) / 50f, transform.position.y);

        
        
        if (exclamationMark.activeSelf)
        {
            Debug.Log("HERE");
            if (counter < waitSec)
            {
                counter += Time.deltaTime;
             
                return;

            }
            else if(counter>waitSec-0.1)
            {
                
                exclamationMark.SetActive(false);
            }
           // exclamationMark.SetActive(false);

        }
        counter = 0;
    }
     

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            direction = c.GetContact(0).normal;
            
           // Debug.Log(direction.x);
             
        }
        if(direction.x >0.9 )
        {
            exclamationMark.SetActive(true);
            rb.isKinematic = true;
            gameObject.SetActive(false);
        }

    }
}
