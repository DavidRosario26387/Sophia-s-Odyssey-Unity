
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class obstacle : MonoBehaviour
{
    public GameObject CharModel;
    public AudioSource crashThud;
    public GameObject dist;
    public GameObject level;
    public GameObject panel;
    
    
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "qwert")
        {   
            crashThud.Play();
            
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            this.gameObject.GetComponent<playermovement>().enabled = false;
            this.gameObject.GetComponent<Animator>().Play("Stumble Backwards");
            dist.GetComponent<distance>().enabled = false;
            level.GetComponent<generatelevel>().enabled=false;
            panel.SetActive(true);
        }
    }
}
