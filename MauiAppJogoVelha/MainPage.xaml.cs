namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "0"; 

        public MainPage()
        {
            InitializeComponent();
        }

        private void button_clicked (object sender, EventArgs e)
        {
            Button disparador = (button)sender;
            disparador.IsEnabled = false;
            if(vez=="0"
            {
                disparador.Text = "0";
                vez = "x";

            }else
            { }
    }

}
