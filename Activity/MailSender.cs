using System;

namespace Ex.Workflow
{
    public class MailSender : IActivity
    {
        public void Execute() => Console.WriteLine("Sending Mail...");
    }
}