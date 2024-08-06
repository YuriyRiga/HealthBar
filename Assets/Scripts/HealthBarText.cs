using TMPro;
using UnityEngine;

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;

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
        _healthText.text = $"{health} / {maxhealth}";
    }
}
