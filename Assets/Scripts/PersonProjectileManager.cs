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
                MinerRigidbody2d = spawnedMiner.GetComponent<Rigidbody2D>(); // Geting the rigbody of the miner that it is shooting 
                Vector3 fireDirection = cannonObject.transform.position; // Spawn a miner at the barrle of the Cannon
                MinerRigidbody2d.linearVelocity = fireDirection * minerMoveSpeed; //pusheds the miner with a linearVelocity at a force of the direction and speed the miner gose 
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
