using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionColisions : MonoBehaviour
{
    // Attributs

    private GestionJeu _gestionJeu;
    private bool _touche = false;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_touche)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _gestionJeu.AugmenterPointage();
                _touche = true;
            }
        }
    }
}
