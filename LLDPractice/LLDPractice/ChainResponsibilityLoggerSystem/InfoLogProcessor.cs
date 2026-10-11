using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ChainResponsibilityLoggerSystem
{
    public class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor nextLogProcessor) : base(nextLogProcessor)
        {

        }

        public override void log(int logLevel, string message)
        {
            if(logLevel == LogProcessor.INFO)
            {
                Console.WriteLine($"INFO: {message}");
            }
            else
            {
                base.log(logLevel, message);
            }
        }
    }
}
