﻿namespace MiGestionGeneralMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        //funciones de botones on click



        private void AnadePersona(object sender, EventArgs e)
        {
            count++;
            //aviso del contador
            if (count == 1)
                CounterBtn.Text = $"{count} persona mas";
            else
                CounterBtn.Text = $"{count} personas mas";

            SemanticScreenReader.Announce(CounterBtn.Text);










        }





    }

}
