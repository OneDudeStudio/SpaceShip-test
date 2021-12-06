using UnityEngine;

namespace Gameplay.ShipSystems
{
    public class StrenghtSystem : MonoBehaviour
    {
        [SerializeField]
        private float _hullStrenght;

        

        public float ApplyStrenghtText() 
        {
            float hull = _hullStrenght;
            return hull;
        }

        public void ReduceHullStrenght(float damage)
        {
            _hullStrenght -= damage;
        }

        public void IncreaseHullStrenght(float heal)
        {
            _hullStrenght += heal;
        }

        public void ApplyShipState(float damage)
        {
            ReduceHullStrenght(damage);
            ApplyStrenghtText();
            DestroyShip();
            
        }
        public bool DestroyShip() 
        {
            bool isDestroyed;
            if (_hullStrenght <= 0)
            {
                isDestroyed = true;
            }
            else isDestroyed = false;

            return isDestroyed;
        }
    }

}

