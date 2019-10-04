using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picar : MonoBehaviour
{

    public GameObject diamante, coin, anvil;
    /*public float forceFactor = 10,
                 speed = 2,
                 amplitude = 90;
    */

    // Use this for initialization
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    IEnumerator esperar()
    {
        yield return new WaitForSeconds(3f);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "ColliderBloquePicable")
        {
            /*
            float counter = 0;
            
            pico.AddForce(((cubo.transform.position - pico.transform.position) * forceFactor * Time.smoothDeltaTime));
            while(Vector3.Distance(pico.transform.position, col.transform.parent.transform.position) > 7f)
                pico.transform.position = Vector3.MoveTowards(pico.transform.position, col.transform.parent.transform.position, 0.1f * Time.deltaTime);
            
            while(counter < 2)
            {
                counter += Time.deltaTime;
                pico.transform.position = Vector3.Lerp(pico.transform.position, 
                                                    col.transform.parent.transform.position, counter / 2);
            }

            // Rotacion

            float passedTime = 0f;
            float val = 0;

            while (passedTime < 2)
            {
                val = (val + (Time.deltaTime * speed)) % (2 * Mathf.PI);
                pico.transform.rotation = Quaternion.AngleAxis(Mathf.Sin(val) * amplitude, Vector3.left);
                passedTime += Time.deltaTime;
            }
            

            //pico.transform.position = transform.position;
            //pico.transform.rotation = transform.rotation;
            */

            col.gameObject.SetActive(false);

            GameObject nuevoDiamante = Instantiate(diamante, new Vector3(-0.05f, -0.15f, 0.075f), new Quaternion()) as GameObject;
            nuevoDiamante.transform.SetParent(col.transform.parent.transform, false);
            
            Destroy(col.gameObject);
        }
    }
}

