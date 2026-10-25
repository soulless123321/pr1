using System;
using System.Windows.Forms;

namespace Практическая_6_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            try
            {
                GroceryBasket basket = GroceryBasket.GetInstance();
                basket.Buy();

                txtInfo.Text = basket.GetInfo();
                btnEvent.Enabled = true;
                btnBuy.Enabled = false;
            }
            catch (InvalidOperationException ex)
            {
                errorProvider1.SetError(btnBuy, ex.Message);
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            try
            {
                GroceryBasket basket = GroceryBasket.GetInstance();
                string eventMessage = basket.TriggerRandomEvent();

                MessageBox.Show(eventMessage, "Случайное событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInfo.Text = basket.GetInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}