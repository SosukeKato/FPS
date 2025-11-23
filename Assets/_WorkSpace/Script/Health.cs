using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    public int _health;
    [SerializeField]
    int _maxHealth;

    bool _isDeath;
    public void HP()
    {
        if (_health >= _maxHealth)
        {
            _health = _maxHealth;
        }
        else if (_health <= 0)
        {
            _isDeath = true;
        }
    }
}
