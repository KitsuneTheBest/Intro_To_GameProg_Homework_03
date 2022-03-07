using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 3f;
    public float AngularSpeed = 360f;
    void Update()
    {
        // movement direction
        var movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += movement * Speed * Time.deltaTime;
        
        if (movement == Vector3.zero)
        {
            return;
        }
        
        // rotation relative to the movement direction
        var rotation = Quaternion.LookRotation(movement);
        rotation = Quaternion.RotateTowards(
            transform.rotation,
            rotation,
            AngularSpeed * Time.deltaTime);
        transform.rotation = rotation;
    }

}
