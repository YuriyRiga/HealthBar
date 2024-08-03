using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth;
    [SerializeField] private Slider _healthSlider;

    [SerializeField] private Player _player;

    private void Awake()
    {
        SetHealthSlider();
    }
    
    private void OnEnable()
    {
        _player.ChangeHealth += SetHealthSlider;
    }

    private void OnDisable()
    {
        _player.ChangeHealth -= SetHealthSlider;
    }

    private void SetHealthSlider()
    {
        _currentHealth = _player.Health;
        _maxHealth = _player.MaxHealth;

       _healthSlider.value = _currentHealth / _maxHealth;
    }
}
