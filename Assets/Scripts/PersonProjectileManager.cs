using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PersonProjectileManager : MonoBehaviour
{
    string typeOfMiner;
    public float minerMoveSpeed = 0.7f; // place holder speed 
    Vector3 startPosOfMiner;
    float direction;

    public GameObject cannonObject;
    public List<GameObject> minerObject;

    public Rigidbody2D MinerRigidbody2d;
    private GameObject spawnedMiner;

    //Nomlre miner stats 


    private void Start()
    {
        //Seting the new vector3 to the cannonObject
       // cannonObject.transform.position = startPosOfMiner;
    }

    private void FixedUpdate()
    {
        
        if (GameManager.instance.ConnonManager.CanShoot == true)
        {
            if (spawnedMiner == null) // checks if there is a miner spwand 
            {
                spawnedMiner = Object.Instantiate(minerObject[1] ,
                cannonObject.transform.position , Quaternion.identity); // spawn miner were the cannon is faceing 
                Debug.Log("spawning miner");

                // Give miner a direction
                MinerRigidbody2d = spawnedMiner.GetComponent<Rigidbody2D>();
                Vector3 fireDirection = GameManager.instance.ConnonManager.cannonObject.transform.position;
                MinerRigidbody2d.linearVelocity = fireDirection * minerMoveSpeed;
            }
            else
            {
                Debug.Log("There is all ready a miner Spawn");
            }
        }
        
    }

    


    //Checks if the prokectile Has made Contact with Other Object // 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }


}
