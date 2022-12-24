using UnityEngine;
using UnityEngine.UI;

namespace GameManagerClass
{
    public class GameManager : MonoBehaviour
    {
        public Text scoreText;
        public GameObject playButton;
        public GameObject getReady;
        public GameObject gameOver;
        private bool gameStarted = false;
        public Player player;
        public int score;
        private bool isGameOver = false;

        private void Awake()
        {
            Application.targetFrameRate = 60;
            gameOver.SetActive(false);
            Pause();
        }

        public void Play()
        {
            gameStarted = true;
            isGameOver = false;
            score = 0;
            scoreText.text = score.ToString();

            if (gameStarted)
                getReady.SetActive(false);

            gameOver.SetActive(false);
            playButton.SetActive(false);

            Time.timeScale = 1;
            player.enabled = true;

            Pipes[] pipes = FindObjectsOfType<Pipes>();

            for (int i = 0; i < pipes.Length; i++)
            {
                Destroy(pipes[i].gameObject);
            }
        }

        public void Pause()
        {
            Time.timeScale = 0;
            player.enabled = false;
        }

        public void GameOver()
        {
            isGameOver = true;
            gameOver.SetActive(true);
            playButton.SetActive(true);

            Pause();
        }

        public void IncreaseScore()
        {
            if (!isGameOver)
                score++;

            scoreText.text = score.ToString();
        }
    }
}
