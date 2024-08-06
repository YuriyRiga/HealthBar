using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.ChangeHealth += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.ChangeHealth -= OnHealthChanged;
    }

    private void OnHealthChanged(float health, float maxhealth)
    {
       _healthSlider.value = health / maxhealth;
    }
}
