using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PersonProjectileManager : MonoBehaviour
{
    string typeOfMiner;
    float minerMoveSpeed = 5f;
    Vector3 startPosOfMiner;
    public GameObject cannonObject;
    public List<Sprite> minerSprites;

    //Nomlre miner stats 
    

    private void Start()
    {
        //Seting the new vector3 to the cannonObject
        cannonObject.transform.position = startPosOfMiner;
    }


    //Checks if the prokectile Has made Contact with Other Object // 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }


}
