using UnityEngine;

public class FollowThePath : MonoBehaviour {

    public Transform[] waypoints;
    public Transform[] shortcutwaypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int StartwaypointIndex = 0;
    [HideInInspector]
    public int shortcutwaypointIndex = 0;

    public bool moveAllowed = false;
    public bool shortcutmoveAllowed = false;

    public bool onShortcut = false;
    public bool passed1stShortcut = false;
    public bool passed2ndShortcut = false;
    public bool passed3rdShortcut = false;



    // Use this for initialization
    private void Start ()
    {
        transform.position = waypoints[StartwaypointIndex].transform.position;
        onShortcut = false;

        // Unused code 
        // TakeShortcutButton = GameObject.Find("TakeShortcutButton");
        // DontTakeShortcutButton = GameObject.Find("DontTakeShortcutButton");

    }
	
	// Update is called once per frame
	private void Update() 
    {
        if (moveAllowed)
            Move();
        if (shortcutmoveAllowed)
            ShortcutMove();
	}

    private void Move()
    {
        if (StartwaypointIndex <= waypoints.Length - 1)                      // moves until hits finish line 
        {
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[StartwaypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            // Debugs
            // Debug.Log("player1startwaypoint " + GameControl.player1StartWaypoint);

            if (transform.position == waypoints[StartwaypointIndex].transform.position)
            {
                StartwaypointIndex += 1;
            }
        }
    }

    private void ShortcutMove()
    {
        if (shortcutwaypointIndex <= waypoints.Length - 1)                      // moves until hits finish line 
        {
            transform.position = Vector2.MoveTowards(transform.position,
            shortcutwaypoints[shortcutwaypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            // Debug
            // Debug.Log("SHORTCUT MOVE SHORTCUTWAYPOINT INDEX " + shortcutwaypoints[shortcutwaypointIndex]);
            
            if (transform.position == shortcutwaypoints[shortcutwaypointIndex].transform.position)
            {
                shortcutwaypointIndex += 1;
            }
            
        }
    }
    

    // Unused code might end up using 
    /*
    public void PlayerTakeShortcut()
    {
        onShortcut = true;
        passed1stShortcut = true;
        // player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[player1.GetComponent<FollowThePath>().shortcutwaypointIndex].transform.position;

        transform.position = Vector2.MoveTowards(transform.position,
        shortcutwaypoints[shortcutwaypointIndex].transform.position,
        1f * Time.deltaTime);

        GameControl.player1SCStartWaypoint = shortcutwaypointIndex - 1;

        TakeShortcutButton.gameObject.SetActive(false);
        DontTakeShortcutButton.gameObject.SetActive(false);
        GetComponent<GameControl>().shotforshortcutTile.gameObject.SetActive(false);
        moveAllowed = false;            // to stop from moving after starting the shortcut--you can make true if you want to continue the roll past the shortcut
        shortcutmoveAllowed = false;

        Debug.Log("SHORTCUTWAYPOINT INDEX" + shortcutwaypointIndex);
        // Debug.Log("P1SC + DICEROLL" + player1SCStartWaypoint + diceSideThrown);
        // Debug.Log("IF ONSHORTCUT " + player1.GetComponent<FollowThePath>().onShortcut); // was on shortcut at this point 
        // Debug.Log("ON SHORTCUT? " + player1.GetComponent<FollowThePath>().onShortcut);
        // Debug.Log("P1START WAYPOINT " + player1StartWaypoint);
    }

    public void PlayerDontTakeShortcut()
    {

        passed1stShortcut = true;
        transform.position = waypoints[5].transform.position;
        shortcutmoveAllowed = false;
        onShortcut = false;
        StartwaypointIndex = 5;
        StartwaypointIndex += 1;
        TakeShortcutButton.gameObject.SetActive(false);
        DontTakeShortcutButton.gameObject.SetActive(false);
        GetComponent<GameControl>().shotforshortcutTile.gameObject.SetActive(false);
        GameControl.player1StartWaypoint = StartwaypointIndex - 1;
        
        // Debug.Log("OTHER BUTTON GETTING CLICKED");
                
    }
    */    
    
}
