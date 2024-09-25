using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public GameControllerTrung gameController;
    // Check for trigger collision
    private void OnTriggerEnter(Collider other) {
        // Check if the object that collided with the goal is the player
        if (other.CompareTag("Player")) {
            gameController.WinGame();
        }
    }
}
