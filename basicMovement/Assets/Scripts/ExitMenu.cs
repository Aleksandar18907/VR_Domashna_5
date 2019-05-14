using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject can;
    public GameObject move;
    public GameObject pointscan;
    public GameObject dotcan;
    void Start()
    {

        StartCoroutine(Example());
   }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(5f);
        can.SetActive(true);
        pointscan.SetActive(false);
        dotcan.SetActive(false);
        move.GetComponent<charControl>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
}
