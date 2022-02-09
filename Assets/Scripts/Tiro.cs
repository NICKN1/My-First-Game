using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float velocidade = 10f;

    public Rigidbody2D meuRB;
    // Start is called before the first frame update
    void Start()
    {
        meuRB.velocity = Vector2.up * velocidade; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Evento de trigger com o inimigo
    private void OnTriggerEnter2D(Collider2D collision) {
         //Vai rodar sempre que colidir com alguém
         //Para destruir quem for colidido
         Destroy(collision.gameObject);
         //Para destruir o tiro assim que colidido
         Destroy(gameObject);
    }
}
