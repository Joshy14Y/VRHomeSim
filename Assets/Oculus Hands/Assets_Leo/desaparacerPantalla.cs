using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparacerPantalla : MonoBehaviour
{
    public GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posY = transform.position.y;

        if (posY > 450 ){
            screen.SetActive(false);
        }else if (posY < 450) {
            screen.SetActive(true);
        }
    }


}
