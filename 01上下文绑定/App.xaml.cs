﻿using _01上下文绑定.ViewModels;
using _01上下文绑定.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _01上下文绑定
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<PersonalInfoView, PersonalInfoViewModel>();
            ViewModelLocationProvider.Register<SchoolInfoView, SchoolInfoViewModel>();
        }        
    }
}
