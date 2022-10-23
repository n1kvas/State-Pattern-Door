using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoorStateManager : MonoBehaviour
{
    //interaction members
    [SerializeField] private Button _open, _close;
    [SerializeField] private Toggle _hasKey;
    [SerializeField] private Renderer _doorLight;

    //state sontrol members
    private DoorBaseState _currentState;
    public SDoorLocked _lockedState = new SDoorLocked();
    public SDoorUnlocked _unlockedState = new SDoorUnlocked();
    public SDoorOpen _openState = new SDoorOpen();
    public SDoorClosed _closedState = new SDoorClosed();

    //Getters-Setters
    public Toggle HasKey { get => _hasKey; set => _hasKey = value; }
    public Renderer DoorLight { get => _doorLight; set => _doorLight = value; }

    private void Awake()
    {
        _open.onClick.AddListener(() => ActionPerformed("open"));
        _close.onClick.AddListener(() =>ActionPerformed("close"));
    }

    // Start is called before the first frame update
    void Start()
    {
        _currentState = _lockedState; //starting state
        _currentState.EnterState(this); // setting this as context to the current state
    }

    // Update is called once per frame
    void Update()
    {
        _currentState.UpdateState(this);
    }

    public void SwitchState(DoorBaseState state)
    {
        _currentState = state;
        state.EnterState(this);
    }

    public void ActionPerformed(string action)
    {
        _currentState.ActionPerformed(this, action);
    }
}
