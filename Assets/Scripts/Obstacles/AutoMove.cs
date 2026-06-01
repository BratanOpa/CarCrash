using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public Vector3 moveDirection;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.localPosition += transform.TransformDirection(moveDirection);
    }
}
