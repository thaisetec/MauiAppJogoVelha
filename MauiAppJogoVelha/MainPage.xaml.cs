namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        String vez = "O";

        public MainPage()
        {
            InitializeComponent();
        }

        private void button_clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if (vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            }
            else
            {
                disparador.Text = "X";
                vez = "O";
            }
            if (btn10.Text == "X"
                && btn11.Text == "X"
                && btn12.Text == "X")
            {
                DisplayAlert("Parabéns", "o X ganhou!", "OK");

            }
            if (btn10.Text == "O"
                && btn11.Text == "O"
                && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "o O ganhou!", "OK");
            }
            if (btn20.Text == "X"
                && btn21.Text == "X"
                && btn22.Text == "X")
            {
                DisplayAlert("Parabéns", "o X ganhou!", "OK");
            }
            if (btn20.Text == "O"
               && btn21.Text == "O"
               && btn22.Text == "O")
            {
                DisplayAlert("Parabéns", "o O ganhou!", "OK");
            }
            if (btn30.Text == "X"
                && btn31.Text == "X"
                && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "o X ganhou!", "OK");
            }
            if (btn30.Text == "O"
              && btn31.Text == "O"
              && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "o O ganhou!", "OK");
            }
            if (btn12.Text == "X"
            && btn21.Text == "X"
            && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "o X ganhou!", "OK");
            }
            if (btn12.Text == "O"
              && btn21.Text == "O"
              && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "o O ganhou!", "OK");
            }
        }
    }
}