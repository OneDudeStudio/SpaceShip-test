using System.Collections;
using System.Collections.Generic;
using Gameplay.Weapons.Projectiles;
using UnityEngine;


namespace Gameplay.ShipSystems
{
    public class RateFireBonus : MonoBehaviour
    {
        [SerializeField] private float _speed;

        [SerializeField] private float _applyRate;

        [SerializeField]
        private WeaponSystem _weaponSystem;

        private void Update()
        {
            Move(_speed);
        }
        protected void Move(float speed)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }


        private void OnCollisionEnter2D(Collision2D other)
        {
            var bonusToThisObject = other.gameObject.GetComponent<PlayerShipController>();

            if (bonusToThisObject != null)
            {
                _weaponSystem = other.gameObject.GetComponent<WeaponSystem>();
                _weaponSystem.ApplyRateOffire(_applyRate);
                _weaponSystem.ApplyRateText();
                Destroy(gameObject);
            }
        }
    }
}
