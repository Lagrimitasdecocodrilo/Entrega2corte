using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour { 
    public GameObject CharacterPrincipal;
    public float velocidad = 20f;
    public GameObject bala;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //transform.position += Vector3.forward * Time.deltaTime;
        if(Input.GetKey(KeyCode.UpArrow)){
            Transform.position += Vector3.forward * Time.deltaTime;
        }
        //Cuando presione la tecla DOWN el carro avanza hacia atrás o en reversa
        if (Input.GetKey(KeyCode.DownArrow)){
            Transform.position -= Vector3.forward * Time.deltaTime;
        }
        //cuando presione la tecla RIGHT
        if (Input.GetKey(KeyCode.RightArrow)){
            //Transform.position += Vector3.right * Time.deltaTime;
            transform.eulerAngles += new Vector3(0, velocidad * Time.deltaTime, 0);
        }
        //cuando presione la tecla LEFT
        if (Input.GetKey(KeyCode.LeftArrow)){
            //Transform.position -= Vector3.right * Time.deltaTime;
            transform.eulerAngles -= new Vector3(0, velocidad * Time.deltaTime, 0);
        }

    }
}