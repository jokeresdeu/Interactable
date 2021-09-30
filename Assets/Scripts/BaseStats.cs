using System;
using UnityEngine;

[Serializable]
public class BaseStats
{
    [SerializeField] private int _maxHp;
    [SerializeField] private int _damage;
    [SerializeField] private int _armor;

    public int MaxHp => _maxHp;
    public int Damage => _damage;
    public int Armor => _armor;
}