using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "WaveInfo", menuName = "Custom/WaveInfo")]
public class WaveInfoSO : ScriptableObject
{
    public EnemyType[] enemyType;
    public int[] EnemyCountInWave;
    public float WaveTime;
    public float enemySpawnCouldown;

}

public enum EnemyType{
    imp,
    vampyr,
    ghost
}
