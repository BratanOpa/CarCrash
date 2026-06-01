using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public GameObject obj;
    public float timer;

    private float timer1;

    void Start()
    {
        
    }

    void Update()
    {
        if(timer1 + timer < Time.time)
        {
            timer1 = Time.time;
            GameObject car = Instantiate(obj);
            car.transform.position = transform.position;
            car.transform.rotation = transform.rotation;
        }
    }
}
