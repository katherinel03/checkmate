using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject card;
    int xpos;
    bool[] taken = {false, false, false};

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) {
            for(int i = 0; i < 3; i++) {
                if(taken[i]) continue;
                Vector2 myvec = new Vector2(-4+4*i, 0);
                GameObject game_card = Instantiate(card);
                game_card.SendMessage("tellMeNum", i);
                game_card.transform.position = myvec;
                taken[i] = true;
                break;
            }
        }
    }

    public void receive(int loc) {
        Debug.Log("message came");
        taken[loc] = false;
    }
}
