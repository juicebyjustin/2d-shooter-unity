using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int winningScore = 10;
    bool win = false;
    
    public GameObject target;
    public Text scoreText;
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(win){
            winText.SetActive(true);

            CancelInvoke("Spawn");
        }
        
        if(Input.GetMouseButtonDown(0) && score > 0)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    void Spawn()
    {
        if(win) return;

        var positionX = Random.Range(-7.91f, 7.91f); // f specifies floatvalue
        var positionY = Random.Range(-4.08f, 4.08f);

        // 2D game requires 3 positions
        var randomPosition = new Vector3(positionX, positionY, 0);

        Instantiate(target, randomPosition, Quaternion.identity);

      //  IncrementScore();
    }

    public void IncrementScore()
    {
        score++;

        if(score >= winningScore)
        {
            win = true;
        }

        print(score);

        scoreText.text = score.ToString();
    }
}

