using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    //Saber quem é meu rigidbody
    public Rigidbody2D meuRB;

    //Definindo a velocidade dele
    public float velocidade = 2f;

    //Para linkar com a explosão
    public GameObject minhaExplosão;
   
    void Start()
    {
        //Quando você iniciar, é dado uma velocidade ao rigidbody
        //A velocidade do meu rigidbody é 1 para baixo (0 no X e -1 no Y)
        //Se multiplicar pela a velocidade fixada no metodo, o resultado será o valor fixado 
        meuRB.velocity = Vector2.down * velocidade;
        
    }


    void Update()
    {
        
    }

    //Criando a Explosão, quando for destruído
    private void OnDestroy() {
        //Cria uma variável pra explosão, para após ser destruida
        GameObject explosao = Instantiate(minhaExplosão, transform.position, transform.rotation);
        Destroy(explosao, 0.5f);
    }
}
