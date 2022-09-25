using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    float horizontalInput;
    float vartikalInput;
    float mousinputs ;
   public float speed  ;
   public float Rotate =50 ;

   private Rigidbody rd ;
   public float graveetymobifir ;
   public float jumpforse ;
   public bool isOnGround = true ;
    // Start is called before the first frame update
    void Start()
    {       
        rd=GetComponent<Rigidbody>();
        Physics.gravity *= graveetymobifir ;
        
    }

    // Update is called once per frame
    void Update()
    {
        // A/D(rigt and left movment)
        horizontalInput= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime* speed * horizontalInput);
        // W/S(forwared and back wordds) movment
        vartikalInput = Input.GetAxis("Vertical");
          transform.Translate(Vector3.forward * Time.deltaTime* speed * vartikalInput);
        // rotatason from mouse
        mousinputs = Input.GetAxis("Mouse X");
          transform.Rotate(Vector3.up *Time.deltaTime*Rotate*mousinputs);
          //jump & for not lating jump in air 
          if(Input.GetKeyDown(KeyCode.Space)&& isOnGround)
          {
               rd.AddForce(Vector3.up * jumpforse, ForceMode.Impulse);
               isOnGround =false ;
          }
    }
    // for detacting collision & for not lating jump in air
           private void OnCollisionEnter(Collision collision)
     {
        
        if (collision.gameObject.CompareTag("ground"))
        {
              isOnGround = true ;
              
        }
     }
}
