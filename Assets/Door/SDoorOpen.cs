using UnityEngine;

public class SDoorOpen : DoorBaseState
{
    public override void EnterState(DoorStateManager door)
    {
        Debug.Log("Entered Open State");
        door.transform.parent.GetComponent<Animator>().SetBool("isOpen", true);
    }

    public override void UpdateState(DoorStateManager door)
    {
    }

    public override void ActionPerformed(DoorStateManager door, string action)
    {
        if(action == "close") door.SwitchState(door._closedState);
    }
}
