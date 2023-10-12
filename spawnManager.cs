using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public int maxCount;
    public int enemyCount;
    public float spwanTime = 3f;
    public float curTime;
    public Transform[] spawnPoints;
    public bool[] isSpwan;
    public GameObject enemy;

    public static spawnManager _instance;
    // Start is called before the first frame update
    void Start()
    {
        isSpwan = new bool[spawnPoints.Length];
        for (int i = 0; i < isSpwan.Length; i++)
        {
            isSpwan[i] = false;
        }
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(curTime >= spwanTime && enemyCount < maxCount)
        {
            int x = Random.Range(0.spawnPoints.Length);
            SpawnEnemy(x);
        }
        curTime += Time.deltaTime;


    }

    public void SpawnEnemy(int ranNum)
    {
        curTime = 0;
        enemyCount++;
        Instantiate(enemy, spawnPoints[ranNum]);
        isSpwan[ranNum] = true;
    }
}
