using Sample.FolderArchitecture.AppLog;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Sample.FolderArchitecture.ViewModel
{
    public class BaseViewModel : BindableObject
    {
        #region private properties
        private string headerTitle;
        public string HeaderTitle
        {
            get { return headerTitle; }
            set
            {
                headerTitle = value;
                OnPropertyChanged(nameof(HeaderTitle));
            }
        }

        private string subHeaderTitle;
        public string SubHeaderTitle
        {
            get { return subHeaderTitle; }
            set
            {
                subHeaderTitle = value;
                OnPropertyChanged(nameof(SubHeaderTitle));
            }
        }
        private bool isShowSubHeader;
        public bool IsShowSubHeader
        {
            get { return isShowSubHeader; }
            set
            {
                isShowSubHeader = value;
                OnPropertyChanged(nameof(IsShowSubHeader));
            }
        }

        ImageSource rightMenuImage;
        public ImageSource RightMenuImage
        {
            get
            {
                return rightMenuImage;
            }
            set
            {
                rightMenuImage = value;
                OnPropertyChanged(nameof(RightMenuImage));
            }
        }
        private bool isShowRightMenuImage;
        public bool IsShowRightMenuImage
        {
            get { return isShowRightMenuImage; }
            set
            {
                isShowRightMenuImage = value;
                OnPropertyChanged(nameof(IsShowRightMenuImage));
            }
        }

        private string rightMenuText;
        public string RightMenuText
        {
            get { return rightMenuText; }
            set
            {
                rightMenuText = value;
                OnPropertyChanged(nameof(RightMenuText));
            }
        }

        private bool isShowRightMenuText;
        public bool IsShowRightMenuText
        {
            get { return isShowRightMenuText; }
            set
            {
                isShowRightMenuText = value;
                OnPropertyChanged(nameof(IsShowRightMenuText));
            }
        }
        #endregion
        #region public command

        /// <summary>
        /// this command is used to back to previous page 
        /// </summary>
        public Command BackPageCommand
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {
                        await Application.Current.MainPage.Navigation.PopAsync().ConfigureAwait(true);
                    }
                    catch (Exception ex)
                    {
                        LogManager.Savelog(nameof(BackPageCommand), ex);
                    }
                });
            }
        }

        /// <summary>
        /// this command is used for share
        /// </summary>
        public Command RightOptionCommand
        {
            get
            {
                return new Command(() =>
                {
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        LogManager.Savelog(nameof(RightOptionCommand), ex);
                    }
                });
            }
        }
        #endregion
    }
}
