using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        var positionX = Random.Range(-7.91f, 7.91f); // f specifies floatvalue
        var positionY = Random.Range(-4.08f, 4.08f);

        // 2D game requires 3 positions
        var randomPosition = new Vector3(positionX, positionY, 0);

        Instantiate(target, randomPosition, Quaternion.identity);
    }

    
}

