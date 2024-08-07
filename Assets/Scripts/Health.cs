using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health = 100f;
    [SerializeField] private float _maxhealth = 100f;

    public event Action<float,float> ChangeHealth;

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

        ChangeHealth.Invoke(_health,_maxhealth);
    }

    public void TakeHeal(float heal)
    {
        if (heal > 0)
        {
            _health += heal;
        }

        if (_health >= _maxhealth)
        {
            _health = _maxhealth;
        }

        ChangeHealth.Invoke(_health, _maxhealth);
    }
}
