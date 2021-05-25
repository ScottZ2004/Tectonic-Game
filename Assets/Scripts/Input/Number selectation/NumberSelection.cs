using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSelection : MonoBehaviour
{ 
    RaycastHit2D hitinfo;

    string nameGameObject;

    public NumberInformation numberInformation1;
    public NumberInformation numberInformation2;
    public NumberInformation numberInformation3;
    public NumberInformation numberInformation4;
    public NumberInformation numberInformation5;

    static public bool number1IsSelected;
    static public bool number2IsSelected;
    static public bool number3IsSelected;
    static public bool number4IsSelected;
    static public bool number5IsSelected;

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
            case "1":
                //if 1 isn't selected
                if (!numberInformation1.isSelected)
                {
                    numberInformation1.isSelected = true;
                    SelectNumber(numberInformation1.selected, numberInformation1.unselected);
                    UnselectNumbers(numberInformation2, numberInformation3, numberInformation4, numberInformation5);
                }
                break;

            case "2":
                //if 2 isn't selected
                if (!numberInformation2.isSelected)
                {
                    numberInformation2.isSelected = true;
                    SelectNumber(numberInformation2.selected, numberInformation2.unselected);
                    UnselectNumbers(numberInformation1, numberInformation3, numberInformation4, numberInformation5);
                }
                break;

            case "3":
                //if 3 isn't selected
                if (!numberInformation3.isSelected)
                {
                    numberInformation3.isSelected = true;
                    SelectNumber(numberInformation3.selected, numberInformation3.unselected);
                    UnselectNumbers(numberInformation1, numberInformation2, numberInformation4, numberInformation5);
                }
                break;

            case "4":
                //if 4 isn't selected
                if (!numberInformation4.isSelected)
                {
                    numberInformation4.isSelected = true;
                    SelectNumber(numberInformation4.selected, numberInformation4.unselected);
                    UnselectNumbers(numberInformation1, numberInformation2, numberInformation3, numberInformation5);
                }
                break;

            case "5":
                //if 5 isn't selected
                if (!numberInformation5.isSelected)
                {
                    numberInformation5.isSelected = true;
                    SelectNumber(numberInformation5.selected, numberInformation5.unselected);
                    UnselectNumbers(numberInformation1, numberInformation2 , numberInformation3, numberInformation4);
                }
                break;

            default:
                break;
        }
        // number[]IsSelected takes the value of isSelected
        number1IsSelected = numberInformation1.isSelected;
        number2IsSelected = numberInformation2.isSelected;
        number3IsSelected = numberInformation3.isSelected;
        number4IsSelected = numberInformation4.isSelected;
        number5IsSelected = numberInformation5.isSelected;
        
    }

    void SelectNumber(GameObject selected, GameObject unselected)
    {
        
        unselected.SetActive(false);
        selected.SetActive(true);
    }

    void UnselectNumbers(NumberInformation one, NumberInformation two, NumberInformation three, NumberInformation four)
    {
        if (one.isSelected)
        {
            UnselectNumber(one.selected, one.unselected);
            one.isSelected = false;
        }
        else if(two.isSelected)
        {
            UnselectNumber(two.selected, two.unselected);
            two.isSelected = false;
        }
        else if (three.isSelected)
        {
            UnselectNumber(three.selected, three.unselected);
            three.isSelected = false;
        }
        else if (four.isSelected)
        {
            UnselectNumber(four.selected, four.unselected);
            four.isSelected = false;
        }
    }

    void UnselectNumber(GameObject selected, GameObject unselected)
    {
        unselected.SetActive(true);
        selected.SetActive(false);
    }
}