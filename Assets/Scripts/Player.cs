using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health = 100f;
    [SerializeField] private float _maxhealth = 100f;
    [SerializeField] private float _damage = 25f;
    [SerializeField] private Animator _animator;

    public event Action ChangeHealth;
    public float Damage => _damage;
    public float Health => _health;
    public float MaxHealth => _maxhealth;

    public void TakeDamage(float damage)
    {
        if (damage > 0)
        {
            _health -= damage;
        }

        if (_health <= 0)
        {
            _health = 0;
        }

        ChangeHealth.Invoke();
    }

    public void TakeHeal(float heal)
    {
        _health += heal;

        if (_health >= _maxhealth)
        {
            _health = _maxhealth;
        }

        ChangeHealth.Invoke();
    }
}
