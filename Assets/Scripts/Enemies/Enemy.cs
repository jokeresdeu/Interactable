using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

namespace Enemies
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Sprite _gameSprite;
        [SerializeField] private Slider _hpBar;
        [SerializeField] private BaseStats _baseStats;

        private int _currentHp;
        protected int CurrentHp
        {
            get => _currentHp;
            set
            {
                _currentHp = value;
                _hpBar.value = value;
            }
        }

        protected void Start()
        {
            _hpBar.maxValue = _baseStats.MaxHp;
            CurrentHp = _baseStats.MaxHp;
        }

        public void TakeDamage(int damage)
        {
            if (CurrentHp - damage <= 0)
            {
                Death();
                return;
            }

            CurrentHp -= damage;
        }

        protected virtual void Death()
        {
            
        }
    }
}