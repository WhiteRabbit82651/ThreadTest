using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            NextCommand = new DelegateCommand(PageBShow);

        }

        /// <summary>
        /// コマンド関数
        /// </summary>
        public DelegateCommand NextCommand { get; set; }

        /// <summary>
        /// ページ遷移する
        /// </summary>
        private void PageBShow()
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                MyThread();
            }));
            thread.Start();
        }

        private void MyThread()
        {
            Console.WriteLine("☆☆☆スレッドスタート");
            Thread.Sleep(5000);
            Console.WriteLine("☆☆☆スレッドエンド");

            // 別スレッドからメインスレッドの画面を更新したい！
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                            NavigationService.NavigateAsync("PageBView"));
        }
    }
}
