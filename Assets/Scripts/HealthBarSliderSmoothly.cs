using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderSmoothly : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    [SerializeField] private Health _player;

    private float targetSliderValue = 1;


    private void OnEnable()
    {
        _player.ChangeHealth += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.ChangeHealth -= OnHealthChanged;
    }

    private void Update()
    {
        _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, targetSliderValue, Time.deltaTime);
    }

    private void OnHealthChanged(float health, float maxhealth)
    {
        targetSliderValue = health / maxhealth;
    }
}
