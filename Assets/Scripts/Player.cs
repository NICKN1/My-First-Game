using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float velocidade = 6f;

    //Para linkar com o tiro
    public GameObject tiroInicial;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá");
    }

    // Update is called once per frame
    void Update()
    {   
        //metodo para salvar a posição do objeto
        Vector3 movimento = transform.position;
        //Comando para controlar o player
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //Mudando a posição do objeto dentro da Unity
            //Criando uma nova posição dentro do vetor de três direções, dar valor de x, y e z
            //                                  Aqui pegasse a posição atual do x, y e z
            //transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
            //                                        A taxa de movimento é de +0.01 float (f)
            
            //chamando o método para criar o movimento no eixo X do objeto
            // Time.deltaTime >>>>Isto garante a mesma velocidade do objeto indepedente do fps de cada cpu
            //movimento.x += velocidade * Time.deltaTime;

            // Input.GetAxis("Horizontal")>>>>> usa parâmetros da Unity para usar as teclas A e D assim com as Setas
            //movimento.x += Input.GetAxis("Horizontal") * velocidade * Time.deltaTime; 
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            
            //movimento.x += Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;                                                
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            
            //movimento.y += Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
                                                  
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            
            //movimento.y += Input.GetAxis("Vertical") * velocidade * Time.deltaTime;                                                
        } 
        movimento.x += Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        movimento.y += Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        transform.position = movimento;

        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(tiroInicial, transform.position, transform.rotation);
        }
     }
}

