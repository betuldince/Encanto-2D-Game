using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
public class ArduinoConnector : MonoBehaviour
{
    // Start is called before the first frame update

    public bool useArduino;
    public string IOPort = "/dev/cu.HC05-SPPDev";
    public int baudeRate = 9600;
    public Vector2 inputValues = Vector2.zero;

    public float WheelRaduis;
    public SerialPort sp;

    private string recievedValue;
    private bool hasPassed;
    private float timeBtwPassings;

    public int firstMove = 0;
    public float rotation;

    public float jump;
    public float slide;

    private bool isJump = false; 
    private bool isSlide = false;

    private int i = 0;
    private int j = 0;

    public Rigidbody2D rb;
    
    public Animator anim;

    bool isMoved=false;
     
    void Start()
    {
        if (useArduino) ActivateSP();
        
        
    }
    void ActivateSP()
    {
        sp = new SerialPort(IOPort, baudeRate, Parity.None, 8, StopBits.One);

        sp.Open();
        sp.ReadTimeout = 35;
    }
    // Update is called once per frame
    void Update()
    {
        if (useArduino && sp.IsOpen)
        {
            try
            {
                recievedValue = sp.ReadLine(); //reads the serial input
                //Debug.Log(recievedValue);
                SetDirection(recievedValue); //translates the string into a Vector
            }
            catch (System.Exception)
            {

            }
        }
      
       
    }
    

    void SetDirection(string message)
    {
        string[] tokens = message.Split(",");
        rotation = float.Parse(tokens[0]);

        int input = int.Parse(tokens[1]);
        timeBtwPassings += Time.deltaTime;
      
         

        if (input == 1 && hasPassed == false)
        {
            hasPassed = true;
            firstMove++;
            inputValues.y = WheelRaduis * 2 * Mathf.PI / timeBtwPassings;
            timeBtwPassings = 0f;
          

        }
        else if (input == 0)
        {
            hasPassed = false;
            
        }

        if (inputValues.y > 130)
        {
            inputValues.y = 0;
             
        }

        if (timeBtwPassings>4f)
        {
            inputValues.y = 0f;
            

        }
   
        /*
        if (rb2.velocity.magnitude>0.1)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        */

        if (rotation > jump )
        {
            
            i = 1;

             
        }
        else
        {
            i = 0;
             
        }



        if(i==1 && isJump == false)
        {
           
            i = 0;
            rb.AddForce(Vector2.up * 4f, ForceMode2D.Impulse);
            isJump = true;
        }else if (i == 0)
        {
            isJump = false;
        }

        if (rotation < slide)
        {

            j = 1;


        }
        else
        {
            j = 0;

        }



        if (j == 1 && isSlide == false)
        {

            j = 0;
            anim.SetBool("isJumped", true);
            isSlide = true;
        }
        else if (j == 0)
        {
            isSlide = false;
            anim.SetBool("isJumped", false);
        }





    }
}
