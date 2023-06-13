using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class FollowPath1 : MonoBehaviour
{
     

    // Start is called before the first frame update
    [SerializeField] Transform[] Points;
    public float moveSpeed;
    private int pointIndex;
    RectTransform rt;
    public ArduinoConnector2 ard;
     
    public bool flag=false;
    public bool flag1 = false;
    bool flag_start = false;

    public AudioSource au;
    public VideoPlayer vd;

    public int value = 8;
    public Subtitles sb;
    public GameObject background;
    public Animator anim;

    public GameObject TalkingBalloon;

     
    public GameObject EndScreen;

    int i = 0;
    public bool notRet = false;
    private bool startGame = false;
    void Start()
    {

        transform.position = Points[pointIndex].transform.position;
        moveSpeed = 0;
        vd.loopPointReached += CheckOver;

    }

    public void StartGame()
    {
        startGame = true;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  
    // Update is called once per frame
    void Update()
    {
        if (!startGame)
        {
            moveSpeed = 0;
            ard.inputValues.y = 0;
        }


        moveSpeed = ard.inputValues.y / 5.5f;


        if (moveSpeed > 60)
        {
            moveSpeed = 15f;
        }

        
        if ((int)moveSpeed == 0 && i==0 )
        {
            moveSpeed = 0;
            au.Pause();
            vd.Pause();
        }
        else if(i==0  )
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
            
            transform.position = Vector2.MoveTowards(transform.position, Points[pointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == Points[pointIndex].transform.position)
            {
                pointIndex += 1;

                if (Points[pointIndex].transform.position.y - Points[pointIndex - 1].transform.position.y < 0 && pointIndex >= 1)
                {
                    //transform.Rotate(0f, 0f, -30f);
                    transform.rotation = Quaternion.Euler(0, 0, -30);
                    TalkingBalloon.transform.localRotation= Quaternion.Euler(0, 0, 30);
                    moveSpeed = 0;
                    anim.SetBool("isRunning", false);
                    Time.timeScale = 0;
                    flag = true;
                    au.Pause();
                    vd.Pause();
                    Debug.Log("wtf");
                }
                if (Points[pointIndex].transform.position.y - Points[pointIndex - 1].transform.position.y > 0 && pointIndex >= 1)
                {
                    //transform.Rotate(0f, 0f, +60f);
                    transform.rotation = Quaternion.Euler(0, 0, +30);
                    TalkingBalloon.transform.localRotation = Quaternion.Euler(0, 0, -30);
                    moveSpeed = 0;
                    anim.SetBool("isRunning", false);
                    Time.timeScale = 0;
                    flag1 = true;
                    au.Pause();
                    vd.Pause();
                    
                }
                if ((int)(Points[pointIndex].transform.position.y - Points[pointIndex - 1].transform.position.y) == 0 && pointIndex >= 1)
                {
                   
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    TalkingBalloon.transform.rotation = Quaternion.Euler(0, 0, 0);
                   // au.Play();
                   // vd.Play();
                }

            }
        }

        

        if (flag && ard.turnedRight)
        {

            moveSpeed = 0;
            
            flag = false;
            Time.timeScale = 1;
            au.Play();
            vd.Play();
        }

        

        if (flag1 && ard.turnedLeft)
        {
            moveSpeed = 0;
            
            flag1 = false;
            Time.timeScale = 1;
            au.Play();
            vd.Play();
        }

       
        if (moveSpeed==0 )
        {
            anim.SetBool("isRunning",false);
             
       
            
             
        }else if(Time.timeScale !=0)
          
        {
            anim.SetBool("isRunning", true);
             
                
        }
         

    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        EndScreen.SetActive(true);
    }

}
