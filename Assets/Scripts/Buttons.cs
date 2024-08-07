using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private Button _takeDamage;
    [SerializeField] private Button _takeHeal;
    [SerializeField] private Health _health;

    private float _damage = 10f;
    private float _heal = 25f;

    private void Awake()
    {
        _takeDamage.onClick.AddListener(TakeDamage);
        _takeHeal.onClick.AddListener(TakeHeal);
    }

    private void TakeDamage()
    {
        _health.TakeDamage(_damage);
    }

    private void TakeHeal()
    {
        _health.TakeHeal(_heal);
    }
}
