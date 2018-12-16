using LocalNotifcationDemo.ViewModels;    
using Xamarin.Forms;    
namespace LocalNotifcationDemo.Views {    
    public partial class LocalNotificationPage: ContentPage {    
        public LocalNotificationPage() {    
            InitializeComponent();    
            BindingContext = new LocalNotificationPageViewModel();    
        }    
    }    
} 