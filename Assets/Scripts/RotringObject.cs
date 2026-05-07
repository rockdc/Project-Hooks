using UnityEngine;
using UnityEngine.UIElements;

public class RotringObject : MonoBehaviour
{
    private Vector3 Pivotpoint;// the point were it will rotrte around the object
    private float angle;
    public float rotringSpeed = 1; // how fast the object rotrtes 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Pivotpoint, Vector3.up, angle);
        angle = Time.deltaTime * rotringSpeed;
        
    }
}
