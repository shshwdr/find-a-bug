using Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum BugStatus  { BugDefault, BugTriggered, BugWillBeFixed,BugFixed};
public class BugManager : Singleton<BugManager>
{
    //0 not triggered
    //1 triggered
    public BugStatus[] fixedBugs = new BugStatus[10]; 
    //0 wall no collide
    //1 player rotate when collide
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void fixBug(int id)
    {
        fixedBugs[id] = BugStatus.BugWillBeFixed;

    }

    public void finishDialog()
    {
        for(int i = 0; i < fixedBugs.Length; i++)
        {
            if(fixedBugs[i] == BugStatus.BugWillBeFixed)
            {
                fixedBugs[i] = BugStatus.BugFixed;
                EventPool.Trigger<int>(EventPool.bugFixed,i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
