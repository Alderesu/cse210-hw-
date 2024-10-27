using System;  

namespace EternalQuestProgram  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            GoalManager goalManager = new GoalManager();  
            goalManager.Start();  
        }  
    }  
}

//Exceed Requirements: added a negative goal function where you get deducted based on the user inputs. Also added comment lines for exceeding requirements.