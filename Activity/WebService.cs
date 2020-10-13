using System;

namespace Ex.Workflow
{
    public class WebService : IActivity
    {
        public void Execute() => Console.WriteLine("Web Service...");
    }
}