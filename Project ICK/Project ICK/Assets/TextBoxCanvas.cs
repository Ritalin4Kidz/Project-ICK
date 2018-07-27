using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBoxCanvas : MonoBehaviour {
    public Text chatText;

	// Use this for initialization
	void Start () {
		
	}
	public void setText(string textSet)
    {
        chatText.text = textSet;
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<BasicMovement>().setInChat(false);
            Destroy(this.gameObject);
        }
	}
}
