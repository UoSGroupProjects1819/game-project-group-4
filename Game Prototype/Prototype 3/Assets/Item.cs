using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    bool collision = false;

    bool collected = false;

    void Update()
    {

    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if (!collision)
        {
            collision = true;
        }
    }
}
