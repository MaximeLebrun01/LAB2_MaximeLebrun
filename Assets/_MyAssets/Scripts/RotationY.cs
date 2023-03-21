using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotationY : MonoBehaviour
{
    //Attribue
    [SerializeField] private float _vitesseRotationY = 0.5f;
    private Rigidbody lame;
    // Update is called once per frame
    private void Start()
    {
        Vector3 position = lame.GetComponent<Renderer>().bounds.center;
    }
    
    void Update()
    {
        lame.transform.RotateAround(transform.position, Vector3.right, _vitesseRotationY * Time.deltaTime);
    }
}
