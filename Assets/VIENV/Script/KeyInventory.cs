using UnityEngine;
using System.Collections;

/// <summary>
/// Keeps track of the player's possession of a key
/// </summary>
public class KeyInventory : Inventory {

    // Texture representing the presence of a Key in the inventory
    public Texture aTexture;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Return true if key in possession
    public bool HasKey() {
        return (count > 0); // Assuming any object in inventory is a key!
    }
	


	void OnGUI() {
        // Draw key icon if key in possession
		if (HasKey()) {
			GUI.DrawTexture (new Rect (10, 10, 100, 100), aTexture, ScaleMode.ScaleAndCrop, true, 1.0f);
		}
	}
}
