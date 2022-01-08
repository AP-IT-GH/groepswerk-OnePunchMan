using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : PhysicsButton
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GamePaused)
            Time.timeScale = 1;
    }

    protected override void Pressed()
    {
        base.Pressed();
        GamePaused = false;
    }
}
