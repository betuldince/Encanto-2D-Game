using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject player;
    public FollowPath fp;
    private float camSpeed;
    void Start()
    {

       // camSpeed = fp.moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        camSpeed = fp.moveSpeed;
        Vector3 v = new Vector3(player.transform.position.x, player.transform.position.y,-10f);
       // Vector3 v = new Vector3(player.transform.position.x,);
        transform.position = Vector3.Lerp(transform.position, v,Time.deltaTime*camSpeed);

    }
}
