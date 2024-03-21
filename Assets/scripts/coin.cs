
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioClip coinsound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(coinsound,transform.position);
            Destroy(gameObject);
            UIManager.instance.UpdateCoins();
        }
    }
}
