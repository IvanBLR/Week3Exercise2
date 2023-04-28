using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer _renderer;
    private Color _originalColor;


    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _originalColor = _renderer.material.color;
    }

    private void OnMouseEnter()
    {
        float r = _originalColor.r;
        float g = _originalColor.g;
        float b = _originalColor.b;
        if (r < 230 && g < 230 && b < 230)
            _renderer.material.color = new Color(r + 10, g + 10, b + 10);
        else
            _renderer.material.color = Color.gray;
    }

    private void OnMouseExit()
    {
        _renderer.material.color = _originalColor;
    }
}
