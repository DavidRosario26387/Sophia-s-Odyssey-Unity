
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class distance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay=0.35f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());

        }
    }
    IEnumerator AddingDis()
    {
        disRun +=1;
        disDisplay.GetComponent<Text>().text ="Distance: " + disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
