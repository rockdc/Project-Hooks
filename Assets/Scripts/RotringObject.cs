using UnityEngine;
using UnityEngine.UIElements;

public class RotringObject : MonoBehaviour
{
    private Vector3 Pivotpoint;// the point were it will rotrte around the object
    private float angle;
    public float rotringSpeed = 1f; // how fast the object rotrtes 
    private Vector3 rotringZ = new Vector3 (0, 0, -1); // sets z to -1 to rotrte ClockWise


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Pivotpoint, rotringZ, angle);// Takes the center point of the object and rotring on the z assces 
        angle = Time.deltaTime * rotringSpeed;// sets angle to roate at the speed of frames in game
        
    }
}
