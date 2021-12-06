using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Gameplay.ShipSystems
{
    public class BonusSystem : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] _bonus;

        [SerializeField]
        private float _score;

        private bool _alreadyGenerateBonus = false;
        //[SerializeField]
        //private float _fireRateBonus;
        public float ApplyScoreText()
        {
            float fullScore = _score;
            return fullScore;
        }

        public void GenerateBonus() 
        {
        
            if(_alreadyGenerateBonus == false && !gameObject.CompareTag("Player"))
            {
                int result = Random.Range(0, _bonus.Length);
                Instantiate(_bonus[result], transform.position, Quaternion.identity);
                _alreadyGenerateBonus = true;
            }
            
        }

        public void AddScore(float ScoreToAdd) 
        {
             _score += ScoreToAdd;
        }

        

    }
}
   
