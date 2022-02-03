using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : Vehicle
{
    
    protected override void JumpIn() {
        if(Input.GetKeyDown(KeyCode.E)) {
            print ("Aquí es donde te subes al barco");
        }
    }

}
