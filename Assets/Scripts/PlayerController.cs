using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text text;
    Rigidbody rb;
    int cont = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetContText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            RestartGame();

        if (transform.position.y < -10f)
        {
            Debug.Log("You Lost");
            RestartGame();
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(moveHorizontal, 0f, moveVertical);

        rb.AddForce(vector * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            cont++;
            SetContText();
        }
    }

    void SetContText()
    {
        text.text = "Collectibles: " + cont;
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
