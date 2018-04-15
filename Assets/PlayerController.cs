using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    private string[] textSequence;
    private int dialogIndex;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        textSequence = new string[] { "Hey! I need your help with something.", "I was going for a walk with my cat Bella and suddenly she wasn't with me", "Can you help me find her?" };
        dialogIndex = 0;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
	}
}
