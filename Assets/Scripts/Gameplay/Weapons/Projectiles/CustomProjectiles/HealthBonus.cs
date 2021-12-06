using System.Collections;
using System.Collections.Generic;
using Gameplay.Weapons.Projectiles;
using UnityEngine;

namespace Gameplay.ShipSystems
{
    public class HealthBonus : Projectile
    {
        [SerializeField] 
        private StrenghtSystem _strenghtSystem;

        [SerializeField]
        private float _heal;

        protected override void Move(float speed)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            var bonusToThisObject = other.gameObject.GetComponent<PlayerShipController>();

            if (bonusToThisObject != null)
            {
                _strenghtSystem = other.gameObject.GetComponent<StrenghtSystem>();
                _strenghtSystem.IncreaseHullStrenght(_heal);
                _strenghtSystem.ApplyStrenghtText();
                Destroy(gameObject);
            }
        }
    }
}
