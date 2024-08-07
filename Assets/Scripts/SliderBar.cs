using UnityEngine;
using UnityEngine.UI;

public class SliderBar : HealthBar
{
    [SerializeField] private Slider _healthSlider;

    protected override void OnHealthChanged(float health, float maxhealth)
    {
        _healthSlider.value = health / maxhealth;
    }
}
