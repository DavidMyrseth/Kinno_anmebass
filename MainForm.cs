using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KinoProjekt
{
    public partial class MainForm : Form
    {
        private List<string> posters = new List<string>() { "HarryPotter.jpg", "Joker.jpg", "JUNC.jpg" };
        private int currentPosterIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKava_Click(object sender, EventArgs e)
        {
            // Переключение постеров
            currentPosterIndex = (currentPosterIndex + 1) % posters.Count;
            pictureBoxPoster.ImageLocation = posters[currentPosterIndex];
        }

        private void btnOstaPilet_Click(object sender, EventArgs e)
        {
            // Переход на форму регистрации
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            this.Hide();
        }
    }
}
