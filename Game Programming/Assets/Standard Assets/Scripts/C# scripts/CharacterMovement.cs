

using UnityEngine;
using System.Collections;
using System;


[Serializable]
public class CharacterControls
{
    public Control MoveForward; 
    public Control MoveBack;
    public Control MoveLeft;
    public Control MoveRight;
}
public class MyDerivedMono : MonoBehaviour
{
    public float XPos
    {
        get { return transform.position.x; }
        set
        {
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
public class CharacterMovement : MyDerivedMono
{


    public float MoveSpeed = 5f;
    public CharacterControls controls = new CharacterControls();


    private float trueSpeed
    {
        get { return MoveSpeed * Time.deltaTime; }
    }
	// Use this for initialization
	void Start () 
    {


	}


	// Update is called once per frame
	void Update () 
    {
        //XPos = 100f;


        if (controls.MoveForward.IsActive)
        {
            transform.Translate(transform.forward * trueSpeed);
        }
        if (controls.MoveBack.IsActive)
        {
            transform.Translate(transform.forward *-1 * trueSpeed);
        }
        if (controls.MoveLeft.IsActive)
        {
            transform.Translate(transform.right * -1 * trueSpeed);
        }
        if (controls.MoveRight.IsActive)
        {
            transform.Translate(transform.right * trueSpeed);
        }
	}
}

 