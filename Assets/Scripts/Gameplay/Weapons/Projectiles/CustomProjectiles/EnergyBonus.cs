using System.Collections;
using System.Collections.Generic;
using Gameplay.Weapons.Projectiles;
using UnityEngine;


namespace Gameplay.ShipSystems
{
    public class EnergyBonus : MonoBehaviour
    {
        [SerializeField] private float _speed;

        [SerializeField] private float _score;

        [SerializeField]
        private BonusSystem _bonusSystem;

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
                _bonusSystem = other.gameObject.GetComponent<BonusSystem>();
                _bonusSystem.AddScore(_score);
                _bonusSystem.ApplyScoreText();
                Destroy(gameObject);
            }
        }
    }
}
