using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    private static HUD _ins;
    public static HUD ins{
        get {
            if (!_ins){
                _ins = new HUD();
            }
            return _ins;
        }
        set {
            _ins = value;
        }
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
