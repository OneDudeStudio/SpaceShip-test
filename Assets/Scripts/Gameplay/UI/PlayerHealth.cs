using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ShipSystems
{
    public class PlayerHealth : MonoBehaviour
    {
        public Text playerHealth;
        public StrenghtSystem StrenghtSystem;

        private void Update()
        {
            ApplyHealthText();
        }
        public void ApplyHealthText()
        {
            playerHealth.text = StrenghtSystem.ApplyStrenghtText().ToString();
        }
    }
}
