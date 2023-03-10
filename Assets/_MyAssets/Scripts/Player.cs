using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attribue
    [SerializeField] private float _vitesse = 100;
    private Rigidbody _rb;

    private void Start()
    {
        // Position d�part joueur
        this.transform.position = new Vector3(21.3f, 301.735f, -46.62f);
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        // transform.Translate(direction * Time.deltaTime * _vitesse);
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

    public void FinPartie()
    {
        _vitesse = 0;
    }
}
