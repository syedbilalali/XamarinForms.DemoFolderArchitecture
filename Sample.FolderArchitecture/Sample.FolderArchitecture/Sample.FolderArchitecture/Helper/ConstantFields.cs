using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.FolderArchitecture.Helper
{
    /// <summary>
    /// this class is used for constraint field 
    /// </summary>
    public static class ConstantFields
    {
        public const string DatabaseName = "FolderArchitectureApp";
        public const string AndroidAppcenterKey = "android=df65a83a-b7c5-4c6a-9a62-3c213c580815;";
        public const string iOsAppcenterKey = "ios=f33a7655-e50c-43e2-bd20-fe5ae8ac3476;";
        public const string ApiGrantTypeText = "grant_type";
        public const string ApiGrantTypeValue = "client_credentials";
        public const string ApiUserNameText = "username";
        public const string ApiPasswordText = "password";
        public const string TextPhoneNumberFormatterPath = @"\D";
        public const string TextPhoneNumberFormatFirstCase = "{0}-{1}";
        public const string TextPhoneNumberFormatSecondCase = "{0}-{1}-{2}";
        public const string ApiAuthHeader = "Authorization";
        public const string ApiAuthHeaderValue = "Bearer ";
        public const string ApiAuthHeaderBasicValue = "Basic ";
        public const string ApiAcceptHeader = "Accept";
        public const string ApiAcceptHeaderValue = "application/json";
    }
}
