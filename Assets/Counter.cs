using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _startNumber = 0f;

    public float CurrentNumber;

    public float StartNumber => _startNumber;

    private void Start()
    {
        CurrentNumber = _startNumber;
    }

    public void Increase()
    {
        CurrentNumber++;
    }
}
