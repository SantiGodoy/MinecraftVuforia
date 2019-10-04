using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Hornear : MonoBehaviour
{
    //public GameObject hornoOn;
    //public GameObject hornoOff;
    public GameObject oro;
    public GameObject hierro;
    public int tiempoCoccion;

    // Use this for initialization
    void Start()
    {
        transform.GetChild(1).transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "ColliderBloqueHorneable")
        {
            Transform bloque = col.transform.GetChild(0);

            /*
            transform.GetChild(0).transform.gameObject.SetActive(false);
            transform.GetChild(1).transform.gameObject.SetActive(true);
            */

            bloque.gameObject.SetActive(false);

            if (bloque.transform.tag == "BloqueHierro")
            {
                GameObject nuevoHierro = Instantiate(hierro, new Vector3(-0.05f, -0.15f, 0.075f), new Quaternion()) as GameObject;
                nuevoHierro.transform.SetParent(col.transform.parent.transform, false);

            }
            else if (bloque.transform.tag == "BloqueOro")
            {
                GameObject nuevoOro = Instantiate(oro, new Vector3(-0.05f, -0.15f, 0.075f), new Quaternion()) as GameObject;
                nuevoOro.transform.SetParent(col.transform.parent.transform, false);
            }

            /*
            transform.GetChild(1).transform.gameObject.SetActive(false);
            transform.GetChild(0).transform.gameObject.SetActive(true);
            */

            Destroy(col.gameObject);
        }
    }
}

