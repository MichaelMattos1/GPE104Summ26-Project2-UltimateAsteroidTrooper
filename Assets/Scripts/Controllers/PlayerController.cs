using UnityEngine;

public class PlayerController : Controller
{
    
    public KeyCode teleportKey;
    public KeyCode TurboKey;
    public KeyCode quitKey;

    public KeyCode upLocal;
    public KeyCode downLocal;
    public KeyCode leftLocal;
    public KeyCode rightLocal;

    public KeyCode upWorld;
    public KeyCode downWorld;
    public KeyCode leftWorld;
    public KeyCode rightWorld;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        
    }

    // Update is called once per frame
   public override void Update()
    {
        MakeDecisions();
    }

    public void MakeDecisions()
    {
        if (Input.GetKey(TurboKey)) 
        {
            if (Input.GetKey(upLocal))
            {
                //tell pawn to move up
                pawn.TurboUp();
            }
            if (Input.GetKey(downLocal))
            {
                //tell pawn to move down
                pawn.TurboDown();
            }
        }
        if (Input.GetKey(upLocal))
        {
            //tell pawn to move up
            pawn.MoveUp();
        }
        if (Input.GetKey(downLocal))
        {
            //tell pawn to move down
            pawn.MoveDown();
        }
        if (Input.GetKey(leftLocal))
        {
            // tell pawn to rotate countercockwise
            pawn.RotateCounterclockwise();
        }
        if (Input.GetKey(rightLocal))
        {
            //rotate clockwise
            pawn.RotateClockwise();
        }
        if (Input.GetKeyDown(teleportKey)) 
        { 
            pawn.Teleport();
        }

        if (Input.GetKeyDown(downWorld)) 
        {
            pawn.WorldDown();
        }
        if (Input.GetKeyDown(leftWorld))
        {
            pawn.WorldLeft();
        }
        if (Input.GetKeyDown(rightWorld))
        {
            pawn.WorldRight();
        }
        if (Input.GetKeyDown(upWorld)) 
        {  
            pawn.WorldUp(); 
        }



    }
}
