using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplama1 : MonoBehaviour
{
    bool kupDurumu;
    int i;
    public Toplayici toplayici;
    
    void Start()
    {
        kupDurumu = false;
    }

    void Update()
    {
        if (kupDurumu == true && transform.parent != null) { transform.localPosition = new Vector3(0, -i, 0); }
        
    }

    public bool toplandiMi()
    {
        return kupDurumu;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Engel")
        {
            toplayici.yukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public void toplandi() { kupDurumu = true; }
    public void indexBelirle(int index) { this.i = index; }
}
