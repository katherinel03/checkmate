using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory : MonoBehaviour
{
    public GameObject parent;
    public int location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver() {
        if(!Input.GetMouseButtonDown(0)) return;
        GameObject.Find("Spawner").SendMessage("receive", this.location);
        Object.Destroy(this.gameObject);
    }

    void tellMeNum(int i) {
        this.location = i;
    }
}
