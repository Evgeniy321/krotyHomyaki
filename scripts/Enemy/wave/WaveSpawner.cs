using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private WayPoints waypoints;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private WaveInfoSO waveInfo;
    [SerializeField] private PlayerUI playerUI;
    [SerializeField] private MainEnemyAI[] enemys;
    private float timer;

    private Dictionary<EnemyType, int> enemysDict;

    private void Start()
    {
        timer = 0;
        enemysDict = new Dictionary<EnemyType, int>{
            { EnemyType.imp, 0 },
            { EnemyType.vampyr, 1 },
            { EnemyType.ghost, 2 }
        };
    }

    private void Update()
    {
        if (timer <= 0)
        {
            timer = waveInfo.WaveTime;
            for (int i = 0; i < waveInfo.enemyType.Length; i++)
            {
                for (int j = 0; j < waveInfo.EnemyCountInWave.Length; j++)
                {
                    spawn(waveInfo.enemyType[i]);//huita ne rabotaet
                }

            }
        }
        else
        {
            timer -= Time.deltaTime;
        }
        
    }

    private void spawn(EnemyType enType)
    {
        int index = enemysDict[enType];
        float ti = 0;
        while(ti < waveInfo.enemySpawnCouldown)
        {
            ti += Time.deltaTime;
        }
        Instantiate(enemys[index], spawnPoint).Setup(waypoints, playerUI);
    }
}
