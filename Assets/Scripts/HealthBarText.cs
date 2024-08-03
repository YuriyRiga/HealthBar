using TMPro;
using UnityEngine;

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth;
    [SerializeField] private TextMeshProUGUI _healthText;

    [SerializeField] private Player _player;

    private void Awake()
    {
        SetHealthText();
    }

    private void OnEnable()
    {
        _player.ChangeHealth += SetHealthText;
    }

    private void OnDisable()
    {
        _player.ChangeHealth -= SetHealthText;
    }

    private void SetHealthText()
    {
        _currentHealth = _player.Health;
        _maxHealth = _player.MaxHealth;

        _healthText.text = $"{_currentHealth} / {_maxHealth}";
    }
}
