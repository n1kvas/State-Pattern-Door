public abstract class DoorBaseState
{
    public abstract void EnterState(DoorStateManager door);

    public abstract void UpdateState(DoorStateManager door);

    public abstract void ActionPerformed(DoorStateManager door, string action);
}
