using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGameMode : MonoBehaviour
{
    RaycastHit2D hitinfo;


    public GameModeInformation gameModeInformation;

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
                GameModeInformation.gameMode = hitinfo.transform.gameObject.name;
                gameModeInformation.LoadPuzzel(GameModeInformation.gameMode);
            }
        }

        
        
    }
}
