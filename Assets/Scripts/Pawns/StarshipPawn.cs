using System;
using UnityEngine;

public class StarshipPawn : Pawn
{
    
    private Transform tf;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void MoveDown()
    {
        tf.position = tf.position + (-tf.up * moveSpeed * Time.deltaTime);
    }

    public override void MoveUp()
    {
        tf.position = tf.position + (tf.up * moveSpeed * Time.deltaTime);
    }

    public override void RotateClockwise()
    {
        tf.Rotate(0, 0f, -rotateSpeed * Time.deltaTime);
    }

    public override void RotateCounterclockwise()
    {
        tf.Rotate(0, 0f, rotateSpeed * Time.deltaTime);
    }
    public override void Teleport()
    {
        float randomX = UnityEngine.Random.Range(minX, maxX);
        float randomY = UnityEngine.Random.Range(minY, maxY);

        Vector3 newPosition = new Vector3(randomX, randomY, 0);

        tf.position = newPosition;
    }
    public override void WorldDown()
    {
        tf.position = tf.position + (-Vector3.up * teleportDistance);

    }

    public override void WorldUp()
    {
        tf.position = tf.position + (Vector3.up * teleportDistance);
    }

    public override void WorldLeft()
    {
        tf.position = tf.position + (Vector3.left * teleportDistance);
    }

    public override void WorldRight()
    {
        tf.position = tf.position + (-Vector3.left * teleportDistance);
    }
    public override void TurboUp()
    {
        tf.position = tf.position + (tf.up * TurboSpeed * Time.deltaTime);
    }
    public override void TurboDown()
    {
        tf.position = tf.position + (-tf.up * TurboSpeed * Time.deltaTime);
    }


}
