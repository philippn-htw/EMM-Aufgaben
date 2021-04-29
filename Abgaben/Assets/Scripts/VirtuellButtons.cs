using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class VirtuellButtons : MonoBehaviour
{

    public PlayerBehaviour movablePlayer;

    // Start is called before the first frame update
    void Start()
    {
        //SearchforallChildrenfromthisImageTargetwithtypeVirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0;i<vbs.Length;++i){
            //RegisterwiththevirtualbuttonsTrackableBehaviour
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch(vb.VirtualButtonName){
            case "buttonO":
                movablePlayer.externVertical = 1;
                break;
            case "buttonB":
                movablePlayer.externVertical = -1;
                break;
            case "buttonL":
                movablePlayer.externHorizontal = 1;
                break;
            case "buttonR":
                movablePlayer.externHorizontal = -1;
                break;
        }          
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch(vb.VirtualButtonName){
            case "buttonO":
                movablePlayer.externVertical = 0;
                break;
            case "buttonB":
                movablePlayer.externVertical = 0;
                break;
            case "buttonL":
                movablePlayer.externHorizontal = 0;
                break;
            case "buttonR":
                movablePlayer.externHorizontal = 0;
                break;
        }          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
