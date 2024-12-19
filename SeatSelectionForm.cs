using System;
using System.Windows.Forms;

namespace KinoProjekt
{
    public partial class SeatSelectionForm : Form
    {
        private bool[,] seats = new bool[5, 5]; // 5x5 зал

        public SeatSelectionForm()
        {
            InitializeComponent();
            DrawSeats();
        }

        private void DrawSeats()
        {
            tableLayoutPanelSeats.Controls.Clear();
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Button seat = new Button();
                    seat.Text = $"Ряд {row + 1}, Место {col + 1}";
                    seat.BackColor = seats[row, col] ? System.Drawing.Color.Red : System.Drawing.Color.Green;
                    seat.Click += (sender, e) => Seat_Click(sender, row, col);
                    tableLayoutPanelSeats.Controls.Add(seat);
                }
            }
        }

        private void Seat_Click(object sender, int row, int col)
        {
            if (!seats[row, col])
            {
                seats[row, col] = true;
                MessageBox.Show("Фильм оплачен! Место успешно выбрано.");
                DrawSeats();
            }
            else
            {
                MessageBox.Show("Это место уже занято.");
            }
        }
    }
}
