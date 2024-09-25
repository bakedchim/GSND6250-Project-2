using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushTrap : MonoBehaviour
{
    public float trapPosMove = 3f;
    public float trapSpeed = 10f;
    public string trapExtendDirection = "y";
    public float trapInterval = 3f;
    private float originalPosX;
    private float originalPosY;
    private float originalPosZ;

    // Start is called before the first frame update
    void Start()
    {
        // Save the original position of the trap
        originalPosX = transform.position.x;
        originalPosY = transform.position.y;
        originalPosZ = transform.position.z;
        // Start the coroutine to move the trap
        StartCoroutine(MoveTrap());
    }

    private IEnumerator MoveTrap()
    {
        // Move the trap up and down
        while (true)
        {
            // Move the trap according to the direction and speed
            if (trapExtendDirection == "y")
            {
                while (transform.position.y < originalPosY + trapPosMove)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + trapSpeed * Time.deltaTime, transform.position.z);
                    yield return null;
                }
            }
            else if (trapExtendDirection == "x")
            {
                while (transform.position.x < originalPosX + trapPosMove)
                {
                    transform.position = new Vector3(transform.position.x + trapSpeed * Time.deltaTime, transform.position.y, transform.position.z);
                    yield return null;
                }
            }
            else if (trapExtendDirection == "z")
            {
                while (transform.position.z < originalPosZ + trapPosMove)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + trapSpeed * Time.deltaTime);
                    yield return null;
                }
            }
            // Wait for the trapInterval
            yield return new WaitForSeconds(trapInterval);
            // Move the trap back to its original position
            if (trapExtendDirection == "y")
            {
                while (transform.position.y > originalPosY)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - trapSpeed * Time.deltaTime, transform.position.z);
                    yield return null;
                }
                transform.position = new Vector3(transform.position.x, originalPosY, transform.position.z);
            }
            else if (trapExtendDirection == "x")
            {
                while (transform.position.x > originalPosX)
                {
                    transform.position = new Vector3(transform.position.x - trapSpeed * Time.deltaTime, transform.position.y, transform.position.z);
                    yield return null;
                }
                transform.position = new Vector3(originalPosX, transform.position.y, transform.position.z);
            }
            else if (trapExtendDirection == "z")
            {
                while (transform.position.z > originalPosZ)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - trapSpeed * Time.deltaTime);
                    yield return null;
                }
                transform.position = new Vector3(transform.position.x, transform.position.y, originalPosZ);
            }
            // Wait for the trapInterval
            yield return new WaitForSeconds(trapInterval);
        }
    }
}
