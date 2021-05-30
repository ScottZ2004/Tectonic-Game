using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMenu : MonoBehaviour
{
    RaycastHit2D hitinfo;

    string nameGameObject;

    public GameModeInformation gameModeInformation;

    void Start()
    {
        gameModeInformation = GameObject.FindObjectOfType<GameModeInformation>();
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

        switch (nameGameObject)
        {
            case "Next Level":
                gameModeInformation.LoadPuzzel(GameModeInformation.gameMode);
                break;

            case "Main Menu":
                SceneManager.LoadScene(0);
                break;
        }
    }
}
