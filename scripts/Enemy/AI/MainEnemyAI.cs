using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class MainEnemyAI : MonoBehaviour
{
    [SerializeField] private CharDataSO data;
    private PlayerUI playerUI;
    private Mover moveSystem;


    private WalkState walk;
    public WalkState Walk => walk;

    private DeathState death;
    public DeathState Death => death;

    private AtackState attack;
    public AtackState Attack => attack;


    private basestate curState;

    public void Setup(WayPoints newway, PlayerUI newPlayerUI)
    {
        moveSystem = GetComponent<Mover>();
        moveSystem.Setup(newway, data.speed);
        playerUI = newPlayerUI;
        walk = new WalkState(this, moveSystem, data);
        death = new DeathState(this, moveSystem, data);
        attack = new AtackState(this, data);
        ChangeState(walk);
    }
    private void Update()
    {
        if (curState != null)
            curState.Logic();
    }

    public void ChangeState(basestate newstate)
    {
        if (curState != null)
            curState.Exit();
        curState = newstate;
        newstate.Enter();
    }
}
