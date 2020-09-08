using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPlayer : BaseRobot
{
    public static RobotPlayer ins;
    public static RobotPlayer getIns(){
        return ins;
    }
    private void Awake(){
        ins = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
