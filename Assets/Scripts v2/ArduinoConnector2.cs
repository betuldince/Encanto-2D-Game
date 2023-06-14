using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
public class ArduinoConnector2 : MonoBehaviour
{
    // Start is called before the first frame update

    public bool useArduino;
    public string IOPort = "/dev/cu.HC05-SPPDev";
    public int baudeRate = 9600;
    public Vector2 inputValues = Vector2.zero;
    public int input;

    public float WheelRaduis;
    public SerialPort sp;

    private string recievedValue;
    private bool hasPassed;
    private float timeBtwPassings;

    public int firstMove = 0;
    public float rotation;
    public float rotation1;

    public float initialRotation;
    public bool turnedRight;
    public bool turnedLeft;

    private Queue<float> readValues = new Queue<float>();
    public float prevValue;
    public float pastTime = 0;
    public float gapTime = 2f;

    public int flag = 0;
    public BodySourceView3 bv2;
    private float rightHand;
    private float leftHand;
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
    public void setTimer()
    {
       timeBtwPassings = 100000;
    }
    public void setTimerZero()
    {
        timeBtwPassings = 0;
    }

    void SetDirection(string message)
    {
        string[] tokens = message.Split(",");
        //rotation = float.Parse(tokens[0]);

        input = int.Parse(tokens[0]);
        timeBtwPassings += Time.deltaTime;
        
        if (input < 12)
        {
            input = 1;
        }
        else
        {
            input = 0;
        }

        /*
        leftHand = bv2.targetPosition1.x;
        rightHand = bv2.targetPosition.x;
        if (leftHand - rightHand > 15)
        {
            turnedRight = true;
        }
        else
        {
            turnedRight = false;
        }

        if (rightHand - leftHand > 15)
        {
            turnedLeft = true;
        }
        else
        {
            turnedLeft = false;
        }*/

        if (bv2.turnRight)
        {
            turnedRight = true;
        }
        else
        {
            turnedRight = false;
        }
        if (bv2.turnLeft)
        {
            turnedLeft = true;
        }
        else
        {
            turnedLeft = false;
        }



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

        

        if (timeBtwPassings > 2f)
        {
            inputValues.y = 0f;


        }
        
        /*
        if (pastTime < gapTime)
        {
            pastTime += Time.deltaTime;
            readValues.Enqueue(rotation);
            return;
        }
        else
        {
            prevValue = readValues.Dequeue();
            pastTime = 0;
        }

        //readValues.Enqueue(rotation);
        readValues.Clear();

        */






        /*
        if (rotation > prevValue + 15 && !turnedLeft)
        {
            turnedRight = true;
             
        }
        else
        {
            turnedRight = false;
            
        }
        if (rotation < prevValue - 15 && !turnedRight )
        {
            turnedLeft = true;
             
        }
        else
        {
            turnedLeft = false;
            
        }*/

        /*
        if (rotation > initialRotation + 30)
        {
            turnedRight = true;
             
        }
        else
        {
            turnedRight = false;
        }
        

        if (rotation < initialRotation - 30)
        {
            turnedLeft = true;
        }
        else
        {
            turnedLeft = false;
        }*/





    }
}
