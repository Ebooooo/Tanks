using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float RotateSpeed = 3f;
    public float MoveSpeed = 4f;
    public int player1hp = 1;
    public Bullets1 bulletspawn;
    public Minigun1 MinigunActivePerk;
    public GameObject bulletTurret;
    public GameObject minigunTurret;
    public bool perkMinigunActive;
    public Transform launchPosition;
    public int bulletNumber;
    [SerializeField] private Animator moving;

    public void Start()
    {
        bulletTurret.SetActive(true);
        minigunTurret.SetActive(false);
    }

    IEnumerator isSpeed()
    {
        if(MoveSpeed > 4f)
        {
            yield return new WaitForSeconds(5f);
            MoveSpeed = 4f;
        }
    }
        IEnumerator isMinigun()
    {
        if(perkMinigunActive)
        {
            bulletTurret.SetActive(false);
            minigunTurret.SetActive(true);
            yield return new WaitForSeconds(5f);
            minigunTurret.SetActive(false);
            bulletTurret.SetActive(true);            
            perkMinigunActive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("WallUP"))
        {
            Debug.Log("gracz");
        }
    }

    public void DestroyPlayer()
    {
        if(player1hp <= 0)
        {
            Destroy(gameObject, 0);
        }
    }

    void Update()
    {
        StartCoroutine(isSpeed());
        StartCoroutine(isMinigun());
        DestroyPlayer();
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
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,-MoveSpeed,0) * Time.deltaTime);
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
