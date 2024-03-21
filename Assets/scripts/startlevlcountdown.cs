
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startlevlcountdown : MonoBehaviour
{
    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject countdowngo;
    public GameObject fadein;
    public AudioSource readyFX;
    public AudioSource goFX;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(0.3f);
        countdown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(0.3f);
        countdown3.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        countdown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(0.3f);
        countdown2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        countdown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(0.3f);
        countdown1.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        countdowngo.SetActive(true);
        goFX.Play();
        yield return new WaitForSeconds(0.3f);
        countdowngo.SetActive(false);
    }
    // Update is called once per frame
    
}
