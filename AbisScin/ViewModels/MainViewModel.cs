using AbisScin.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace AbisScin.ViewModels
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            InitSource();
        }

        public async void InitSource()
        {
            int InitCount = 0;

            while (true)
            {
                InitCount += 1;
                await Task.Delay(1000);

                if (InitCount >= 1)
                {
                    IsInit = false;
                    break;
                }
            }
        }

        private bool _IsInit = true;

        public bool IsInit
        {
            get { return _IsInit; }
            set { _IsInit = value; RaisePropertyChanged(nameof(IsInit)); }
        }

        private int _SelectedModularIndex;
        /// <summary>
        /// 属性.
        /// </summary>
        public int SelectedModularIndex
        {
            get { return _SelectedModularIndex; }
            set
            {
                Set(ref _SelectedModularIndex, value);
                if (value == 2)
                    MainBackground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                //MainBackground = new SolidColorBrush(Color.FromRgb(28, 64, 139));
                else if (value == 3)
                    MainBackground = new SolidColorBrush(Color.FromRgb(250, 251, 252));
                else
                    MainBackground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
        }

        private SolidColorBrush _MainBackground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        /// <summary>
        /// 属性.
        /// </summary>
        public SolidColorBrush MainBackground
        {
            get { return _MainBackground; }
            set { Set(ref _MainBackground, value); }
        }
        /// <summary>
        /// 命令Command
        /// </summary>
        public ICommand OpenClick => new RelayCommand<string>((e) =>
        {
            switch (e)
            {
                case "AduSkinDemo":
                    //new AduSkinDemo().Show();
                    return;
                default:
                    break;
            }
        });

        /// <summary>
        /// 常见控件
        /// </summary>
        private UserControl _CommonControlCase;//= new Recommend();
        public UserControl CommonControlCase
        {
            get { return _CommonControlCase; }
            set { Set(ref _CommonControlCase, value); }
        }
        /// <summary>
        /// 实用案例
        /// </summary>
        private UserControl _PracticalCase = new Recommend();
        public UserControl PracticalCase
        {
            get { return _PracticalCase; }
            set { Set(ref _PracticalCase, value); }
        }
        /// <summary>
        /// 关于
        /// </summary>
        private UserControl _AbisSkinAbout;// = new AduSkinAbout();
        public UserControl AbisSkinAbout
        {
            get { return _AbisSkinAbout; }
            set { Set(ref _AbisSkinAbout, value); }
        }
        /// <summary>
        /// 支持与赞助
        /// </summary>
        private UserControl _AbisSkinSupport;//= new AduSkinSupport();
        public UserControl AbisSkinSupport
        {
            get { return _AbisSkinSupport; }
            set { Set(ref _AbisSkinSupport, value); }
        }
    }
}