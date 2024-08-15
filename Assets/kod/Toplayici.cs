using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject kup;
    int yukseklik;
    void Start()
    {
        kup = GameObject.Find("Cube");
    }

    void Update()
    {
        kup.transform.position = new Vector3 (transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Topla" && other.gameObject.GetComponent<Toplama1>().toplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<Toplama1>().toplandi();
            other.gameObject.GetComponent<Toplama1>().indexBelirle(yukseklik);
            other.gameObject.transform.parent = kup.transform;
        }
    }

    public void yukseklikAzalt()
    {
        yukseklik -= 1;
    }
}
