using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    [SerializeField] private Health _player;

    private void OnEnable()
    {
        _player.ChangeHealth += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.ChangeHealth -= OnHealthChanged;
    }

    private void OnHealthChanged(float health, float maxhealth)
    {
       _healthSlider.value = health / maxhealth;
    }
}
