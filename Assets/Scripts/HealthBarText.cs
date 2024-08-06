using TMPro;
using UnityEngine;

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;

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
        _healthText.text = $"{health} / {maxhealth}";
    }
}
