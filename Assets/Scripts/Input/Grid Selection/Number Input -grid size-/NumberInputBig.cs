using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberInputBig : MonoBehaviour
{
    RaycastHit2D hitinfo;

    string nameGameObject;

    public GridInformation gridInformation1, gridInformation2, gridInformation3, gridInformation4, gridInformation5, gridInformation6, gridInformation7, gridInformation8, gridInformation9, gridInformation10, gridInformation11, gridInformation12, gridInformation13, gridInformation14, gridInformation15, gridInformation16, gridInformation17, gridInformation18, gridInformation19, gridInformation20, gridInformation21, gridInformation22, gridInformation23, gridInformation24, gridInformation25, gridInformation26, gridInformation27, gridInformation28, gridInformation29, gridInformation30, gridInformation31, gridInformation32, gridInformation33, gridInformation34, gridInformation35, gridInformation36, gridInformation37, gridInformation38, gridInformation39, gridInformation40, gridInformation41, gridInformation42, gridInformation43, gridInformation44, gridInformation45, gridInformation46, gridInformation47, gridInformation48, gridInformation49, gridInformation50, gridInformation51, gridInformation52, gridInformation53, gridInformation54, gridInformation55, gridInformation56, gridInformation57, gridInformation58, gridInformation59, gridInformation60, gridInformation61, gridInformation62, gridInformation63, gridInformation64, gridInformation65, gridInformation66, gridInformation67, gridInformation68, gridInformation69, gridInformation70, gridInformation71, gridInformation72, gridInformation73, gridInformation74, gridInformation75, gridInformation76, gridInformation77, gridInformation78, gridInformation79, gridInformation80, gridInformation81, gridInformation82, gridInformation83, gridInformation84, gridInformation85, gridInformation86, gridInformation87, gridInformation88, gridInformation89, gridInformation90, gridInformation91, gridInformation92, gridInformation93, gridInformation94, gridInformation95, gridInformation96, gridInformation97, gridInformation98, gridInformation99;

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

            case "Grid (21)":
                if (gridInformation21.canBeEdited)
                {
                    gridNumber = 21;
                    InputNumbers(gridInformation21);
                }

                break;

            case "Grid (22)":
                if (gridInformation22.canBeEdited)
                {
                    gridNumber = 22;
                    InputNumbers(gridInformation22);
                }

                break;

            case "Grid (23)":
                if (gridInformation23.canBeEdited)
                {
                    gridNumber = 23;
                    InputNumbers(gridInformation23);
                }

                break;

            case "Grid (24)":
                if (gridInformation24.canBeEdited)
                {
                    gridNumber = 24;
                    InputNumbers(gridInformation24);
                }

                break;

            case "Grid (25)":
                if (gridInformation25.canBeEdited)
                {
                    gridNumber = 25;
                    InputNumbers(gridInformation25);
                }

                break;

            case "Grid (26)":
                if (gridInformation26.canBeEdited)
                {
                    gridNumber = 26;
                    InputNumbers(gridInformation26);
                }

                break;

            case "Grid (27)":
                if (gridInformation27.canBeEdited)
                {
                    gridNumber = 27;
                    InputNumbers(gridInformation27);
                }

                break;

            case "Grid (28)":
                if (gridInformation28.canBeEdited)
                {
                    gridNumber = 28;
                    InputNumbers(gridInformation28);
                }

                break;

            case "Grid (29)":
                if (gridInformation29.canBeEdited)
                {
                    gridNumber = 29;
                    InputNumbers(gridInformation29);
                }

                break;

            case "Grid (30)":
                if (gridInformation30.canBeEdited)
                {
                    gridNumber = 30;
                    InputNumbers(gridInformation30);
                }

                break;

            case "Grid (31)":
                if (gridInformation31.canBeEdited)
                {
                    gridNumber = 31;
                    InputNumbers(gridInformation31);
                }

                break;

            case "Grid (32)":
                if (gridInformation32.canBeEdited)
                {
                    gridNumber = 32;
                    InputNumbers(gridInformation32);
                }

                break;

            case "Grid (33)":
                if (gridInformation33.canBeEdited)
                {
                    gridNumber = 33;
                    InputNumbers(gridInformation33);
                }

                break;

            case "Grid (34)":
                if (gridInformation34.canBeEdited)
                {
                    gridNumber = 34;
                    InputNumbers(gridInformation34);
                }

                break;

            case "Grid (35)":
                if (gridInformation35.canBeEdited)
                {
                    gridNumber = 35;
                    InputNumbers(gridInformation35);
                }

                break;

            case "Grid (36)":
                if (gridInformation36.canBeEdited)
                {
                    gridNumber = 36;
                    InputNumbers(gridInformation36);
                }

                break;

            case "Grid (37)":
                if (gridInformation37.canBeEdited)
                {
                    gridNumber = 37;
                    InputNumbers(gridInformation37);
                }

                break;

            case "Grid (38)":
                if (gridInformation38.canBeEdited)
                {
                    gridNumber = 38;
                    InputNumbers(gridInformation38);
                }

                break;

            case "Grid (39)":
                if (gridInformation39.canBeEdited)
                {
                    gridNumber = 39;
                    InputNumbers(gridInformation39);
                }

                break;

            case "Grid (40)":
                if (gridInformation40.canBeEdited)
                {
                    gridNumber = 40;
                    InputNumbers(gridInformation40);
                }

                break;

            case "Grid (41)":
                if (gridInformation41.canBeEdited)
                {
                    gridNumber = 41;
                    InputNumbers(gridInformation41);
                }

                break;

            case "Grid (42)":
                if (gridInformation42.canBeEdited)
                {
                    gridNumber = 42;
                    InputNumbers(gridInformation42);
                }

                break;

            case "Grid (43)":
                if (gridInformation43.canBeEdited)
                {
                    gridNumber = 43;
                    InputNumbers(gridInformation43);
                }

                break;

            case "Grid (44)":
                if (gridInformation44.canBeEdited)
                {
                    gridNumber = 44;
                    InputNumbers(gridInformation44);
                }

                break;

            case "Grid (45)":
                if (gridInformation45.canBeEdited)
                {
                    gridNumber = 45;
                    InputNumbers(gridInformation45);
                }

                break;

            case "Grid (46)":
                if (gridInformation46.canBeEdited)
                {
                    gridNumber = 46;
                    InputNumbers(gridInformation46);
                }

                break;

            case "Grid (47)":
                if (gridInformation47.canBeEdited)
                {
                    gridNumber = 47;
                    InputNumbers(gridInformation47);
                }

                break;

            case "Grid (48)":
                if (gridInformation48.canBeEdited)
                {
                    gridNumber = 48;
                    InputNumbers(gridInformation48);
                }

                break;

            case "Grid (49)":
                if (gridInformation49.canBeEdited)
                {
                    gridNumber = 49;
                    InputNumbers(gridInformation49);
                }

                break;

            case "Grid (50)":
                if (gridInformation50.canBeEdited)
                {
                    gridNumber = 50;
                    InputNumbers(gridInformation50);
                }

                break;

            case "Grid (51)":
                if (gridInformation51.canBeEdited)
                {
                    gridNumber = 51;
                    InputNumbers(gridInformation51);
                }

                break;

            case "Grid (52)":
                if (gridInformation52.canBeEdited)
                {
                    gridNumber = 52;
                    InputNumbers(gridInformation52);
                }

                break;

            case "Grid (53)":
                if (gridInformation53.canBeEdited)
                {
                    gridNumber = 53;
                    InputNumbers(gridInformation53);
                }

                break;

            case "Grid (54)":
                if (gridInformation54.canBeEdited)
                {
                    gridNumber = 54;
                    InputNumbers(gridInformation54);
                }

                break;

            case "Grid (55)":
                if (gridInformation55.canBeEdited)
                {
                    gridNumber = 55;
                    InputNumbers(gridInformation55);
                }

                break;

            case "Grid (56)":
                if (gridInformation56.canBeEdited)
                {
                    gridNumber = 56;
                    InputNumbers(gridInformation56);
                }

                break;

            case "Grid (57)":
                if (gridInformation57.canBeEdited)
                {
                    gridNumber = 57;
                    InputNumbers(gridInformation57);
                }

                break;

            case "Grid (58)":
                if (gridInformation58.canBeEdited)
                {
                    gridNumber = 58;
                    InputNumbers(gridInformation58);
                }

                break;

            case "Grid (59)":
                if (gridInformation59.canBeEdited)
                {
                    gridNumber = 59;
                    InputNumbers(gridInformation59);
                }

                break;

            case "Grid (60)":
                if (gridInformation60.canBeEdited)
                {
                    gridNumber = 60;
                    InputNumbers(gridInformation60);
                }

                break;

            case "Grid (61)":
                if (gridInformation61.canBeEdited)
                {
                    gridNumber = 61;
                    InputNumbers(gridInformation61);
                }

                break;

            case "Grid (62)":
                if (gridInformation62.canBeEdited)
                {
                    gridNumber = 62;
                    InputNumbers(gridInformation62);
                }

                break;

            case "Grid (63)":
                if (gridInformation63.canBeEdited)
                {
                    gridNumber = 63;
                    InputNumbers(gridInformation63);
                }

                break;

            case "Grid (64)":
                if (gridInformation64.canBeEdited)
                {
                    gridNumber = 64;
                    InputNumbers(gridInformation64);
                }

                break;

            case "Grid (65)":
                if (gridInformation65.canBeEdited)
                {
                    gridNumber = 65;
                    InputNumbers(gridInformation65);
                }

                break;

            case "Grid (66)":
                if (gridInformation66.canBeEdited)
                {
                    gridNumber = 66;
                    InputNumbers(gridInformation66);
                }

                break;

            case "Grid (67)":
                if (gridInformation67.canBeEdited)
                {
                    gridNumber = 67;
                    InputNumbers(gridInformation67);
                }

                break;

            case "Grid (68)":
                if (gridInformation68.canBeEdited)
                {
                    gridNumber = 68;
                    InputNumbers(gridInformation68);
                }

                break;

            case "Grid (69)":
                if (gridInformation69.canBeEdited)
                {
                    gridNumber = 69;
                    InputNumbers(gridInformation69);
                }

                break;

            case "Grid (70)":
                if (gridInformation70.canBeEdited)
                {
                    gridNumber = 70;
                    InputNumbers(gridInformation70);
                }
                break;

            case "Grid (71)":
                if (gridInformation71.canBeEdited)
                {
                    gridNumber = 71;
                    InputNumbers(gridInformation71);
                }

                break;

            case "Grid (72)":
                if (gridInformation72.canBeEdited)
                {
                    gridNumber = 72;
                    InputNumbers(gridInformation72);
                }
                break;

            case "Grid (73)":
                if (gridInformation73.canBeEdited)
                {
                    gridNumber = 73;
                    InputNumbers(gridInformation73);
                }
                break;

            case "Grid (74)":
                if (gridInformation74.canBeEdited)
                {
                    gridNumber = 74;
                    InputNumbers(gridInformation74);
                }
                break;

            case "Grid (75)":
                if (gridInformation75.canBeEdited)
                {
                    gridNumber = 75;
                    InputNumbers(gridInformation75);
                }
                break;

            case "Grid (76)":
                if (gridInformation76.canBeEdited)
                {
                    gridNumber = 76;
                    InputNumbers(gridInformation76);
                }
                break;

            case "Grid (77)":
                if (gridInformation77.canBeEdited)
                {
                    gridNumber = 77;
                    InputNumbers(gridInformation77);
                }
                break;

            case "Grid (78)":
                if (gridInformation78.canBeEdited)
                {
                    gridNumber = 78;
                    InputNumbers(gridInformation78);
                }
                break;

            case "Grid (79)":
                if (gridInformation79.canBeEdited)
                {
                    gridNumber = 79;
                    InputNumbers(gridInformation79);
                }
                break;

            case "Grid (80)":
                if (gridInformation80.canBeEdited)
                {
                    gridNumber = 80;
                    InputNumbers(gridInformation80);
                }
                break;

            case "Grid (81)":
                if (gridInformation81.canBeEdited)
                {
                    gridNumber = 81;
                    InputNumbers(gridInformation81);
                }
                break;

            case "Grid (82)":
                if (gridInformation82.canBeEdited)
                {
                    gridNumber = 82;
                    InputNumbers(gridInformation82);
                }
                break;

            case "Grid (83)":
                if (gridInformation83.canBeEdited)
                {
                    gridNumber = 83;
                    InputNumbers(gridInformation83);
                }
                break;

            case "Grid (84)":
                if (gridInformation84.canBeEdited)
                {
                    gridNumber = 84;
                    InputNumbers(gridInformation84);
                }
                break;

            case "Grid (85)":
                if (gridInformation85.canBeEdited)
                {
                    gridNumber = 85;
                    InputNumbers(gridInformation85);
                }
                break;

            case "Grid (86)":
                if (gridInformation86.canBeEdited)
                {
                    gridNumber = 86;
                    InputNumbers(gridInformation86);
                }
                break;

            case "Grid (87)":
                if (gridInformation87.canBeEdited)
                {
                    gridNumber = 87;
                    InputNumbers(gridInformation87);
                }
                break;

            case "Grid (88)":
                if (gridInformation88.canBeEdited)
                {
                    gridNumber = 88;
                    InputNumbers(gridInformation88);
                }
                break;

            case "Grid (89)":
                if (gridInformation89.canBeEdited)
                {
                    gridNumber = 89;
                    InputNumbers(gridInformation89);
                }
                break;

            case "Grid (90)":
                if (gridInformation90.canBeEdited)
                {
                    gridNumber = 90;
                    InputNumbers(gridInformation90);
                }
                break;

            case "Grid (91)":
                if (gridInformation91.canBeEdited)
                {
                    gridNumber = 91;
                    InputNumbers(gridInformation91);
                }
                break;

            case "Grid (92)":
                if (gridInformation92.canBeEdited)
                {
                    gridNumber = 92;
                    InputNumbers(gridInformation92);
                }
                break;

            case "Grid (93)":
                if (gridInformation93.canBeEdited)
                {
                    gridNumber = 93;
                    InputNumbers(gridInformation93);
                }
                break;

            case "Grid (94)":
                if (gridInformation94.canBeEdited)
                {
                    gridNumber = 94;
                    InputNumbers(gridInformation94);
                }
                break;

            case "Grid (95)":
                if (gridInformation95.canBeEdited)
                {
                    gridNumber = 95;
                    InputNumbers(gridInformation95);
                }
                break;

            case "Grid (96)":
                if (gridInformation96.canBeEdited)
                {
                    gridNumber = 96;
                    InputNumbers(gridInformation96);
                }
                break;

            case "Grid (97)":
                if (gridInformation97.canBeEdited)
                {
                    gridNumber = 97;
                    InputNumbers(gridInformation97);
                }
                break;

            case "Grid (98)":
                if (gridInformation98.canBeEdited)
                {
                    gridNumber = 98;
                    InputNumbers(gridInformation98);
                }
                break;

            case "Grid (99)":
                if (gridInformation99.canBeEdited)
                {
                    gridNumber = 99;
                    InputNumbers(gridInformation99);
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


