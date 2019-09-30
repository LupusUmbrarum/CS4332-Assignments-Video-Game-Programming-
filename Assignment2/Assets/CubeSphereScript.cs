using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSphereScript : MonoBehaviour
{
	public Color color = Color.black;
	public Vector3 direction = Vector3.left;

    public string nameOfObject = "Default";

    private GameObject self;

    // variables with prefix 'o' are for object,
    private float oWidth, oHeight;
    private float maxX, maxY, minX, minY;

    // if you want the objects to move at a different speed, adjust this
    private float updateSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Renderer myrend = GetComponent<Renderer>();
        myrend.material.color = color;
        self = GameObject.Find(nameOfObject);
        //RectTransform r = (RectTransform)self.transform;
        oWidth = myrend.bounds.size.x / 2f;
        oHeight = myrend.bounds.size.y / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldDim = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 10));

        maxX = worldDim.x;
        maxY = worldDim.y;
        minX = -maxX;
        minY = -maxY;

        float xSpeed, ySpeed;
        xSpeed = maxX * 2f / 10f;
        ySpeed = maxY * 2f / 10f;

        Vector3 update = self.transform.position;

        // check to see if we're moving vertically
        if(direction.x == 0)
        {
            update += direction * Time.deltaTime * updateSpeed * ySpeed;
            if(update.y + oHeight > maxY || update.y - oHeight < minY)
            {
                direction *= -1f;
            }
        }
        // else, we're moving horizontally
        else
        {
            update += direction * Time.deltaTime * updateSpeed * xSpeed;
            if(update.x + oWidth > maxX || update.x - oWidth < minX)
            {
                direction *= -1f;
            }
        }

        self.transform.position = update;
    }
}