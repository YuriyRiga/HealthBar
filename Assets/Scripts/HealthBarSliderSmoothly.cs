using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderSmoothly : MonoBehaviour
{
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth;
    [SerializeField] private Slider _healthSlider;

    [SerializeField] private Player _player;
    
    private void OnEnable()
    {
        _player.ChangeHealth += SetHealthSlider;
    }

    private void OnDisable()
    {
        _player.ChangeHealth -= SetHealthSlider;
    }

    private void Update()
    {
        SetHealthSlider();
    }

    private void SetHealthSlider()
    {
        float currentSliderValue = _healthSlider.value;
        float targetSliderValue = _player.Health / _player.MaxHealth;

        _healthSlider.value = Mathf.MoveTowards(currentSliderValue, targetSliderValue, Time.deltaTime);
    }
}
