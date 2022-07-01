using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float RotateSpeed = 3f;
    public float MoveSpeed = 0.5f;
    public Bullets1 bulletspawn;
    public Minigun1 MinigunActivePerk;
    public bool perkMinigunActive;
    public Transform launchPosition;
    public int bulletNumber;
    [SerializeField] private Animator moving;

    public void Start()
    {
    }

    IEnumerator isSpeed()
    {
        if(MoveSpeed > 0.5f)
        {
            yield return new WaitForSeconds(5f);
            MoveSpeed = 0.5f;
        }
    }
        IEnumerator isMinigun()
    {
        if(perkMinigunActive)
        {
            yield return new WaitForSeconds(5f);
            perkMinigunActive = false;
        }
    }
    void Update()
    {
        StartCoroutine(isSpeed());
        StartCoroutine(isMinigun());
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f,0f,0.1f);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f,0f,-0.1f);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,MoveSpeed,0) * Time.deltaTime);
        }
        if(Input.GetKeyDown("e") && bulletNumber <= 3 && !perkMinigunActive)
        {
            bulletNumber++;
            Instantiate(bulletspawn, launchPosition.position, launchPosition.transform.rotation);
        }
        else if(Input.GetKeyDown("e") && perkMinigunActive)
        {
            Instantiate(MinigunActivePerk, launchPosition.position, launchPosition.transform.rotation);
        }
    }


}
