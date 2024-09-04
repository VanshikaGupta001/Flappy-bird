using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovescript : MonoBehaviour
{ public float moveSpeed=5;
public float deadzone = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x< deadzone){
            Destroy(gameObject);
        }
        
    }
}
