using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfLevelComplete : MonoBehaviour
{
    public NumberInputSmall numberInputSmall;
    public NumberInputHorizontal numberInputHorizontal;
    public NumberInputVertical numberInputVertical;
    public NumberInputBig numberInputBig;

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        switch (gameObject.name)
        {
            case "Small grid":
                numberInputSmall = GameObject.FindObjectOfType<NumberInputSmall>();
                break;

            case "Horizontal grid":
                numberInputHorizontal = GameObject.FindObjectOfType<NumberInputHorizontal>();
                break;

            case "Vertical grid":
                numberInputVertical = GameObject.FindObjectOfType<NumberInputVertical>();
                break;

            case "Big grid":
                numberInputBig = GameObject.FindObjectOfType<NumberInputBig>();
                break;

            default:
                Debug.Log("geen goede grid");
                break;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (gameObject.name)
        {
            case "Small grid":
                CheckIfSmallIsFilledIn();
                break;

            case "Horizontal grid":
                CheckIfHorizontalIsFilledIn();
                break;

            case "Vertical grid":
                CheckIfVerticalIsFilledIn();
                break;

            case "Big grid":
                CheckIfBigIsFilledIn();
                break;

            default:
                Debug.Log("geen goede grid");
                break;
        }
    }

    void CheckIfSmallIsFilledIn()
    {
        bool b = true;

        
        for (int i = 0; i < numberInputSmall.inputNumbers.Length; i++)
        {
            
            if(numberInputSmall.inputNumbers[i] == 0 || !b)
            {
               
                b = false;
            }
            
        }

        if (b)
        {
            Debug.Log("Alles is Ingevult");
            CheckIfSmallIsCorrect();
        }
    }

    void CheckIfHorizontalIsFilledIn()
    {
        bool b = true;


        for (int i = 0; i < numberInputHorizontal.inputNumbers.Length; i++)
        {

            if (numberInputHorizontal.inputNumbers[i] == 0 || !b)
            {

                b = false;
            }

        }

        if (b)
        {
            Debug.Log("Alles is Ingevult");
            CheckIfHorizontalIsCorrect();
        }
    }

    void CheckIfVerticalIsFilledIn()
    {
        bool b = true;


        for (int i = 0; i < numberInputVertical.inputNumbers.Length; i++)
        {

            if (numberInputVertical.inputNumbers[i] == 0 || !b)
            {

                b = false;
            }

        }

        if (b)
        {
            Debug.Log("Alles is Ingevult");
            CheckIfVerticalIsCorrect();
        }
    }

    void CheckIfBigIsFilledIn()
    {
        bool b = true;


        for (int i = 0; i < numberInputBig.inputNumbers.Length; i++)
        {

            if (numberInputBig.inputNumbers[i] == 0 || !b)
            {

                b = false;
            }

        }

        if (b)
        {
            Debug.Log("Alles is Ingevult");
            CheckIfBigIsCorrect();
        }
    }

    void CheckIfSmallIsCorrect()
    {
        bool b = true;
        for (int i = 0; i < numberInputSmall.inputNumbers.Length; i++)
        {

            if (numberInputSmall.solution[i] == numberInputSmall.inputNumbers[i] && b)
            {

            }
            else
            {
                b = false;
            }

        }

        if (b)
        {
            Debug.Log("Alles is correct ingevult");
            canvas.SetActive(true);
        }
    }

    void CheckIfHorizontalIsCorrect()
    {
        bool b = true;
        for (int i = 0; i < numberInputHorizontal.inputNumbers.Length; i++)
        {

            if (numberInputHorizontal.solution[i] == numberInputHorizontal.inputNumbers[i] && b)
            {

            }
            else
            {
                b = false;
            }

        }

        if (b)
        {
            Debug.Log("Alles is correct ingevult");
            canvas.SetActive(true);
        }
    }

    void CheckIfVerticalIsCorrect()
    {
        bool b = true;
        for (int i = 0; i < numberInputVertical.inputNumbers.Length; i++)
        {

            if (numberInputVertical.solution[i] == numberInputVertical.inputNumbers[i] && b)
            {

            }
            else
            {
                b = false;
            }

        }

        if (b)
        {
            Debug.Log("Alles is correct ingevult");
            canvas.SetActive(true);
        }
    }

    void CheckIfBigIsCorrect()
    {
        bool b = true;
        for (int i = 0; i < numberInputBig.inputNumbers.Length; i++)
        {

            if (numberInputBig.solution[i] == numberInputBig.inputNumbers[i] && b)
            {

            }
            else
            {
                b = false;
            }

        }

        if (b)
        {
            Debug.Log("Alles is correct ingevult");
            canvas.SetActive(true);
        }
    }
}
