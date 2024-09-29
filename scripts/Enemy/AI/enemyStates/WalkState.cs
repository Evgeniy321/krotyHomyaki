using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : basestate
{
    private Mover move;
    public WalkState(MainEnemyAI mainEnemyAI, Mover move, CharDataSO data)
    {
        this.main = mainEnemyAI;
        this.move = move;
        this.data = data;
    }

    public override void Enter()
    {
        move.Go();
    }

    public override void Exit()
    {
        move.Stop();
    }

    public override void Logic()
    {
        if (this.CheckForEnemy())
            main.ChangeState(main.Attack);
    }
}
