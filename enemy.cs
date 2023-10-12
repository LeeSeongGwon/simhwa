using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int hp = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(9f,9f);
        float y = Random.Range(-4.5f, 4.5f);
        transform.position = new Vector3(x,y,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.05f, 0f, 0f);
        if(hp <= 0)
        {
            spawnManager._instance.enemyCount--;
            Destroy(this.gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        hp = hp - damage;
    }
}
