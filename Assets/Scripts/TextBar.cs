using TMPro;
using UnityEngine;

public class TextBar : HealthBar
{ 
    [SerializeField] private TextMeshProUGUI _healthText;

    protected override void OnHealthChanged(float health, float maxhealth)
    {
        _healthText.text = $"{health} / {maxhealth}";
    }
}
