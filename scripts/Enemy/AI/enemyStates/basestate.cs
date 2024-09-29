using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class basestate
{
    protected MainEnemyAI main;
    protected CharDataSO data;
    public abstract void Enter();
    public abstract void Exit();
    public abstract void Logic();

    protected bool CheckForEnemy()
    {
        return Physics2D.OverlapCircle(main.transform.position, data.attackRange, data.enemyLayer);
    }

}
