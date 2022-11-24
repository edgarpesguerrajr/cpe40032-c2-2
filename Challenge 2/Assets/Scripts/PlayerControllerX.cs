using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fullCooldown = 0.5f;
    private float currentCooldown = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog if cooldown has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > currentCooldown)
        {
            currentCooldown = Time.time + fullCooldown;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    }

}
