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

    [HideInInspector]
    public int StartWaypoint = 0;
    [HideInInspector]
    public int SCStartWaypoint = 0;

    public bool moveAllowed = false;
    public bool shortcutmoveAllowed = false;

    public bool onShortcut = false;
    public bool passed1stShortcut = false;
    public bool passed2ndShortcut = false;
    public bool passed3rdShortcut = false;

    public GameObject TakeShortcutButton, DontTakeShortcutButton;

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

            Dice.diceAllowed = false;

            // Debug.Log("FTP move repeating ");
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

            Dice.diceAllowed = false;
            
        }
    }
    
}
