using UnityEngine;

public class FlashlightPickup : MonoBehaviour
{
    public GameObject flashlightObject; // HeldFlashlight object
    public Light flashlightLight;       // WhiteLight component

    private void Start()
    {
        if (flashlightObject != null)
            flashlightObject.SetActive(false); // Player starts without the flashlight

        if (flashlightLight != null)
            flashlightLight.enabled = false;   // Light is off at the start
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Enable the held flashlight in hand
            if (flashlightObject != null)
                flashlightObject.SetActive(true);

            // Enable the light in the player's hand
            if (flashlightLight != null)
                flashlightLight.enabled = true;

            // Set hasFlashlight to true and assign the flashlight reference on the player's toggle script
            FlashlightToggle toggle = flashlightObject.GetComponentInChildren<FlashlightToggle>();
            if (toggle != null)
            {
                toggle.hasFlashlight = true;
                toggle.flashlight = flashlightLight;  // 🔥 Add this line!
            }

            // Remove the pickup flashlight from the ground
            Destroy(gameObject);
        }
    }

}
