using UnityEngine;


public class ConnonManager : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float connonRange = 1f;
    public float connonWidth = 0.3f;
    public SpriteRenderer connonSprite;
    Vector3 direction;
    public GameObject connonObject;



    private void Start()
    {
       lineRenderer.positionCount = 2;
        //set the witdth of the Connon line of sight
        lineRenderer.startWidth = connonWidth;

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
            Vector3 startPos = connonObject.transform.position;

            //The direction based on the rotation 
            Vector2 dir = connonObject.transform.right;

            //The raycast2D
            RaycastHit2D hit = Physics2D.Raycast(startPos, dir, connonRange);

            //Ends positions 
            Vector3 endPos = hit.collider != null
                ?(Vector3)hit.point
                :startPos + (Vector3)dir * connonRange;
          
            
            //Draw the line 
            lineRenderer.SetPosition(0, startPos);
            lineRenderer.SetPosition(1, endPos);

           
        }
    }

    void OnConnonShoot()
    {
      lineRenderer.enabled = !lineRenderer.enabled;
        Debug.Log("Connon is Shoot");
    }
}
