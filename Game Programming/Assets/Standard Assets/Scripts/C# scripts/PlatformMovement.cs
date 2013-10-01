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

    public float Gravity = 9,
                 JumpStrength = 20,
                 MoveSpeed = 30;

	
    private CharacterController controller;
 
    CollisionFlags prevFlags;
	void Start ()

    {
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
            }
            if (MoveRight.IsActive)
            {
                moveVec.x += MoveSpeed;
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
        
	}
}
