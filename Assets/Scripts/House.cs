using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class House : MonoBehaviour
{
    private SpriteRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    public void InAlarmTransparency()
    {
        _renderer.color = new Color(255f, 255f, 255f, 0.5f);
    }

    public void DefaultTransparency()
    {
        _renderer.color = new Color(255f, 255f, 255f, 1f);
    }
}
