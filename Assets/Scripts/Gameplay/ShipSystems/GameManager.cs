using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Gameplay.ShipSystems
{
    public class GameManager : MonoBehaviour
    {
        public StrenghtSystem PlayerStrenghtSystem;

        public GameObject FinishPanel;
        public Text Score;
        public Text finishScore;

        private void Start()
        {
            FinishPanel.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }

        public void CheckShipStrenght()
        {
            if (PlayerStrenghtSystem.DestroyShip() == true)
            {
                StopGame();
            }
        }


        public void StopGame()
        {

            Time.timeScale = 0f;
            FinishPanel.gameObject.SetActive(true);
            Score.text = finishScore.text;
        }

        public void Restart() 
        {
            SceneManager.LoadScene(0);
        }

    }
}
