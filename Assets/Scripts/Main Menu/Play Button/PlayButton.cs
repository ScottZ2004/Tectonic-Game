using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject playButton;
    Animator animator;
    

    string nameGameObject;

    RaycastHit2D hitinfo;
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
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
            case "Play knop":

                StartCoroutine(PlayButtonPressed());

                // nameGameObject becomes nothing so this case wont be called again
                nameGameObject = "";
                break;
            

        }

    }

    IEnumerator PlayButtonPressed()
    {
        //plays animation
        animator.SetBool("playPlayButtonAnimation", true);

        //waits
        yield return new WaitForSeconds(0.6f);

        // sets this bool true for playing the aimation
        GameModes.playGameModeAnimation = true;
    }


    

}
