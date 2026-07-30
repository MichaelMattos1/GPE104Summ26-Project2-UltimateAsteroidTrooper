using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    public float moveSpeed;
    public float TurboSpeed;
    public float rotateSpeed;

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    public float teleportDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public abstract void MoveUp();

    public abstract void MoveDown();

    public abstract void RotateCounterclockwise();

    public abstract void RotateClockwise();

    public abstract void Teleport();

    public abstract void WorldUp();

    public abstract void WorldDown();

    public abstract void WorldLeft();

    public abstract void WorldRight();

    public abstract void TurboUp();

    public abstract void TurboDown();
}

