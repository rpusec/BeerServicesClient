using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerServicesProj3
{
    public partial class Form1 : Form, Common.IObserver
    {
        private Controller.Controller controller;
        private string logSeparator = Environment.NewLine + "----------------------" + Environment.NewLine;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller.Controller(10, 21, 5, 10, 0, 23, 59);
            controller.Subscribe(this);
            AvailabilityLabel.Text = controller.GetAvailability();
        }

        public void Notify(string log)
        {
            if (controller.CurrentState.Equals(Controller.Controller.State.PANEL))
            {
                MainTab.SelectTab(ClientPanelTab);

                //labels
                UsernDispl.Text = controller.GetCurrentUser().Username;
                AgeDispl.Text = "" + controller.GetCurrentUser().Age;
                AccessDispl.Text = controller.GetCurrentUser().AccessLevel;

                //input fields
                AgeChField.Text = "" + controller.GetCurrentUser().Age;
                PasswChField.Text = "";
                UsernChField.Text = controller.GetCurrentUser().Username;
                PasswReinputField.Text = "";
            }
            else if (controller.CurrentState.Equals(Controller.Controller.State.LOGIN))
            {
                MainTab.SelectTab(LoginTab);
                ResetInputFields();
            }
            else if (controller.CurrentState.Equals(Controller.Controller.State.SERVICE)) 
            {
                if (log != null)
                {
                    //appeding the log
                    Output.Text += log;
                    Output.Text += logSeparator;

                    //autoscroll
                    Output.SelectionStart = Output.TextLength;
                    Output.ScrollToCaret();
                }   
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int message = controller.UserLogin(UsernLoginField.Text, PasswLoginField.Text);

            if(message == Operators.UsersOperator.SUCCESS)
                MessageBox.Show("Welcome, " + UsernLoginField.Text + "! ");
            else if (message == Operators.UsersOperator.LOGIN_INFO_NOT_FOUND)
                MessageBox.Show("Wrong username or password. ");
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            int message = controller.UserLogOut();

            if (message == Operators.UsersOperator.SUCCESS)
                MessageBox.Show("You've been successfully logged out! ");
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (!Validation.InputValidation.ValidateNumberFormat(AgeRegField.Text)) { MessageBox.Show("Please enter a number for the Age. "); return; }
            if (!Validation.InputValidation.ValidateLength(1, 2, AgeRegField.Text)) { MessageBox.Show("Please enter at least 2 values for Age field. "); return; }
            if (!Validation.InputValidation.ValidateLength(3, 15, PasswRegField.Text)) { MessageBox.Show("Please enter at least 3 to 15 values for the Password field. "); return; }
            if (!Validation.InputValidation.ValidateLength(3, 10, UsernRegField.Text)) { MessageBox.Show("Please enter at least 3 to 10 values for the Username field. "); return; }

            int message = controller.UserRegistration(UsernRegField.Text, PasswRegField.Text, int.Parse(AgeRegField.Text), Operators.UsersOperator.USER);

            if (message == Operators.UsersOperator.SUCCESS)
                MessageBox.Show("Account successfully created! Please login to proceed. ");
            else if (message == Operators.UsersOperator.REG_SAME_USERNAME)
                MessageBox.Show("Please choose a different username. ");
            else if (message == Operators.UsersOperator.REG_AGE_RESTRICTION)
                MessageBox.Show("The age should be at least 10. ");
            else if (message == Operators.UsersOperator.COMMAND_NOT_FOUND)
                MessageBox.Show("Wrong command. ");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!Validation.InputValidation.ValidateNumberFormat(AgeChField.Text)) { MessageBox.Show("Please enter a number for the Age. "); return; }
            if (!Validation.InputValidation.ValidateLength(1, 2, AgeChField.Text)) { MessageBox.Show("Please enter at least 2 values for Age field. "); return; }
            if (!Validation.InputValidation.ValidateLength(3, 15, PasswChField.Text) || !Validation.InputValidation.ValidateLength(3, 15, PasswReinputField.Text)) { MessageBox.Show("Please enter at least 3 to 15 values for the Password field. "); return; }
            if (!Validation.InputValidation.ValidateLength(3, 10, UsernChField.Text)) { MessageBox.Show("Please enter at least 5 to 10 values for the Username field. "); return; }

            int message = controller.ChangeUserInfo(UsernChField.Text, PasswChField.Text, int.Parse(AgeChField.Text), controller.GetCurrentUser().AccessLevel, PasswReinputField.Text);

            if (message == Operators.UsersOperator.SUCCESS)
                MessageBox.Show("Your user information is modified. ");
            else if (message == Operators.UsersOperator.REG_SAME_USERNAME)
                MessageBox.Show("Please choose a different username. ");
            else if (message == Operators.UsersOperator.REG_AGE_RESTRICTION)
                MessageBox.Show("The age should be at least 10. ");
            else if (message == Operators.UsersOperator.CH_WRONG_PASSWORD)
                MessageBox.Show("Wrong password. ");
            else if (message == Operators.UsersOperator.COMMAND_NOT_FOUND)
                MessageBox.Show("Wrong command. ");
        }

        private void onMainTabChange(object sender, EventArgs e)
        {
            //if a user is logged in
            if (controller.GetCurrentUser() != null)
            {
                if (MainTab.SelectedTab.Equals(LoginTab) || MainTab.SelectedTab.Equals(SignUpTab))
                    MainTab.SelectTab(ServiceTab);
            }
            else 
            {
                if (MainTab.SelectedTab.Equals(ServiceTab) || MainTab.SelectedTab.Equals(ClientPanelTab))
                    MainTab.SelectTab(LoginTab);
            }
        }

        private void ResetInputFields() 
        {
            //login field
            UsernLoginField.Text    = "";
            PasswLoginField.Text    = "";

            //user change fields
            AgeChField.Text         = "";
            PasswChField.Text       = "";
            UsernChField.Text       = "";
            PasswChField.Text       = "";

            //registration
            UsernRegField.Text      = "";
            AgeRegField.Text        = "";
            PasswRegField.Text      = "";

            //information on user ctrl panel
            UsernDispl.Text         = "";
            AgeDispl.Text           = "";
            AccessDispl.Text        = "";
            PasswReinputField.Text  = "";

            //on service
            Output.Text             = "";
            GetPriceField.Text      = "";
            SetPriceArg0Field.Text  = "";
            SetPriceArg1Field.Text  = "";
            TokenPassw.Text         = "";
        }

        private void GetMethodsBtn_Click(object sender, EventArgs e)
        {
            controller.GetMethods(TokenPassw.Text);
        }

        private void GetBeersBtn_Click(object sender, EventArgs e)
        {
            controller.GetBeers(TokenPassw.Text);
        }

        private void GetCheapestBtn_Click(object sender, EventArgs e)
        {
            controller.GetCheapest(TokenPassw.Text);
        }

        private void GetCostliestBtn_Click(object sender, EventArgs e)
        {
            controller.GetCostliest(TokenPassw.Text);
        }

        private void GetPriceBtn_Click(object sender, EventArgs e)
        {
            if (Validation.InputValidation.ValidateLength(0, 20, GetPriceField.Text))
                controller.GetPrice(GetPriceField.Text, TokenPassw.Text);
            else
                MessageBox.Show("Input must be less than 20 chracters long. ");
        }

        private void SetPriceBtn_Click(object sender, EventArgs e)
        {
            if (Validation.InputValidation.ValidateLength(0, 20, SetPriceArg0Field.Text))
                if (Validation.InputValidation.ValidateNumberFormat(SetPriceArg1Field.Text))
                    if (Validation.InputValidation.ValidateNumberLength(double.Parse(SetPriceArg1Field.Text), 2))
                        controller.SetPrice(SetPriceArg0Field.Text, Double.Parse(SetPriceArg1Field.Text), TokenPassw.Text);
                    else
                        MessageBox.Show("Please insert a number with max 2 values. ");
                else
                    MessageBox.Show("Please insert a legitimate number. ");
            else
                MessageBox.Show("Input must be less than 20 chracters long. ");
        }

        private void GetTokenBtn_Click(object sender, EventArgs e)
        {
            controller.SetToken(TokenPassw.Text);
        }
    }
}
