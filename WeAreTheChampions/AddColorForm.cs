using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Data;
using Color = System.Drawing.Color;

namespace WeAreTheChampions
{
    public partial class AddColorForm : Form
    {
        private readonly WATCDbContext _db;
        Color color;

        public AddColorForm(WATCDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtColorName.Text))
            {
                MessageBox.Show("You must specify a color name!", "Warning");
            }
            else
            {
                Data.Color newColor = new Data.Color()
                {
                    ColorName = txtColorName.Text,
                    Red = (int)nudRed.Value,
                    Green = (int)nudGreen.Value,
                    Blue = (int)nudBlue.Value
                };

                _db.Colors.Add(newColor);
                _db.SaveChanges();
                Close();
            }
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            color = Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
            this.BackColor = color;
        }
    }
}
