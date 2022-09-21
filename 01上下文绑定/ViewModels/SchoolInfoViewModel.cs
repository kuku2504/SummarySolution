using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01上下文绑定.ViewModels
{
    public class SchoolInfoViewModel : BindableBase
    {
        private string schoolAddress;
        public string SchoolAddress
        {
            get { return schoolAddress; }
            set { SetProperty(ref schoolAddress, value); }
        }
        private string schoolRanking;
        public string SchoolRanking
        {
            get { return schoolRanking; }
            set { SetProperty(ref schoolRanking, value); }
        }
        public SchoolInfoViewModel()
        {
            SchoolAddress = "海淀区";
            SchoolRanking = "1";
        }
    }
}
