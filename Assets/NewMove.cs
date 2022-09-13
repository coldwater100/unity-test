using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove : MonoBehaviour
{
  
    float velX;
    float velZ;
    //....

    CharacterController controller;

    Vector3 move;

    const float speed=1.1f;

    // Start is called before the first frame update
    void Awake()
    {
    
        controller=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        velX=Input.GetAxis("Horizontal");
        velZ=Input.GetAxis("Vertical");
        move=new Vector3(velX,0,velZ);
    }

    void FixedUpdate() {
 //       transform.Translate(move*speed,Space.World);
 //       rbody.AddForce(move*speed,ForceMode.Impulse);
       // rbody.MovePosition(rbody.position+ move*speed);
    //    rbody.MoveRotation(Quaternion.Slerp(rbody.rotation,rbody.rotation,1.0f));
        
        controller.SimpleMove(move*speed);
    }
}
