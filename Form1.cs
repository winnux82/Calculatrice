using System.Globalization;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();

        }
        private void Calculatrice_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Eraser_Click(object sender, EventArgs e)
        {
            Txt_A.Clear();
            Txt_B.Clear();
            Txt_A.Focus();
            Lbl_Info.Text = "";

            Lbl_Info.BackColor= default;
            Lbl_Info.ForeColor = Color.Black;
        }

        public void Calculer(string Operateur)
        {

            if (String.IsNullOrEmpty(Txt_A.Text) || String.IsNullOrEmpty(Txt_B.Text))
            {
                Lbl_Info.BackColor = Color.Red;
                Lbl_Info.ForeColor = Color.White;
                Lbl_Info.Text = "Les champs ne peuvent pas être vides";
            }
            
            float Reponse;

            try
            {
                Lbl_Info.BackColor = Color.RoyalBlue;
                Lbl_Info.ForeColor = Color.Black;
                switch (Operateur)
                {

                    case "+":
                        Reponse = float.Parse(Txt_A.Text) + float.Parse(Txt_B.Text);

                        Lbl_Info.Text = Reponse.ToString();
                        break;
                    case "-":
                        Reponse = float.Parse(Txt_A.Text) - float.Parse(Txt_B.Text);
                        Lbl_Info.Text = Reponse.ToString();
                        break;
                    case "*":
                        Reponse = float.Parse(Txt_A.Text) * float.Parse(Txt_B.Text);
                        Lbl_Info.Text = Reponse.ToString();
                        break;
                    case "/":
                        Reponse = float.Parse(Txt_A.Text) / float.Parse(Txt_B.Text);
                        Lbl_Info.Text = Reponse.ToString();
                        break;
                    default:
                        // code block
                        break;
                }

            }
            catch (FormatException ex)
            {
                Lbl_Info.BackColor = Color.Red;
                Lbl_Info.ForeColor = Color.White;
                Lbl_Info.Text = ex.Message;

            }
            catch (DivideByZeroException ex)
            {
                Lbl_Info.BackColor = Color.Red;
                Lbl_Info.ForeColor = Color.White;
                Lbl_Info.Text = ex.Message;

            }

        }

        public class ChampsVides : Exception
        {
            public ChampsVides(string? message) : base(message)
            {
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Calculer("+");
        }
        private void Btn_Diff_Click(object sender, EventArgs e)
        {
            Calculer("-");
        }
        private void Btn_Prod_Click(object sender, EventArgs e)
        {
            Calculer("*");
        }
        private void Btn_Div_Click(object sender, EventArgs e)
        {
            Calculer("/");
        }
        private void Txt_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char hyphen = (char)0x2D;
            const char delete = (char)0x08;
            // Verifier que la touche pressée n'est pas ctrl, digitale ou .
            if (!char.IsDigit(e.KeyChar) && 
                (e.KeyChar != '-') && 
                (e.KeyChar != ',') &&
                (e.KeyChar != hyphen) && 
                (e.KeyChar != delete))
                    {
                        e.Handled = true;
                    }

            // Pas plus qu'un ,
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            // Pas plus qu'un -
            if ((e.KeyChar == '-') && (((TextBox)sender).Text.IndexOf('-') > -1)) //&& ((sender as TextBox).Text.StartsWith("-")
            {
                e.Handled = true;
            }


        }

        private void Txt_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char hyphen = (char)0x2D;
            const char delete = (char)0x08;
            // Verifier que la touche pressée n'est pas ctrl, digitale ou .
            if (!char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-') &&
                (e.KeyChar != ',') &&
                (e.KeyChar != hyphen) &&
                (e.KeyChar != delete))
            {
                e.Handled = true;
            }

            // Pas plus qu'un ,
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            // Pas plus qu'un -
            if ((e.KeyChar == '-') && (((TextBox)sender).Text.IndexOf('-') > -1)) //&& ((sender as TextBox).Text.StartsWith("-")
            {
                e.Handled = true;
            }


        }




        //private void Btn_Eraser_MouseHover(object sender, EventArgs e)
        //{
        //    Btn_Eraser.BackColor = Color.Blue;
        //}

        //private void Btn_Eraser_MouseLeave(object sender, EventArgs e)
        //{
        //    Btn_Eraser.BackColor = Color.Gray;
        //}
    }
}