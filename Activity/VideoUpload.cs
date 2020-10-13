using System;

namespace Ex.Workflow
{
    public class VideoUpload : IActivity
    {
        public void Execute() => Console.WriteLine("Video upload...");
    }
}