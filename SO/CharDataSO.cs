using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharecterData", menuName ="Custom/CharecterData")]
public class CharDataSO : ScriptableObject
{
    public float speed;
    public LayerMask enemyLayer;
    public float attackRange;
    public float damage;
    public float HP;
}
