using System;  

namespace MindfulnessProgram  
{  
    public class BreathingActivity : Activity  
    {  
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")  
        {  
        }  

        public override void Run()  
        {  
            SetDuration();  
            DisplayStartingMessage();  

            DateTime endTime = DateTime.Now.AddSeconds(_duration);  
            while (DateTime.Now < endTime)  
            {  
                Console.WriteLine("Breathe in...");  
                ShowBreathingAnimation(5);  
                Console.WriteLine("Breathe out...");  
                ShowBreathingAnimation(5);  
            }  

            IncrementActivityCount();  
            DisplayEndingMessage();  
        }  

        private void ShowBreathingAnimation(int seconds)  
        {  
            for (int i = 0; i < seconds; i++)  
            {  
                Console.WriteLine($"Breathing... {new string(' ', i)}");  
                System.Threading.Thread.Sleep(1000);  
                Console.Clear();  
            }  
        }  
    }  
}