using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.5f, 0, 0);
        if (transform.position.x > 26.0f);
        {
            Destroy(gameObject);
        }
    }
}
