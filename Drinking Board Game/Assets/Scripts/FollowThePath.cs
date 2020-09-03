using UnityEngine;
using UnityEngine.Tilemaps;

public class FollowThePath : MonoBehaviour {

    public Transform[] waypoints;
    public Transform[] shortcutwaypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    // [HideInInspector]
    public int StartwaypointIndex = 0;
    // [HideInInspector]
    public int shortcutwaypointIndex = 0;

    public int passShortcutNormRoll = 0;
    public int passShortcutSCRoll = 0;

    // [HideInInspector]
    public int StartWaypoint = 0;
    // [HideInInspector]
    public int SCStartWaypoint = 0;

    public int tileNum = 0;

    public bool moveAllowed = false;
    public bool shortcutmoveAllowed = false;

    public bool onShortcutTile = false;
    public bool onShortcut = false;
    public bool passed1stShortcut = false;
    public bool passed2ndShortcut = false;
    public bool passed3rdShortcut = false;
    public bool LandedOnTile = false;

    public GameObject TakeShortcutButton, DontTakeShortcutButton;

    // Use this for initialization
    private void Start ()
    {
        transform.position = waypoints[StartwaypointIndex].transform.position;
        onShortcut = false;

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
        //////////////////////////// Part of Version 3
        if (StartWaypoint + NewGameControl.diceSideThrown > 4 && passed1stShortcut == false)
        {
            tileNum = 4;
            onShortcutTile = true;
        }
        else if (StartWaypoint + NewGameControl.diceSideThrown > 12 && passed2ndShortcut == false)
        {
            tileNum = 12;
            onShortcutTile = true;
        }
        else if (StartWaypoint + NewGameControl.diceSideThrown > 19 && passed3rdShortcut == false)
        {
            tileNum = 19;
            onShortcutTile = true;
        }
        else
        {
            tileNum = 0;
        }


        // Version 3 - the switch/case statement 
        if (StartwaypointIndex <= waypoints.Length - 1)
        {
            switch (tileNum)
            {
                case 4:
                case 12:
                case 19:
                    transform.position = Vector2.MoveTowards(transform.position,
                    waypoints[tileNum].transform.position,
                    moveSpeed * Time.deltaTime);
                    if (transform.position == waypoints[tileNum].transform.position)
                    {
                        StartwaypointIndex += 1;
                        // LandedOnTile = true;
                    }
                    break;


                default:
                    transform.position = Vector2.MoveTowards(transform.position,
                        waypoints[StartwaypointIndex].transform.position,
                        moveSpeed * Time.deltaTime);
                        if (transform.position == waypoints[StartwaypointIndex].transform.position)
                        {
                            StartwaypointIndex += 1;
                            LandedOnTile = true;
                        }
                        break;

            }

            Dice.diceAllowed = false;
        }

    }

    private void ShortcutMove()
    {
        if (shortcutwaypointIndex <= waypoints.Length - 1 && onShortcutTile == false)                      // moves until hits finish line 
        {
            transform.position = Vector2.MoveTowards(transform.position,
            shortcutwaypoints[shortcutwaypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            if (transform.position == shortcutwaypoints[shortcutwaypointIndex].transform.position)
            {
                shortcutwaypointIndex += 1;
                LandedOnTile = true;
            }

            Dice.diceAllowed = false;
            
        }
    }
    
}
