using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Alarm : MonoBehaviour
{
    [SerializeField] private UnityEvent _entered;
    [SerializeField] private UnityEvent _leaved;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _entered.Invoke();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _leaved.Invoke();
        }
    }
}
