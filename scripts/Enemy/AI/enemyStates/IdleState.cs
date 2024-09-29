using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : basestate
{

    public IdleState(MainEnemyAI mainEnemyAI, Mover move, CharDataSO data)
    {
        this.main = mainEnemyAI;
        this.data = data;
    }
    public override void Enter()
    {

    }

    public override void Exit()
    {

    }

    public override void Logic()
    {

    }
}
