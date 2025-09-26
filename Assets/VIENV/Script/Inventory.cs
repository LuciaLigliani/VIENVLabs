
using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public int count = 0;
    public int max = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Pickup() {
		Debug.Log ("Got Pickup");
		count++;
	}

	void OnGUI() {
		GUI.Label(new Rect(0,0,Screen.width, Screen.height),"Items in inventory:"+count.ToString()+" / "+max.ToString());
	}

}

