using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ChainResponsibilityLoggerSystem
{
    public abstract class LogProcessor
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        LogProcessor nextLogProcessor;
        public LogProcessor(LogProcessor _nextLogProcessor)
        {
            this.nextLogProcessor = _nextLogProcessor;
        }

        public virtual void log(int logLevel,  string message)
        {
            if(this.nextLogProcessor != null)
            {
                this.nextLogProcessor.log(logLevel, message);
            }
        }
     }
}
