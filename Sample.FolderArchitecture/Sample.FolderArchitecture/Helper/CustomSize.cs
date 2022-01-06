using Sample.FolderArchitecture.AppLog;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Sample.FolderArchitecture.Helper
{
    /// <summary>
    /// this class is used to set custom size
    /// </summary>
    public static class CustomSize
    {
        /// <summary>
        /// this method is used for image size  
        /// </summary>
        public static int GetTextboxImgSize()
        {
            int imageSize = 15;
            try
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    if (Device.Idiom == TargetIdiom.Phone)
                    {
                        imageSize = 15;
                    }
                    else
                    {
                        imageSize = 15;
                    }
                }
                else
                {
                    if (Device.Idiom == TargetIdiom.Phone)
                    {
                        imageSize = 25;
                    }
                    else
                    {
                        imageSize = 15;
                    }
                }
            }
            catch (Exception ex)
            {
                LogManager.Savelog("CustomSize.GetTextboxImgSize", ex);
            }
            return imageSize;
        }

        public static readonly int EntryCornerRadiusInt = GetEntryCornerRadiusInt();
        public static readonly double EntryCornerRadiusDouble = GetEntryCornerRadiusDouble();

        /// <summary>
        ///this method is used for get Entry corner radius in int
        /// </summary>
        private static int GetEntryCornerRadiusInt()
        {
            int cornerRadius;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    cornerRadius = 1;
                    break;
                default:
                    cornerRadius = 2;
                    break;
            }
            return cornerRadius;
        }

        /// <summary>
        ///this method is used for get Entry corner radius in double
        /// </summary>
        public static int GetEntryCornerRadiusDouble()
        {
            int cornerRadius;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    cornerRadius = 0;
                    break;
                default:
                    cornerRadius = 0;
                    break;
            }
            return cornerRadius;
        }
    }
}
