using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeBullet", 0.2f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeBullet()
    {
        float x = player.transform.position.x + 2.0f;
        float y = player.transform.position.y;
        Instantiate(bullet, new Vector3(x,y,0), Quaternion.identity);
    }
}
