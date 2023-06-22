using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour
{
    public int Respawn;
    //start is called before the first frame update
    void Start()
    {

    }

    //update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if object collides with player, reload the scene to restart
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Respawn);
        }
    }}