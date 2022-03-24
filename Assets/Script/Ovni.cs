using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovni : MonoBehaviour
{
    private float Velo;
    private Vector2 Direcao;
    private GameObject Balao;

    // Start is called before the first frame update
    void Start()
    {
        Velo = 2;
        Direcao = Vector2.zero;
        Balao = GameObject.FindWithTag("Balao");
    }

    // Update is called once per frame
    void Update()
    {
        InputArma();
        transform.Translate(Direcao * Velo * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.down) * 10f, Color.red);
            RaycastHit2D acerto = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 1f);

            if (acerto)
            {
                Destroy(Balao);
            }
        }

    }

    void InputArma()
    {
        Direcao = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Direcao += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Direcao += Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Direcao += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Direcao += Vector2.right;
        }

    }
}

