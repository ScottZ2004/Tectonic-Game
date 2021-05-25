using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberInputSmall : MonoBehaviour
{
    RaycastHit2D hitinfo;

    string nameGameObject;

    public GridInformation gridInformation1, gridInformation2, gridInformation3, gridInformation4, gridInformation5, gridInformation6, gridInformation7, gridInformation8, gridInformation9, gridInformation10, gridInformation11, gridInformation12, gridInformation13, gridInformation14
        , gridInformation15, gridInformation16, gridInformation17, gridInformation18, gridInformation19, gridInformation20;

    int gridNumber;

    public int[] inputNumbers;

    public int[] solution;
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
            case "Grid (1)":
                if (gridInformation1.canBeEdited)
                {
                    gridNumber = 1;
                    InputNumbers(gridInformation1);
                }
                
                break;

            case "Grid (2)":
                if (gridInformation2.canBeEdited)
                {
                    gridNumber = 2;
                    InputNumbers(gridInformation2);
                }
               
                break;

            case "Grid (3)":
                if (gridInformation3.canBeEdited)
                {
                    gridNumber = 3;
                    InputNumbers(gridInformation3);
                }

                break;

            case "Grid (4)":
                if (gridInformation4.canBeEdited)
                {
                    gridNumber = 4;
                    InputNumbers(gridInformation4);
                }

                break;

            case "Grid (5)":
                if (gridInformation5.canBeEdited)
                {
                    gridNumber = 5;
                    InputNumbers(gridInformation5);
                }

                break;

            case "Grid (6)":
                if (gridInformation6.canBeEdited)
                {
                    gridNumber = 6;
                    InputNumbers(gridInformation6);
                }

                break;

            case "Grid (7)":
                if (gridInformation7.canBeEdited)
                {
                    gridNumber = 7;
                    InputNumbers(gridInformation7);
                }

                break;
            case "Grid (8)":
                if (gridInformation8.canBeEdited)
                {
                    gridNumber = 8;
                    InputNumbers(gridInformation8);
                }

                break;
            case "Grid (9)":
                if (gridInformation9.canBeEdited)
                {
                    gridNumber = 9;
                    InputNumbers(gridInformation9);
                }

                break;
            case "Grid (10)":
                if (gridInformation10.canBeEdited)
                {
                    gridNumber = 10;
                    InputNumbers(gridInformation10);
                }

                break;
            case "Grid (11)":
                if (gridInformation11.canBeEdited)
                {
                    gridNumber = 11;
                    InputNumbers(gridInformation11);
                }

                break;
            case "Grid (12)":
                if (gridInformation12.canBeEdited)
                {
                    gridNumber = 12;
                    InputNumbers(gridInformation12);
                }

                break;

            case "Grid (13)":
                if (gridInformation13.canBeEdited)
                {
                    gridNumber = 13;
                    InputNumbers(gridInformation13);
                }
                break;
            case "Grid (14)":
                if (gridInformation14.canBeEdited)
                {
                    gridNumber = 14;
                    InputNumbers(gridInformation14);
                }

                break;
            case "Grid (15)":
                if (gridInformation15.canBeEdited)
                {
                    gridNumber = 15;
                    InputNumbers(gridInformation15);
                }

                break;
            case "Grid (16)":
                if (gridInformation16.canBeEdited)
                {
                    gridNumber = 16;
                    InputNumbers(gridInformation16);
                }

                break;
            case "Grid (17)":
                if (gridInformation17.canBeEdited)
                {
                    gridNumber = 17;
                    InputNumbers(gridInformation17);
                }

                break;
            case "Grid (18)":
                if (gridInformation18.canBeEdited)
                {
                    gridNumber = 18;
                    InputNumbers(gridInformation18);
                }

                break;
            case "Grid (19)":
                if (gridInformation19.canBeEdited)
                {
                    gridNumber = 19;
                    InputNumbers(gridInformation19);
                }

                break;
            case "Grid (20)":
                if (gridInformation20.canBeEdited)
                {
                    gridNumber = 20;
                    InputNumbers(gridInformation20);
                }

                break;


        }
    }
    void InputNumbers(GridInformation gridinFormation)
    {
        if (NumberSelection.number1IsSelected)
        {
            InputNumber(gridinFormation.number1, gridinFormation.number2, gridinFormation.number3, gridinFormation.number4, gridinFormation.number5);
            inputNumbers[gridNumber - 1] = 1;
        }
        else if (NumberSelection.number2IsSelected)
        {
            InputNumber(gridinFormation.number2, gridinFormation.number1, gridinFormation.number3, gridinFormation.number4, gridinFormation.number5);
            inputNumbers[gridNumber - 1] = 2;
        }
        else if (NumberSelection.number3IsSelected)
        {
            InputNumber(gridinFormation.number3, gridinFormation.number2, gridinFormation.number1, gridinFormation.number4, gridinFormation.number5);
            inputNumbers[gridNumber - 1] = 3;
        }
        else if (NumberSelection.number4IsSelected)
        {
            InputNumber(gridinFormation.number4, gridinFormation.number2, gridinFormation.number3, gridinFormation.number1, gridinFormation.number5);
            inputNumbers[gridNumber - 1] = 4;
        }
        else if (NumberSelection.number5IsSelected)
        {
            InputNumber(gridinFormation.number5, gridinFormation.number2, gridinFormation.number3, gridinFormation.number4, gridinFormation.number1);
            inputNumbers[gridNumber - 1] = 5;
        }
        
    }

    void InputNumber(GameObject numberInput, GameObject otherGameObject1, GameObject otherGameObject2, GameObject otherGameObject3, GameObject otherGameObject4)
    {
        numberInput.SetActive(true);
        otherGameObject1.SetActive(false);
        otherGameObject2.SetActive(false);
        otherGameObject3.SetActive(false);
        otherGameObject4.SetActive(false);
    }
}
