using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    [SerializeField]
    private float ileriHiz;
    [SerializeField]
    private float sagSolHiz;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel") { audioSource.Play(); }
    }
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal") * sagSolHiz * Time.deltaTime;
        this.transform.Translate(yatay, 0, ileriHiz * Time.deltaTime);
    }
}
