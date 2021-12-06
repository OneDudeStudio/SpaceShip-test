using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ShipSystems
{
    public class PlayerScore : MonoBehaviour
    {
        public Text playerScore;
        public BonusSystem BonusSystem;

        private void Update()
        {
            ApplyScoreText();
        }
        public void ApplyScoreText()
        {
            playerScore.text = BonusSystem.ApplyScoreText().ToString();
        }
    }
}
