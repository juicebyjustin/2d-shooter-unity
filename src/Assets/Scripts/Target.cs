using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    /*void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        //Destroy(gameObject);
    }*/
    
    private void OnMouseDown()
    {
        print("mouse");
        Destroy(gameObject);
        gameManager.IncrementScore();
        //EventSystem.current.SetSelectedGameObject(this.gameObject);
    }
}
