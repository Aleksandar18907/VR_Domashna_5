using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCamera;
    public GameObject gunFloor;
    public GameObject gunPlayer;
    public TextMeshPro points;
    private int pts=0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "Teleport")
            {
                transform.position = new Vector3(0, 554, 0);
            }
            if (hit.transform.name== "SciFiGun_Specular")
            {
                gunFloor.SetActive(false);
                gunPlayer.SetActive(true);
            }
            if (hit.transform.name == "Military_target" && gunPlayer.active)
            {
                pts += 10;
                points.text = "\n Points: " + pts.ToString();
            }
        }

    }
}