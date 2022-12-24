using UnityEngine;

namespace GameManagerClass
{
    public class GameManager : MonoBehaviour
    {
        public int score;
        private bool isGameOver = false;

        public void GameOver()
        {
            isGameOver = true;
            Debug.Log("Game Over");
        }

        public void IncreaseScore()
        {
            if (!isGameOver)
                score++;
        }
    }
}
