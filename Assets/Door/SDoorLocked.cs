using UnityEngine;

public class SDoorLocked : DoorBaseState
{
    public override void EnterState(DoorStateManager door)
    {
        Debug.Log("Entered Locked State");
        door.DoorLight.material.SetColor("_EmissionColor", Color.red);
    }

    public override void UpdateState(DoorStateManager door)
    {
        if(door.HasKey.isOn) door.SwitchState(door._unlockedState);
    }

    public override void ActionPerformed(DoorStateManager door, string action)
    {
        Debug.Log("Door is Locked!");
    }
}
