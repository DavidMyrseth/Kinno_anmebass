using System;
using System.Windows.Forms;

namespace KinoProjekt
{
    public partial class MovieSelectionForm : Form
    {
        public MovieSelectionForm()
        {
            InitializeComponent();
        }

        private void btnSelectMovie_Click(object sender, EventArgs e)
        {
            // Переход на форму выбора мест
            SeatSelectionForm seatForm = new SeatSelectionForm();
            seatForm.Show();
            this.Hide();
        }
    }
}
