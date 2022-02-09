using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorInimigos : MonoBehaviour
{
    //Método para criar os Inimigos
    public GameObject Inimigo;

    //Onde Criar o Objeto
    public float xMax = 8.22f;
    public float xMin = -8.22f;
    public float yMax = 9.50f;
    public float yMin = 5.60f;

    //Tempo de espera para criar os inimigos
    public float espera = 3f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //Para fazer a espera acabar afim de resetar esse cooldown
        espera -= Time.deltaTime;
        
        if(espera <=0)
        {
            //Variável para criar a posição de nascimento do inimigo
            //Deve ser dentro dos Eixos X e Y min e max, e de forma randomica
            Vector3 posicao = new Vector3(Random.Range(xMax, xMin), Random.Range(yMax, yMin));

            //Para criar o inimigo       Quaternion necessário para a Unity lidar com ângulo
            Instantiate(Inimigo, posicao, Quaternion.identity);

            //resetando a espera
            espera = 3;
        }
    }
}
