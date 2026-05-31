using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public Vector3 moveDirection;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += moveDirection;
    }
}
