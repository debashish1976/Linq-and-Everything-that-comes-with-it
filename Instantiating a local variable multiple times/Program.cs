using System;
using System.Collections.Generic;

namespace Instantiating_a_local_variable_multiple_times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Action> actions = CreateActions();
            foreach (Action action in actions)
            {
                action();
            }
        }
        static List<Action> CreateActions()
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                string text = string.Format("message {0}", i); //Declares a local variable within the loop
                actions.Add(() => Console.WriteLine(text)); //Captures the variable in a lambda expression
            }
            return actions;
        }
    }
}
