using UnityEngine;

public class ViewTrigger : MonoBehaviour
{
    public float offset; // AngleDeleteOffset

    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector3 vp = cam.WorldToViewportPoint(transform.position);
        bool visible =
            vp.z > -offset &&
            vp.x >= -offset && vp.x <= 1 +offset &&
            vp.y >= -offset && vp.y <= 1 +offset;

        if (visible)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            MouseRotation mr = other.GetComponent<MouseRotation>();
            mr.SetFocusObject(transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            MouseRotation mr = other.GetComponent<MouseRotation>();
            mr.SetFocusObject(null);
        }
    }

    /*void OnBecameVisible()
    {
        print("Visible");
    }*/
}
