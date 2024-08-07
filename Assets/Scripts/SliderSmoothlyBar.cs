using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderSmoothlyBar : HealthBar
{
    [SerializeField] private Slider _healthSlider;

    private float targetSliderValue = 1;
    private Coroutine _smoothFillCoroutine;

    protected override void OnHealthChanged(float health, float maxhealth)
    {
        targetSliderValue = health / maxhealth;

        if (_smoothFillCoroutine != null)
        {
            StopCoroutine(_smoothFillCoroutine);
        }

        _smoothFillCoroutine = StartCoroutine(SmoothFill());
    }

    private IEnumerator SmoothFill()
    {
        while (_healthSlider.value != targetSliderValue)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, targetSliderValue, Time.deltaTime);
            yield return null;
        }

        _smoothFillCoroutine = null;
    }
}
