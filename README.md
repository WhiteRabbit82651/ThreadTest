# Xamarin.Forms ThreadTest
- Xamarin.Formsでprismを利用して、他スレッドからメインスレッドの画面を更新（画面遷移）するためのテストアプリ
- 画面遷移をViewModelsから行う
- 簡単にいうと下記で行える

```C#
// 別スレッドからメインスレッドの画面を更新したい！
Xamarin.Forms.Device.BeginInvokeOnMainThread(() => NavigationService.NavigateAsync("PageBView"));
```

- `NavigationService`は親クラスの`ViewModelBase`にコンストラクタでnavigationServiceを渡すことで設定している
```C#
public MainPageViewModel(INavigationService navigationService)
    : base(navigationService)
{
}
```
