using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float jmpForce = 100f;
    [SerializeField] private Rigidbody characterBody;
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0){
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }

        if(Input.GetAxis("Vertical") != 0){
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            jump();
        }
    }

    private void jump(){
        if(IsTouchingFloor()){
            characterBody.AddForce(Vector3.up * jmpForce);
            //characterBody.velocity = Vector3.up * 10f;
        }

    }

    private bool IsTouchingFloor(){
        RaycastHit hit;
        return Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1f);
    }
}
