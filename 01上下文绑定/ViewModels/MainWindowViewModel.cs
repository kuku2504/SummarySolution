using _01上下文绑定.Views;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _01上下文绑定.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IContainerProvider _container;
        #region 字段属性
        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private string describeInfo;
        public string DescribeInfo
        {
            get { return describeInfo; }
            set { SetProperty(ref describeInfo, value); }
        }
        #endregion

        private PersonalInfoViewModel personalInfo;
        public PersonalInfoViewModel PersonalInfo
        {
            get { return personalInfo; }
            set { SetProperty(ref personalInfo, value); }
        }
        public MainWindowViewModel(IContainerExtension container)
        {
            _container = container;
            Title = "测试";
            DescribeInfo = "测试信息的描述文字";
        }

        /// <summary>
        /// DataContext
        /// </summary>
        private DelegateCommand _btPersonalInfoCommand;
        public DelegateCommand BtPersonalInfoCommand => _btPersonalInfoCommand ?? (_btPersonalInfoCommand = new DelegateCommand(ExecuteBtPersonalInfoCommand));

        private void ExecuteBtPersonalInfoCommand()
        {
            PersonalInfo = _container.Resolve<PersonalInfoViewModel>();
            PersonalInfo.GetPersonInfo();
        }



        private SchoolInfoView clipContent;
        public SchoolInfoView ClipContent
        {
            get { return clipContent; }
            set { SetProperty(ref clipContent, value); }
        }

        /// <summary>
        /// ContentControl--在点击加载的时候，获取数据，展示到界面上
        /// </summary>
        private DelegateCommand _btSchoolInfoCommand;
        public DelegateCommand BtSchoolInfoCommand => _btSchoolInfoCommand ?? (_btSchoolInfoCommand = new DelegateCommand(ExecuteBtSchoolInfoCommand));

        private void ExecuteBtSchoolInfoCommand()
        {
            ClipContent = new SchoolInfoView();
            ClipContent.DataContext = new SchoolInfoViewModel();
        }

    }
}
