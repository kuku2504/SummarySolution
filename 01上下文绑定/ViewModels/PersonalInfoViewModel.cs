using Prism.Mvvm;

namespace _01上下文绑定.ViewModels
{
    public class PersonalInfoViewModel : BindableBase
    {
        private string unitName;
        public string UnitName
        {
            get { return unitName; }
            set { SetProperty(ref unitName, value); }
        }
        private string cloudCoinNum;
        public string CloudCoinNum
        {
            get { return cloudCoinNum; }
            set { SetProperty(ref cloudCoinNum, value); }
        }

        public PersonalInfoViewModel()
        {
        }
        public void GetPersonInfo()
        {
            UnitName = "清华MBA";
            CloudCoinNum = "265";
        }
    }
}
