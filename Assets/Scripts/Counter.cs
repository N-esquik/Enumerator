using TMPro;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private float _interval = 0.5f;
    private float _time = 0f;

    private int _leftButtonMouse = 0;

    private bool _isRuning = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_leftButtonMouse))
        {
            if (_isRuning != true)
            {
                _isRuning = true;
                StartCoroutine(CountUpTime());
            }
            else
            {
                _isRuning = false;
                StopCoroutine(CountUpTime());
            }
        }
    }

    private IEnumerator CountUpTime()
    {
        var wait = new WaitForSecondsRealtime(_interval);

        while (_isRuning)
        {
            _time++;
            _text.text = _time.ToString();

            yield return wait;
        }
    }
}
