using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class CounterView : MonoBehaviour
{
    [SerializeField] private float delay;
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _counterText;

    private Coroutine _coroutine;

    private void Start()
    {
        _counterText.text = _counter.StartNumber.ToString("");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_coroutine != null)
                Stop();
            else
                _coroutine = StartCoroutine(CountingDown());
        }

        Display();
    }

    private void Stop()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private void Display()
    {
        float amount = _counter.CurrentNumber;
        _counterText.text = amount.ToString();
    }

    private IEnumerator CountingDown()
    {
        var wait = new WaitForSeconds(delay);

        while (enabled)
        {
            _counter.Increase();
            yield return wait;
        }
    }
}
