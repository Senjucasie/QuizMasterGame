using System;


namespace QuizGame.GamePlay.Events
{
    public class GamePlayEventBroker
    {
        public static event Action StartTimer;
        public static event Action StopTimer;

        public static void CallStartTimer()
        {
            StartTimer?.Invoke();
        }

        public static void CallStopTimer()
        {
            StopTimer?.Invoke();
        }
    }
}

