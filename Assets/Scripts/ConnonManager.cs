using UnityEngine;


public class ConnonManager : MonoBehaviour
{
    [Header("Cannon Settitings")]
    public float cannonRange = 10f;
    public float cannonWidth = 0.3f;
    public bool CanShoot = true;

    //What the cannon can Shoot
    public LayerMask hitMask;


    //LineRender Settitings 
    int linereaderPositionCount = 2;

    public LineRenderer lineRenderer;
    public SpriteRenderer cannonSprite;
    public GameObject cannonObject;

    private void Start()
    {
        lineRenderer.positionCount = linereaderPositionCount;
        //set the witdth of the Connon line of sight
        lineRenderer.startWidth = cannonWidth;
        //Reset the cannon to false at the start of the game
        CanShoot = false;
        // Makes sure it's visible and on top
        lineRenderer.sortingOrder = 10;
    }

    // Update is called once per frame
    void Update()
    {

        UpdateLine();
        
    }

    void UpdateLine()
    {
        // Checking if the connon is shooting if not exit;
        if (!lineRenderer.enabled)
        {
            return; 
        }
        else
        {
            //Start at the connon position
            Vector3 startPos = cannonObject.transform.position;

            //The direction based on the rotation 
            Vector3 dir = cannonObject.transform.up;

            //The raycast2D
            RaycastHit2D hit = Physics2D.Raycast(startPos, dir, cannonRange, hitMask);

            //Ends positions 
            Vector3 endPos = hit.collider != null
                ? (Vector3)hit.point
                : startPos + (Vector3)dir * cannonRange;
          
            
            //Draw the line 
            lineRenderer.SetPosition(0, startPos);
            lineRenderer.SetPosition(1, endPos);
           
        }
    }

    //When the player shoots the cannon
    public void OnCannonShoot()
    {
        CanShoot = true;
        Debug.Log("Connon is Shoot");
    }
}
