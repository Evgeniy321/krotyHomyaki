using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : basestate
{
    private Mover move;
    public DeathState(MainEnemyAI mainEnemyAI, Mover move, CharDataSO data)
    {
        this.main = mainEnemyAI;
        this.move = move;
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
