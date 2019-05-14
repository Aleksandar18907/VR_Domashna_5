using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour
{

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public GameObject pointscan;
    public GameObject dotcan;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }
        StartCoroutine(Example());

    }
    public GameObject can;
    public GameObject move;
    IEnumerator Example()
    {
        yield return new WaitForSeconds(5f);
        pointscan.SetActive(false);
        dotcan.SetActive(false);
        can.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}