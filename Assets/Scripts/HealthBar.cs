using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;

    protected virtual void OnEnable()
    {
        _health.ChangeHealth += OnHealthChanged;
    }

    protected virtual void OnDisable()
    {
        _health.ChangeHealth -= OnHealthChanged;
    }

    protected abstract void OnHealthChanged(float health, float maxhealth);
}

