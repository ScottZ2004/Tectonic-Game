using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGameMode : MonoBehaviour
{
    RaycastHit2D hitinfo;

    string nameGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if you touch the screen
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            // hitinfo becomes true if the touch is on a collider
            hitinfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), Vector2.zero);

            // if hitinfo is true
            if (hitinfo)
            {
                // nameGameObject becomes the name of the collided game object
                nameGameObject = hitinfo.transform.gameObject.name;

            }
        }

        // this switch case is to ceck which gameObject you touched
        switch (nameGameObject)
        {
            // if you pressed the play button
            case "Small":

                Debug.Log("een klein leveltje");

                // nameGameObject becomes nothing so this case wont be called again
                nameGameObject = "";
                break;

            case "Horizontal":
                Debug.Log("een platte");

                // nameGameObject becomes nothing so this case wont be called again
                nameGameObject = "";
                break;

            case "Vertical":
                Debug.Log("een lange");

                // nameGameObject becomes nothing so this case wont be called again
                nameGameObject = "";
                break;

            case "Big":
                Debug.Log("een groje");

                // nameGameObject becomes nothing so this case wont be called again
                nameGameObject = "";
                break;

            case "Random":
                Debug.Log("gewoon een, boeit niet echt");

                // nameGameObject becomes nothing so this case wont be called again
                nameGameObject = "";
                break;
        }
    }
}
