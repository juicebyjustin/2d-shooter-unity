using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;
    
    public GameObject target;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 5f, 5f);
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

        IncrementScore();
    }

    public void IncrementScore()
    {
        score++;
        print(score);

        scoreText.text = score.ToString();
    }
}

