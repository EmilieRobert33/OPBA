using Contracts;
using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;


namespace LoggerService
{
    /// <summary>
    /// A CSClass definition.
    /// </summary>
    public sealed class LoggerManager : ILoggerManager
    {
        #region fields

        #endregion

        #region properties
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region constructors

        public LoggerManager()
        {
        }

        #endregion

        #region methods
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
        #endregion
    }
}
