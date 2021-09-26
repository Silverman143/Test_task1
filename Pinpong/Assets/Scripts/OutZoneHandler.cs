using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OutZoneHandler : MonoBehaviour
{
    public UnityEvent _onOutZone;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent<BallController>(out BallController _ball))
        {
            Destroy(_ball.gameObject);
            _onOutZone.Invoke();
        }
    }
}
