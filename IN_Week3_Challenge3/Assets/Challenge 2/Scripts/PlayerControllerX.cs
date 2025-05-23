using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool isCoolDown;
    private float coolDown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isCoolDown == false)
            {
                SpawnDog();
                StartCoroutine(CoolDown());
            }
        }
    }
        IEnumerator CoolDown( )
    {
        isCoolDown = true;
        yield return new WaitForSeconds(coolDown);
        isCoolDown = false;
    }
    private void SpawnDog()
    {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
               
}
