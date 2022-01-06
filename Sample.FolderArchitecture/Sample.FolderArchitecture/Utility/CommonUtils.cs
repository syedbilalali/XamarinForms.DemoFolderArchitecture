using Sample.FolderArchitecture.AppLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample.FolderArchitecture.Utility
{
    /// <summary>
    /// this class is used to comman utils
    /// </summary>
    public static class CommonUtils
    {
        #region Common User Properties

        public static bool IsAPIExecute;
        public static bool IsLoggedIn;
        public static string SecurityToken = string.Empty;
        public static string UserId = string.Empty;
        public static string UserName = string.Empty;
        public static string Email = string.Empty;
        public static string FirstName = string.Empty;
        public static string LastName = string.Empty;
        public static string MobileNo = string.Empty;
        public static byte[] UserImage;
        public static ImageSource SouceImage;

        #endregion

        #region Enum
        public enum User { Online , Offiline }

        #endregion

        #region Response Status Code
        public const int StatusSucess = 200;
        public const int StatusCreated = 201;
        public const int StatusNotFound = 404;
        public const int StatusBadRequest = 400;
        public const int StatusForbiden = 403;
        #endregion

        #region Common Method

        /// <summary>
        /// this method is used to display alert message
        /// </summary>
        public static void DisplayAlert(string message)
        {
            try
            {
                Application.Current.MainPage.DisplayAlert(AppResource.TextAlert, message, AppResource.TextOK);
            }
            catch (Exception ex)
            {
                LogManager.Savelog(nameof(DisplayAlert), ex);
            }
        }

        /// <summary>
        /// this method is used to display alert message
        /// </summary>
        public static async Task DisplayAlertAsync(string message)
        {
            try
            {
                await Application.Current.MainPage.DisplayAlert(AppResource.TextAlert, message, AppResource.TextOK).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                LogManager.Savelog(nameof(DisplayAlertAsync), ex);
            }
        }
        #endregion

    }
}
