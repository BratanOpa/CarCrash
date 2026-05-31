using UnityEngine;

public class ViewTrigger : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector3 vp = cam.WorldToViewportPoint(transform.position);
        bool visible =
            vp.z > 0 &&
            vp.x >= 0 && vp.x <= 1 &&
            vp.y >= 0 && vp.y <= 1;

        if (visible)
        {
            //Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print("TriggerEnter");
        if(other.tag == "Player")
        {
            MouseRotation mr = other.GetComponent<MouseRotation>();
            mr.SetFocusObject(transform);
            print("SetFocus");
        }
    }

    /*void OnBecameVisible()
    {
        print("Visible");
    }*/
}
