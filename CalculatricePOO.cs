using Microsoft.VisualBasic.ApplicationServices;
using System.Globalization;

namespace Calculatrice
{
    
    public partial class CalculatricePOO : Form
    {
        public CalculatricePOO()
        {
            InitializeComponent();
            Lbl_Info.Hide();

        }
        private void Calculatrice_Load(object sender, EventArgs e)
        {
            Lbl_Info.BackColor = default;
            Lbl_Info.ForeColor = Color.Black;
        }





        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
            
        }
        private void Btn_Eraser_Click(object sender, EventArgs e)
        {
            Txt_A.Clear();
            Txt_B.Clear();
            Txt_A.Focus();
            Lbl_Info.Text = "";

            Lbl_Info.BackColor = default;
            Lbl_Info.ForeColor = Color.Black;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tous droits réservés Copyright \nVandermeulen Christophe", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Btn_Operation_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;

            try
            {
                CalculPOO NewOperation = new(Txt_A.Text,Txt_B.Text);

                if (Btn == Btn_Add)
                    DisplayInfo(NewOperation.Addition().ToString());

                if (Btn == Btn_Diff)
                    DisplayInfo(NewOperation.Soustraction().ToString());

                if (Btn == Btn_Prod)
                    DisplayInfo(NewOperation.Multiplication().ToString());

                if (Btn == Btn_Div)
                    DisplayInfo(NewOperation.Division().ToString());
            }
            catch (DivideByZeroException)
            {
                DisplayInfo("Vous ne pouvez pas diviser par zéro !! ", true);
            }
            catch
            {
                DisplayInfo("Une erreur de saisie a été détectée !! ", true);
            }
        }
        private void DisplayInfo(string information, bool IsError = false)
        {
            Lbl_Info.Text = information;

            if (IsError)
            {
                Lbl_Info.BackColor = Color.Red;
                Lbl_Info.ForeColor = Color.White;
            }
            else
            {
                Lbl_Info.ForeColor = Color.Black;
                Lbl_Info.BackColor = Color.RoyalBlue;
            }

            Lbl_Info.Show();

        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TxT = (TextBox)sender;
            //Lbl_Info.Show();
            //Lbl_Info.Text = e.KeyChar.ToString();

            if (TxT.TextLength >= 1)
            {


                if (!TxT.Text.Contains('.'))
                {
                    if (!(char.IsDigit(e.KeyChar) || 
                        char.IsControl(e.KeyChar) || 
                        e.KeyChar == '.' || 
                        !(e.KeyChar == '-')))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                    {
                        e.Handled = true;
                    }
                }
            }
        

        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            Lbl_Info.Hide();
        }
    }
}