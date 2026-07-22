using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //declare SpriteRenderer component
    public SpriteRenderer theRenderer;

    // declare a variable for a custom color
    public Color customColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theRenderer = GetComponent<SpriteRenderer>();
        //access the "Color" property of SpriteRenderer Component and change it's value to blue
        if (theRenderer != null)
        {
            theRenderer.color = customColor;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
