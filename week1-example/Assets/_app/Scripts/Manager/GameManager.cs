using UnityEngine;

namespace _app.Scripts.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public int playerScore;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy((this));
            }
            else
            {
                instance = this;
            }
        }
    }
    
    
}