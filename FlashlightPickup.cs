using UnityEngine;

public class FlashlightPickup : MonoBehaviour
{
    public GameObject flashlightObject; 
    public Light flashlightLight;       

    private void Start()
    {
        if (flashlightObject != null)
            flashlightObject.SetActive(false); 

        if (flashlightLight != null)
            flashlightLight.enabled = false;   

        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            if (flashlightObject != null)
                flashlightObject.SetActive(true);

            
            if (flashlightLight != null)
                flashlightLight.enabled = true;

            
            FlashlightToggle toggle = flashlightObject.GetComponentInChildren<FlashlightToggle>();
            if (toggle != null)
            {
                toggle.hasFlashlight = true;
                toggle.flashlight = flashlightLight;  

            Destroy(gameObject);
        }
    }

}
