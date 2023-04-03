using System;

namespace QuizGame.UI.Events
{
    public class UIEventBroker
    {
        public static event Action RestartGame;


        public static void CallRestartGame()
        {
            RestartGame?.Invoke();
        }
    }
}

