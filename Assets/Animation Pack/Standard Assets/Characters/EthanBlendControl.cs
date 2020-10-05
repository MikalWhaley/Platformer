using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class EthanBlendControl : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    private float move = 1;
    public float moveAmplify = 1;
    public float amplify = 2;
    Display display;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        display = GameObject.Find("Display").GetComponent<Display>();
    }
    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        move = (Input.GetKey(KeyCode.LeftShift)) ? move * amplify : move; //TURBO!!!
        animator.SetFloat("Speed", Mathf.Abs(move));
        //turn Ethan Model with 
        float y = (move < 0) ? 270 : 90;
        Vector3 input = new Vector3(0, y, 0);
        transform.eulerAngles = input;
        // See if we are hitting turbo
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "QuestionBlock(Clone)")
        {
            Destroy(other.gameObject);
            display.updateCoin();
            display.updateScore();
        }

        if (other.gameObject.name == "Brick(Clone)")
        {
            Destroy(other.gameObject);
            display.updateScore();
        }

    }

    
    private void FixedUpdate()
    {

        rb.velocity = (Vector3.right * move * moveAmplify);
    }
}