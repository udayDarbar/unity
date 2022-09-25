using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
     public GameObject player;
    Vector3 offset = new Vector3(0, 2, 0);
    Vector3 ofrotate = new Vector3(5,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset ;
        transform.rotation = player.transform.rotation  ;
    }
}
