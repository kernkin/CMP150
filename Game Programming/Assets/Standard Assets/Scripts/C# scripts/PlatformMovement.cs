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
public class PlatformMovement : MonoBehaviour 
{
    public Control MoveLeft,
                   MoveRight,
                   Jump;

    public float Gravity = 9,
                 JumpStrength = 20,
                 MoveSpeed = 30;

	CollisionFlags prevFlags;
    private class CharacterController
    {
     
    }
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
            if (MoveLeft.isActive)
            {
                move.Vecx -= MoveSpeed;
            }
            if (MoveLeft.isActive)
            {
                move.Vecx -= MoveSpeed;
            }
               if (MoveRight.isActive)
            {
                move.Vecx += MoveSpeed;
            }

            if(!prevFlags.Has(CollosionFlags.CollidedBelow))
            {
                moveVec.y -= Gravity;
            }

            CollisionFlags flags = controller.Move(moreVec * Time.deltatime);
        
	}
}
