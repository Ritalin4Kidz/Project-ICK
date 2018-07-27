using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {
    public float walkPower;
    bool inChat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    public void setInChat(bool a_chat)
    {
        inChat = a_chat;
    }
	void Update () {
        if (!inChat)
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.position += this.transform.forward * Time.deltaTime * walkPower;
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.position -= this.transform.forward * Time.deltaTime * walkPower;
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.position -= this.transform.right * Time.deltaTime * walkPower;
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += this.transform.right * Time.deltaTime * walkPower;
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 1.0f);
                for (int i = 0; i < hitColliders.Length; i++)
                {
                    if (hitColliders[i].gameObject.CompareTag("npc"))
                    {
                        hitColliders[i].gameObject.GetComponent<NPCChaT>().spawnChatBox();
                        hitColliders[i].gameObject.GetComponent<NPCChaT>().lineToSayIncrement();
                        inChat = true;
                        break;
                    }
                }
            }
        }
    }
}
