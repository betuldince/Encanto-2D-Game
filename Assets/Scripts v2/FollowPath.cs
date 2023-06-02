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
    void Start()
    {

        transform.position = Points[pointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
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
                    moveSpeed = 18;
                    Time.timeScale = 1;
                    au.Play();
                    vd.Play();
                }

            }
        }
        if (flag && ard.turnedRight)
        {
            moveSpeed = 18;
            flag = false;
            Time.timeScale = 1;
            au.Play();
            vd.Play();
        }
        if (flag1 && ard.turnedLeft)
        {
            moveSpeed = 18;
            flag1 = false;
            Time.timeScale = 1;
            au.Play();
            vd.Play();
        }





    }
}
