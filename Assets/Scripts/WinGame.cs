using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject winGame;
    public GameObject textMissing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (GameObject.FindWithTag("Collectible") == null)
            {
                Debug.Log("You Win!");
                winGame.SetActive(true);
            }
            else
            {
                Debug.Log("There are Collectibles missing!");
                textMissing.SetActive(true);
            }

        }
    }
}
