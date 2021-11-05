using Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjects : MonoBehaviour
{
    public GameObject staticMonster;
    void Start()
    {

        EventPool.OptIn<int>(EventPool.bugFixed, OnBugFixed);
    }


    void OnBugFixed(int id)
    {
        if (id == 0)
        {
            staticMonster.SetActive(true);
        }
    }
}
