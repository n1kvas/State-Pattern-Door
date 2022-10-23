using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class SDoorUnlocked : DoorBaseState
{
    public override void EnterState(DoorStateManager door)
    {
        Debug.Log("Entered UnLocked State");
        door.DoorLight.material.SetColor("_EmissionColor", Color.green);
    }

    public override void UpdateState(DoorStateManager door)
    {
        if(!door.HasKey.isOn) door.SwitchState(door._lockedState);
    }

    public override void ActionPerformed(DoorStateManager door, string action)
    {
        if(action == "open") door.SwitchState(door._openState);
    }
}
