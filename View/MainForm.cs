using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using eshift.Utils;
using eshift.Utils.Validation;

namespace eshift.View
{
    public partial class MainForm : Form
    {
        private readonly IUserController userController;
        private Dictionary<string, Label> errorLabels = new();

        public MainForm()
        {
            InitializeComponent();
            userController = new UserControllerImpl();
            errorLabels = new Dictionary<string, Label>
            {
                { "username", lblUsernameErrorMessage },
                { "password", lblPasswordErrorMessage }
            };
            HideAllErrorLabels();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_click(object sender, EventArgs e)
        {
            try
            {
                // Extract username and password
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Validate username and password
                var errors = UserValidator.Validate(username, password);
                if (errors.Count > 0)
                {
                    ShowErrorMessages(errors);
                    return;
                }

                // Create login credentials DTO
                var loginCredentials = new LoginCredentialsDto(username, password);

                // Authenticate user
                bool success = userController.Login(loginCredentials);
                if (success)
                {
                    this.Hide();
                    
                    // Load appropriate dashboard based on user role
                    if (UserSession.Role == UserRoleEnum.ADMIN)
                    {
                        AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
                        adminDashboardForm.FormClosed += (s, args) =>
                        {
                            this.Close();
                            Application.Exit();
                        };
                        adminDashboardForm.Show();
                    }
                    else if (UserSession.Role == UserRoleEnum.CUSTOMER)
                    {
                        CustomerDashboardForm customerDashboardForm = new CustomerDashboardForm();
                        customerDashboardForm.FormClosed += (s, args) =>
                        {
                            this.Close();
                            Application.Exit();
                        };
                        customerDashboardForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in btnLogIn_click: {ex.Message}");
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideAllErrorLabels()
        {
            foreach (var label in errorLabels.Values)
            {
                label.Visible = false;
                label.Text = string.Empty;
            }
        }

        private void ShowErrorMessages(Dictionary<string, string> errors)
        {
            HideAllErrorLabels();
            foreach (var kvp in errors)
            {
                if (errorLabels.TryGetValue(kvp.Key, out var label))
                {
                    label.Text = kvp.Value;
                    label.Visible = true;
                }
            }
        }
    }
}
