using System.Collections.Generic;
using Gameplay.Weapons;
using UnityEngine;
using System.Linq;

namespace Gameplay.ShipSystems
{
    public class WeaponSystem : MonoBehaviour
    {

        [SerializeField]
        private List<Weapon> _weapons;
        

        public void Init(UnitBattleIdentity battleIdentity)
        {
            _weapons.ForEach(w => w.Init(battleIdentity));
        }
        
        
        public void TriggerFire()
        {
            _weapons.ForEach(w => w.TriggerFire());
        }
        public void ApplyRateOffire(float increase)
        {
            _weapons.ForEach(w => w.IncreaseCooldown(increase));
        }
        public float ApplyRateText()
        {
            float rate = _weapons[0].ApplyRate();
            return rate;
        }

    }
}
