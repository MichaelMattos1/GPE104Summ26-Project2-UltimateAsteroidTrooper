using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    public KeyCode teleportKey;

    public KeyCode quitKey;

    private Transform tf;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);

            Vector3 newPosition = new Vector3(randomX, randomY, 0);

            tf.position = newPosition;
        }

        if (Input.GetKeyDown(quitKey)) 
        { 
            Application.Quit();
        }

    }
}
