using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class CharacterControls
{
    public KeyCode moveForward = KeyCode.W;
    public KeyCode moveBackward = KeyCode.S;
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
}

public class myDerivedMono : MonoBehaviour
{
    public float XPos
    {
        get { return transform.position.x; }
        set{
            Vector3 myPos = transform.position;
            myPos.x = value;
            transform.position = myPos;
        }
    }
    
    public float YPos
    {
        get { return transform.position.y; }
        set
        {
            Vector3 myPos = transform.position;
            myPos.y = value;
            transform.position = myPos;
        }
    }
}

public class CharacterMovement : myDerivedMono
{
    public float moveSpeed = 5f;
    public CharacterControls controls = new CharacterControls();
    
    private float trueSpeed
    {
        get { return moveSpeed * Time.deltaTime; }
    }
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        XPos = 100f;
        
        if (Input.GetKey(controls.moveForward))
        {
            transform.Translate(transform.forward *  trueSpeed);
        }

        if (Input.GetKey(controls.moveBackward))
        {
            transform.Translate(transform.forward * -1 * trueSpeed);
        }

        if (Input.GetKey(controls.moveLeft))
        {
            transform.Translate(transform.right * -1 * trueSpeed);
        }

        if (Input.GetKey(controls.moveRight))
        {
            transform.Translate(transform.right * trueSpeed);
        }
	}
}