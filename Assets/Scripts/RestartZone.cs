using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartZone : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
