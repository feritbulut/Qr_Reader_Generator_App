namespace MyQrApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Generatecodebtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new generate());
        }

        private void Readcodebtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new reader());
        }
    }

}
