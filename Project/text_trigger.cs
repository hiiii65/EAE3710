using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text_trigger : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject ImageObject;
    public float CountDown; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().gameObject.tag == "CharTag")
        {
            UIObject.SetActive(true);
            ImageObject.SetActive(true);
            Debug.Log("trigged");
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
        ImageObject.SetActive(false);
        Debug.Log("trigged");
    }


}
