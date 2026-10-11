using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ChainResponsibilityLoggerSystem
{
    public class DebugLogProcessor : LogProcessor
    {
        public DebugLogProcessor(LogProcessor nextLogProcessor) : base(nextLogProcessor)
        {

        }

        public override void log(int logLevel, string message)
        {
            if (logLevel == LogProcessor.DEBUG)
            {
                Console.WriteLine($"DEBUG : {message}");
            }

            else
            {
                base.log(logLevel, message);
            }
        }
    }
}
