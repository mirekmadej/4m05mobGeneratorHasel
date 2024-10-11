using System.Globalization;

namespace _4m05mobGeneratorHasel
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGeneruj(object sender, EventArgs e)
        {
            string ml = "abcdefghijklmnopqrstuvwxyz";
            string dl = ml.ToUpper();
            string cyfry = "0123456789";
            string znaki = "~!@#$%^&*()_+-=<>,.?/";
            string s = "";
            if (chkCyfry.IsChecked)
                s = s + cyfry;
            if (chkDuzeLitery.IsChecked)
                s = s + dl;
            if (chkMaleLitery.IsChecked)
                s = s + ml;
            if (chkZnaki.IsChecked)
                s = s + znaki;

            string w = "";
            Random r = new Random();

            for(int i = 0; i < int.Parse(entIleZnakow.Text); i++) 
                w += s[r.Next(0, s.Length - 1)];


            lblHaslo.Text = w;
        }
    }

}
