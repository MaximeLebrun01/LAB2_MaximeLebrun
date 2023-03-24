using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    // Attributs

    private GestionJeu _temp;
    private Player _player;

    private void Start()
    {
        _temp = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (indexScene == 1)
        {
            if (collision.gameObject.tag == "Player")
            {
                int erreurs = _temp.TempPenalite();
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("Fin de la partie \n Votre temp est de : " + Time.time + " secondes + " + erreurs + " secondes de pénalités");
                float tempFinal = Time.time + erreurs;
                Debug.Log("Votre temp final est donc de : " + tempFinal);
                _player.FinPartie();
            }
        }
        else
        {
            // Charger next scene
            SceneManager.LoadScene(indexScene + 1);
        }
    }
}
