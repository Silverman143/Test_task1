using UnityEngine.Events;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorPaletteHandler : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform _rect;
    private Texture2D _imageTexture;
    private Vector2 _currentPos;
    public UnityEvent<Color> _onSelectedColor;

    private float _rectHeight;
    private float _rectWidth;


    private void Start()
    {
        _rect = GetComponent<RectTransform>();
        _imageTexture = GetComponent<Image>().mainTexture as Texture2D;
        _rectHeight = _rect.rect.height;
        _rectWidth = _rect.rect.width;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_rect, eventData.position, Camera.main, out _currentPos);
        Color _newColor = Get_color(_currentPos);
        _onSelectedColor.Invoke(_newColor);

    }

    public void OnDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_rect, eventData.position, Camera.main, out _currentPos);
        Color _newColor = Get_color(_currentPos);
        _onSelectedColor.Invoke(_newColor);
    }

    private Color Get_color(Vector2 _pos)
    {
        _pos += new Vector2(_rectWidth * 0.5f, _rectHeight * 0.5f);
        float _x = Mathf.Clamp(_pos.x / _rectWidth, 0f, 1f);
        float _y = Mathf.Clamp(_pos.y / _rectHeight, 0f, 1f);

        int _textureX = Mathf.RoundToInt(_x * _imageTexture.width);
        int _textureY = Mathf.RoundToInt(_y * _imageTexture.height);

        Color _color = _imageTexture.GetPixel(_textureX, _textureY);
        return _color;
    }
}
