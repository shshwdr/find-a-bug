using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSDialogManager : Singleton<CSDialogManager>
{
    public bool isInDialogue;
    public Dictionary<string, bool> finishedDialogue = new Dictionary<string, bool>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startDialog()
    {
        isInDialogue = true;
    }
    public void stopDialog()
    {
        isInDialogue = false;
        BugManager.Instance.finishDialog();
    }
}
