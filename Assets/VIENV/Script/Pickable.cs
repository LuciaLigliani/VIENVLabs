using UnityEngine;

public class Pickable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col) {
				if (col.gameObject.tag == "Player") {
						col.gameObject.SendMessage ("Pickup");
						Destroy (gameObject);
				}
		}
}
