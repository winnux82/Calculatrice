using System.Globalization;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();

        }

        readonly float Nb_A;
        readonly float Nb_B;
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
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                
                //float calcul = Nb_A + Nb_B;
                //lbl_Info.Text = (Nb_A + Nb_B).ToString() ;
                float calcul = float.Parse(Txt_A.Text, CultureInfo.InvariantCulture.NumberFormat) + float.Parse(Txt_B.Text, CultureInfo.InvariantCulture.NumberFormat);
                lbl_Info.Text = calcul.ToString();

            }
            catch (FormatException ex)
            {
                lbl_Info.Text = ex.Message;
            }
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            if (Txt_A.Text == "0" || Txt_B.Text == "0")
                lbl_Info.Text = "Division impossible par 0";
            else
            {
            try
                {

                    float calcul = float.Parse(Txt_A.Text, CultureInfo.InvariantCulture.NumberFormat) / float.Parse(Txt_B.Text, CultureInfo.InvariantCulture.NumberFormat);
                    lbl_Info.Text = calcul.ToString();
                }
            catch (DivideByZeroException ex)
                {
                    lbl_Info.Text = ex.Message;

                }
            catch (FormatException ex)
                {
                    lbl_Info.Text = ex.Message;
                }
            }


        }


        private void Txt_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifier que la touche pressée n'est pas ctrl, digitale ou .
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Pas plus qu'un .
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Txt_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Btn_Diff_Click(object sender, EventArgs e)
        {
            try
            {
                float calcul = float.Parse(Txt_A.Text, CultureInfo.InvariantCulture.NumberFormat) - float.Parse(Txt_B.Text, CultureInfo.InvariantCulture.NumberFormat);

                lbl_Info.Text = calcul.ToString();

                //lbl_Info.Text = Convert.ToString(float.Parse(Txt_A.Text) + float.Parse(Txt_B.Text));

            }
            catch (FormatException ex)
            {
                lbl_Info.Text = ex.Message;
            }
        }

        private void Btn_Prod_Click(object sender, EventArgs e)
        {
            try
            {
                float calcul = float.Parse(Txt_A.Text, CultureInfo.InvariantCulture.NumberFormat) * float.Parse(Txt_B.Text, CultureInfo.InvariantCulture.NumberFormat);

                lbl_Info.Text = calcul.ToString();

                //lbl_Info.Text = Convert.ToString(float.Parse(Txt_A.Text) + float.Parse(Txt_B.Text));

            }
            catch (FormatException ex)
            {
                lbl_Info.Text = ex.Message;
            }
        }

        private void Verifier()
        {
            if(String.IsNullOrEmpty(Txt_A.Text)|| String.IsNullOrEmpty(Txt_B.Text))
                {
                    lbl_Info.Text = "Les champs ne peuvent pas être vides";
                }

        }



        //private void txt_A_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (txt_A.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma))
        //    {
        //        //tests 
        //    }
        //    else
        //    {
        //        if (!char.IsControl(e.KeyChar)
        //            && !char.IsDigit(e.KeyChar)
        //            && e.KeyChar != '.' && e.KeyChar != ',')
        //        {
        //            e.Handled = true;
        //        }
        //        // only allow one decimal point
        //        if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
        //        {
        //            e.Handled = true;
        //        }

        //        if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //}
    }
}