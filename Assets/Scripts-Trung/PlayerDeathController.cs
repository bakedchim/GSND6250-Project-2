using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathController : MonoBehaviour
{
    public GameControllerTrung gameController;

    // Update is called once per frame
    void Update()
    {
        // if player y position is less than -2, player dies
        if (transform.position.y < -2)
        {
            gameController.LoseGame();
        }
    }
}
