using UnityEngine;
using System.Collections;
using System;

public static class Extensions
{
    public static bool Has<T>(this Enum type, T value)
    {
        try
        {
            return (((int)(object)type & (int)(object)value) == (int)(object)value);
        }
        catch
        {
            return false;
        }
    }
}
[RequireComponent(typeof(CharacterController))]
public class PlatformMovement : MyDerivedMono
{
    public Control MoveLeft,
                   MoveRight,
                   Jump;
                   

    public float Gravity = 20,
                 JumpStrength = 50,
                 MoveSpeed = 30;

    public GameObject drawObject;
	
    private CharacterController controller;

    private float zpos;
    CollisionFlags prevFlags;
	void Start ()

    {
        this.zpos = transform.position.z;
    controller = GetComponent<CharacterController>();
    if(controller == null)
        {
            Debug.LogError("No character controller found " + name);
	    }
	}
	// Update is called once per frame
	void Update () 
    {
            Vector3 moveVec = Vector3.zero;

            if (MoveLeft.IsActive)
            {
                moveVec.x -= MoveSpeed;
                drawObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (MoveRight.IsActive)
            {
                moveVec.x += MoveSpeed;
                drawObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (Jump.IsActive)
            {
                moveVec.y += MoveSpeed;
            }

            if(!prevFlags.Has(CollisionFlags.CollidedBelow))
            {
                moveVec.y -= Gravity;
            }

            CollisionFlags flags = controller.Move(moveVec * Time.deltaTime);

            if (Jump.IsActive)
            {
                audio.Play();
            }
            var vec = transform.position;
            vec.z = zpos;
            transform.position = vec;
	}
}
