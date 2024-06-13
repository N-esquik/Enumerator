using TMPro;
using System.Collections;
using UnityEngine;

public class Enumerator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private float _interval = 0.5f;
    private float _time = 0f;
    private bool _isRuning = false;

    private void Start()
    {
        StartCoroutine(GetTime());  
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isRuning = !_isRuning;
        }
    }

    private IEnumerator GetTime()
    {
        while (true)
        {
            if (_isRuning)
            {
                _time++;
                _text.text = _time.ToString();
            }

            yield return new WaitForSecondsRealtime(_interval);
        }
    }
}
