using System;
using System.Collections.Generic;
using System.Text;

// It is created using chain responsibility design pattern
// example usage : ATM, Vending Machine, Logger System
// In logger system we create 1 object of logger class and 
namespace LLDPractice.ChainResponsibilityLoggerSystem
{
    public class ChainResponsibilityProcessor
    {
        public static void main()
        {
            LogProcessor logProcessor = new InfoLogProcessor(new DebugLogProcessor(new ErrorLogProcessor(nextLogProcessor: null)));

            logProcessor.log(LogProcessor.ERROR, message: "Exception message");
            logProcessor.log(LogProcessor.INFO, message: "Information message");
            logProcessor.log(LogProcessor.DEBUG, message: "Debug message");

        }
    }
}
