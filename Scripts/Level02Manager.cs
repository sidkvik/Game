using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02Manager : MonoBehaviour
{
    public GameObject targetLev1;
    public GameObject targetLev2;
    public GameObject targetLev3;
    public GameObject targetLev3_1;
    public GameObject targetLev3_2;
    public GameObject targetLev3_3;
    public GameObject finish;
    static public float logiclev3;

    public void startLevel1()
    {
        targetLev1.SetActive(true);
    }
    public void startLevel2()
    {
        targetLev2.SetActive(true);
    }
    public void startLevel3()
    {
        targetLev3.SetActive(true);
        targetLev3_1.SetActive(true);
        targetLev3_2.SetActive(true);
        targetLev3_3.SetActive(true);
    }
    public void finishTargets()
    {
        
        finish.SetActive(true);
    }
}
