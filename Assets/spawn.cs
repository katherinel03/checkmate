using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject card;
    public int xpos;
    // Start is called before the first frame update
    void Start()
    {
        xpos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) {
            Debug.Log("hi");
            Vector2 myvec = new Vector2(xpos, 0);
            GameObject game_card = Instantiate(card);
            game_card.transform.position = myvec;
            xpos += 2;
        }
    }
}
