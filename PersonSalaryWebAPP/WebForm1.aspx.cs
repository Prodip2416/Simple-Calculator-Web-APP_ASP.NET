using System;


namespace PersonSalaryWebAPP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowMeSalary_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtEmployeeName.Text;
                double basicAmount = Convert.ToDouble(txtBasicAmount.Text);
                double houseRent = Convert.ToDouble(txtHouseRent.Text);
                double medicalAllowance = Convert.ToDouble(txtMedicalAllowance.Text);

                SalaryCalculator SC = new SalaryCalculator(name, basicAmount, houseRent, medicalAllowance);

                ViewState["TotalSalary"] = SC;
                double totalResult = Convert.ToDouble(SC.ShowMeSalary());
                lblMessage.Text = name + " your total salary is : " + totalResult;
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
                ClearTextBox();
            }
        }
        private void ClearTextBox()
        {
            txtEmployeeName.Text = string.Empty;
            txtBasicAmount.Text = string.Empty;
            txtHouseRent.Text = string.Empty;
            txtMedicalAllowance.Text = string.Empty;
        }
    }
}