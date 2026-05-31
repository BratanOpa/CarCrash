using UnityEngine;

public class TimeDelete : MonoBehaviour
{
    public float time;

    void Start()
    {
        Invoke("DeleteMe", time);
    }

    void DeleteMe()
    {
        Destroy(gameObject);
    }

}
