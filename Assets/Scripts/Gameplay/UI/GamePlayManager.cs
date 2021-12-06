using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Gameplay.ShipSystems
{
    public class GamePlayManager : MonoBehaviour
    {
        public StrenghtSystem PlayerStrenghtSystem;

        public Canvas canvas;
        public GameObject FinishPanel;
        public Text Score;
        public Text finishScore;

        private void Start()
        {
            FinishPanel.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }

        private void Update()
        {
          if(  PlayerStrenghtSystem.DestroyShip() == true)
            {
                StopGame();
            }
        }
        public void StopGame()
        {
            canvas.sortingOrder = 2;
            Time.timeScale = 0f;
            FinishPanel.gameObject.SetActive(true);
            Score.text = finishScore.text;
        }

    }
}
