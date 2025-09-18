using UnityEngine;

public class Inventory : MonoBehaviour
{
    public AudioClip pickupSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Pickup() {
		AudioSource.PlayClipAtPoint (pickupSound, transform.position);
	}
}
