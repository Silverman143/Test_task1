using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorHandler : MonoBehaviour
{
    private SpriteRenderer _sprite;
    private ColorPaletteHandler _palette;
    private Buttons _buttons;
    private GameObject _prefabInstance;
    private DataController _dataController;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _palette = FindObjectOfType<ColorPaletteHandler>();
        _dataController = FindObjectOfType<DataController>();
        _buttons = FindObjectOfType<Buttons>();
        _palette._onSelectedColor.AddListener(Change_color);
        SetCurrentColor();
    }

    private void SetCurrentColor()
    {
        _sprite.color = _dataController.GetBallCurrenColor();
    }

    private void Change_color(Color _newColor)
    {
        _sprite.color = _newColor; 
    }

    public void SaveChanges()
    {
        string _colorHTML = ColorUtility.ToHtmlStringRGB(_sprite.color);
        _dataController.UploadBallColor(_colorHTML);
        _buttons.HideColorPanel();
    }
}
