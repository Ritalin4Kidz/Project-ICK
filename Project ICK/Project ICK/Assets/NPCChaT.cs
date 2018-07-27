using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPCChaT : MonoBehaviour {
    public Canvas dialogueRef;
    public string npcName;

    public bool pickUp;


    public string[] dialogueStrings;
    int lineToSay = 0;
    public void lineToSayIncrement()
    {
        lineToSay++;
        if (lineToSay >= dialogueStrings.Length)
        {
            lineToSay = dialogueStrings.Length - 1;
        }
    }
    public void spawnChatBox()
    {
        Canvas dialogue = Instantiate(dialogueRef);
        dialogue.GetComponent<TextBoxCanvas>().setText(npcName + ":\n" + dialogueStrings[lineToSay]);
        if (pickUp)
        {
            Destroy(this.gameObject);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
