using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 3.0f;
    public float entradaHorizontal;
    public float entradaVertical;


    void Start()
    {
        Debug.Log("Start de " + this.name);
        velocidade = 3.0f;
        transform.position = new Vector3(9.97f, -3.96f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    private void Movimento()
    {

        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * velocidade * entradaHorizontal);

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * velocidade * entradaVertical);

    }
}
