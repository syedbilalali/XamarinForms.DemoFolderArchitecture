using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AppCenter.Crashes;

namespace Sample.FolderArchitecture.AppLog
{
    /// <summary>
    /// this class is used for error log manage
    /// </summary>
    public static class LogManager
    {
        /// <summary>
        /// This method is use to add error location and error message on app center.
        /// </summary>
        /// <param name="errorLocation"></param>
        /// <param name="errorMessage"></param>
        public static void Savelog(string errorLocation, Exception errorMessage)
        {
            try
            {
                if (errorMessage != null)
                {
                    IDictionary<string, string> errorDetails = new Dictionary<string, string>()
                    {
                        { AppResource.ErrorLocation, errorLocation },
                        { AppResource.ErrorMessage, errorMessage.StackTrace + string.Empty + errorMessage.Message }
                    };

                    Crashes.TrackError(errorMessage, errorDetails);
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
        }
    }
}
