using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float rotacao1;
    private float rotacao2;

    private bool _estaComEscopo;
    public GameObject escopo;
    public Camera cam;

    private float normalFOV;
    public float escopoFOV;

    public float distanciaDoTiro;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        escopo.SetActive(false);
        normalFOV = cam.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _estaComEscopo = true;
            escopo.SetActive(true);
            cam.fieldOfView = escopoFOV;
        }
            

        if (Input.GetMouseButtonUp(1))
        {
            _estaComEscopo = false;
            escopo.SetActive(false);
            cam.fieldOfView = normalFOV;
        }

        if(_estaComEscopo && Input.GetMouseButtonDown(0))
        {
            Atirar();
        }
            
    }

    private void FixedUpdate()
    {
        rotacao1 += Input.GetAxis("Mouse X");
        rotacao2 += Input.GetAxis("Mouse Y");

        if(!(rotacao1 >= -45 && rotacao1 <= 45))
            rotacao1 -= Input.GetAxis("Mouse X");

        if (!(rotacao2 >= -15 && rotacao2 <= 30))
            rotacao2 -= Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(rotacao2, rotacao1, transform.eulerAngles.z);
    }

    void Atirar()
    {
        RaycastHit hit;

        Debug.DrawLine(cam.transform.position, cam.transform.forward * distanciaDoTiro, Color.red);

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distanciaDoTiro))
        {
            var galinha = hit.transform.gameObject.GetComponent<Galinha>();

            if (galinha != null)
                Game.Instance.MatarGalinha();

        }
    }

}
