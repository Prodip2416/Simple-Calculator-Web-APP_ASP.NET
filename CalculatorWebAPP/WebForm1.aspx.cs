using System;

namespace CalculatorWebAPP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtResult.Enabled = false;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {             
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);

                Calculator aCalculator = new Calculator(firstNumber, secondNumber);
                ViewState["Result"] = aCalculator;
                txtResult.Text = Convert.ToDouble(aCalculator.Add()).ToString();
                lblMessage.Text = string.Empty;
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
                ClearTextBox();
            }
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {           
            try
            {          
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);

                Calculator aCalculator = new Calculator(firstNumber, secondNumber);
                ViewState["Result"] = aCalculator;
                txtResult.Text = Convert.ToDouble(aCalculator.Subtract()).ToString();
                lblMessage.Text = string.Empty;
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
                ClearTextBox();
            }
         
        }

        protected void btnMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);

                Calculator aCalculator = new Calculator(firstNumber, secondNumber);
                ViewState["Result"] = aCalculator;
                txtResult.Text = Convert.ToDouble(aCalculator.Multiple()).ToString();
                lblMessage.Text = string.Empty;
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
                ClearTextBox();
            }
          
        }

        protected void btnDivided_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);

                Calculator aCalculator = new Calculator(firstNumber, secondNumber);
                ViewState["Result"] = aCalculator;
                txtResult.Text = Convert.ToDouble(aCalculator.Divided()).ToString();
                lblMessage.Text = string.Empty;
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
                ClearTextBox();
            }
        }
        private void ClearTextBox()
        {
            txtFirstNumber.Text = string.Empty;
            txtSecondNumber.Text = string.Empty;
            txtResult.Text = string.Empty;
        }
    }
}