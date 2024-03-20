using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarUI : MonoBehaviour
{
    public GameObject principal;
    public GameObject camaras;







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void changePrincipalCamaras(){
        camaras.SetActive(true);
        principal.SetActive(false);
    }
}
