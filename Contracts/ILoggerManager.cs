using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;


namespace Contracts
{
    /// <summary>
    /// interface pour le LoggerManager
    /// </summary>
    public interface ILoggerManager
    {
        #region fields

        #endregion

        #region properties

        #endregion

        #region constructors    

        #endregion

        #region methods
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
        #endregion
    }
}
