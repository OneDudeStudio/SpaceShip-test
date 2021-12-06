using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ShipSystems
{
    public class PlayerRateOfFire : MonoBehaviour
    {
        public Text playerRateOfFireText;
        public WeaponSystem WeaponSystem;


        private void Update()
        {
            ApplyRateOffireText();
        }

        public void ApplyRateOffireText()
        {

            playerRateOfFireText.text = WeaponSystem.ApplyRateText().ToString();
        }
    }
}
