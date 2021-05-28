using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeInformation : MonoBehaviour
{
    static public string gameMode;

    

    public int smallLowRange;
    public int smallHighRange;

    public int horizontalLowRange;
    public int horizontalHighRange;

    public int verticalLowRange;
    public int verticalHighRange;

    public int bigLowRange;
    public int bigHighRange;


    public void LoadPuzzel(string gameMode)
    {
        switch (gameMode)
        {
            case "Small":
                SceneManager.LoadScene(Random.Range(smallLowRange, smallHighRange));
                break;

            case "Horizontal":
                SceneManager.LoadScene(Random.Range(horizontalLowRange, horizontalHighRange));
                break;

            case "Vertical":
                SceneManager.LoadScene(Random.Range(verticalLowRange, verticalHighRange));
                break;

            case "Big":
                SceneManager.LoadScene(Random.Range(bigLowRange,bigHighRange));
                break;

            case "Random":
                SceneManager.LoadScene(Random.Range(smallLowRange, bigHighRange));
                break;
        }
    }
}
