using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _grass;
    [SerializeField]
    private GameObject[] _bridge;

    private Color _grassColor;
    private Color _bridgeColor;

    //private bool _isRecoloring;
    private void Start()
    {
        _bridgeColor = _bridge[0].GetComponent<Renderer>().sharedMaterial.color;
        _grassColor = _grass[0].GetComponent<Renderer>().sharedMaterial.color;
    }
    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            var hitObject = hitInfo.collider.gameObject;
            hitObject.GetComponent<Renderer>().material.color = Color.black;

           // _isRecoloring = true;
        }
        else
        {
            for (int i = 0; i <  _grass.Length; i++)
            {
                _grass[i].GetComponent<Renderer>().material.color = _grassColor;
            }
        }

      // if (_isRecoloring)
      // {
      //     for (int i = 0; i < _bridge.Length; i++)
      //         _bridge[i].GetComponent<Renderer>().material.color = _bridgeColor;
      //     for (int j = 0; j < _grass.Length; j++)
      //         _grass[j].GetComponent<Renderer>().material.color = _grassColor;
      //
      //     _isRecoloring = false;
      // }

    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
}
