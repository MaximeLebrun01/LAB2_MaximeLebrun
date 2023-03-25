using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionJeu : MonoBehaviour
{
    // Attributs
    private int _pointage;

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        _pointage = 0;
        Instructions();
    }

    private static void Instructions()
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (indexScene == 0)
        {
            Debug.Log("*** Course à obstacle *** \n Atteindre la fin du parcours le plus rapidement possible");
            Debug.Log("Chaque obstacle qui sera touché entraînera une pénalité");
        }
    }

    // Méthode plublic
    public void AugmenterPointage()
    {
        _pointage++;
    }

    public int TempPenalite() => _pointage;
}
