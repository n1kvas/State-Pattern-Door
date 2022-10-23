using UnityEngine;

public class SDoorClosed : DoorBaseState
{
    public override void EnterState(DoorStateManager door)
    {
        Debug.Log("Entered Closed State");
        door.transform.parent.GetComponent<Animator>().SetBool("isOpen", false);
    }

    public override void UpdateState(DoorStateManager door)
    {
        if(!door.HasKey.isOn) door.SwitchState(door._lockedState);
    }

    public override void ActionPerformed(DoorStateManager door, string action)
    {
        door.SwitchState(door._openState);
    }
}
