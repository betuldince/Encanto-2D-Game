using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FollowPath : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform[] Points;
    public float moveSpeed;
    private int pointIndex;
    RectTransform rt;
    public ArduinoConnector2 ard;
     
    public bool flag=false;
    public bool flag1 = false;

    public AudioSource au;
    public VideoPlayer vd;

    public int value = 8;
    public Subtitles sb;
    public GameObject background;
    public Animator anim;

    int i = 0;
    public bool notRet = false;
    void Start()
    {

        transform.position = Points[pointIndex].transform.position;
        moveSpeed = 0;
       
    }
  
    // Update is called once per frame
    void Update()
    {

        
       /*  
        if ((int)ard.inputValues.y > 0)
        {
            moveSpeed = value;
        }*/


        if ((int)moveSpeed == 0 && i==0)
        {
            //sb.StopSubtitle();
           // Time.timeScale = 0;
            au.Pause();
            vd.Pause();
        }
        else if(i==0)
        {
           // Time.timeScale = 1;
            sb.StartSubtitle();
            au.Play();
            vd.Play();
            background.SetActive(false);
            i++;
            
        }
        if (pointIndex <= Points.Length - 1)
        {
            if ((int)ard.inputValues.y > 0)
            {
                moveSpeed = value;
            }
            transform.position = Vector2.MoveTowards(transform.position, Points[pointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == Points[pointIndex].transform.position)
            {
                pointIndex += 1;

                if (Points[pointIndex].transform.position.y - Points[pointIndex - 1].transform.position.y < 0 && pointIndex >= 1)
                {
                    //transform.Rotate(0f, 0f, -30f);
                    transform.rotation = Quaternion.Euler(0, 0, -30);
                    moveSpeed = 0;
                    Time.timeScale = 0;
                    flag = true;
                    au.Pause();
                    vd.Pause();
                }
                if (Points[pointIndex].transform.position.y - Points[pointIndex - 1].transform.position.y > 0 && pointIndex >= 1)
                {
                    //transform.Rotate(0f, 0f, +60f);
                    transform.rotation = Quaternion.Euler(0, 0, +30);
                    moveSpeed = 0;
                    Time.timeScale = 0;
                    flag1 = true;
                    au.Pause();
                    vd.Pause();
                    
                }
                if ((int)(Points[pointIndex].transform.position.y - Points[pointIndex - 1].transform.position.y) == 0 && pointIndex >= 1)
                {

                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    if ((int)ard.inputValues.y > 0)
                    {
                        moveSpeed = value;
                    }
                    
                    Time.timeScale = 1;
                    au.Play();
                    vd.Play();
                }

            }
        }

        

        if (flag && ard.turnedRight)
        {
            moveSpeed = 0;
            if ((int)ard.input == 1)
            {
                moveSpeed = value;
            }
            else
            {
                moveSpeed = 0;

            }

            flag = false;
            Time.timeScale = 1;
            au.Play();
            vd.Play();
        }

        if((int)ard.inputValues.y > 0)
        {
           
        }
        else
        {
            moveSpeed = 0;
             
        }
 

        if (flag1 && ard.turnedLeft)
        {
             if ((int)ard.input == 1 )
                    {
                        moveSpeed = value;
            }
            else
            {
                moveSpeed = 0;

            }
            flag1 = false;
            Time.timeScale = 1;
            au.Play();
            vd.Play();
        }





    }
}
