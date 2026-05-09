using UnityEngine;


public class ConnonManager : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public SpriteRenderer cannonSprite;
    public GameObject cannonObject;

    //Cannon Settitings
    public float cannonRange = 1f;
    public float cannonWidth = 0.3f;

    //LineRender Settitings 
    const int linereaderPositionCount = 2;

    private void Start()
    {
       lineRenderer.positionCount = linereaderPositionCount;
        //set the witdth of the Connon line of sight
        lineRenderer.startWidth = cannonWidth;

        // Make sure it's visible
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
            Vector2 dir = cannonObject.transform.right;

            //The raycast2D
            RaycastHit2D hit = Physics2D.Raycast(startPos, dir, cannonRange);

            //Ends positions 
            Vector3 endPos = hit.collider != null
                ?(Vector3)hit.point
                :startPos + (Vector3)dir * cannonRange;
          
            
            //Draw the line 
            lineRenderer.SetPosition(0, startPos);
            lineRenderer.SetPosition(1, endPos);

           
        }
    }

    //When the player shoots the cannon
    void OnCannonShoot()
    {
        //lineRenderer.enabled = !lineRenderer.enabled; // truns line off and on when shooting make a debug button later
        Debug.Log("Connon is Shoot");
    }
}
