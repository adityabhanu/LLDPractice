using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ChainResponsibilityLoggerSystem
{
    public class ErrorLogProcessor : LogProcessor
    {
        public ErrorLogProcessor(LogProcessor nextLogProcessor) : base(nextLogProcessor) 
        {
        }

        public override void log(int logLevel,  string message)
        {
            if(logLevel == LogProcessor.ERROR)
            {
                Console.WriteLine($"ERROR: {message}");
            }
            else
            {
                base.log(logLevel, message);
            }
        }
    }
}
