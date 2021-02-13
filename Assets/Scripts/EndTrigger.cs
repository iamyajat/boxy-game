using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        FindObjectOfType<Score>().enabled = false;
        FindObjectOfType<PlayerMovement>().enabled = false;
        gameManager.CompleteLevel();
    }
}
