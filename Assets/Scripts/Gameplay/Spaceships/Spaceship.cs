using System;
using Gameplay.ShipControllers;
using Gameplay.ShipSystems;
using Gameplay.Weapons;
using UnityEngine;

namespace Gameplay.Spaceships
{
    public class Spaceship : MonoBehaviour, ISpaceship, IDamagable
    {
        [SerializeField]
        private ShipController _shipController;
    
        [SerializeField]
        private MovementSystem _movementSystem;
    
        [SerializeField]
        private WeaponSystem _weaponSystem;

        [SerializeField]
        private StrenghtSystem _strenghtSystem;

        [SerializeField]
        private BonusSystem _bonusSystem;

        [SerializeField]
        private UnitBattleIdentity _battleIdentity;

        public MovementSystem MovementSystem => _movementSystem;
        public BonusSystem BonusSystem => _bonusSystem;
        public StrenghtSystem StrenghtSystem => _strenghtSystem;
        public WeaponSystem WeaponSystem => _weaponSystem;

        

        public UnitBattleIdentity BattleIdentity => _battleIdentity;

        private void Start()
        {
            _shipController.Init(this);
            _weaponSystem.Init(_battleIdentity);
        }

        public void ApplyDamage(IDamageDealer damageDealer)
        {
            
            _strenghtSystem.ApplyShipState(damageDealer.Damage);
            

            if (_strenghtSystem.DestroyShip() == true )
            {
                _bonusSystem.GenerateBonus();
                DestroyShip();
            }
            else return;
            
        }

        public void DestroyShip() 
        {
            Destroy(gameObject);
        }

    }
}
