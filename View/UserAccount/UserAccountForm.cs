using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eshift.View
{
    public partial class UserAccountForm : Form
    {

        private readonly IUserController userAccountController;
        public UserAccountForm()
        {
            InitializeComponent();
            userAccountController = new UserControllerImpl();
        }

        private async void UserAccountForm_Load(object sender, EventArgs e)
        {
            await LoadUserAccountsAsync();
        }

        private async Task LoadUserAccountsAsync()
        {
            try
            {
                var userAccounts = await Task.Run(() => userAccountController.GetAllUsersForGrid());
                dgUserAccount.DataSource = userAccounts;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading user accounts: {ex.Message}");
                MessageBox.Show(
                    ex.Message,
                    "Error Loading Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            adminDashboardForm.FormClosed += (s, args) =>
            {
                this.Close();
                Application.Exit();
            };
            adminDashboardForm.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgUserAccount.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgUserAccount.SelectedRows[0];
                var userGridDto = selectedRow.DataBoundItem as UserGridDto;
                if (userGridDto == null)
                {
                    MessageBox.Show("Selected row does not have a valid User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show(
                   $"Are you sure you want to delete User account {userGridDto.Username} ({userGridDto.Id})?",
                   "Confirm Delete",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                userAccountController.DeleteUserAccount(userGridDto);
                MessageBox.Show($"User account of {userGridDto.FullName}({userGridDto.Id}) deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh.PerformClick();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening update user account form: {ex.Message}");
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgUserAccount.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgUserAccount.SelectedRows[0];
                var userGridDto = selectedRow.DataBoundItem as UserGridDto;
                if (userGridDto == null)
                {
                    MessageBox.Show("Selected row does not have a valid User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UpdateUserAccountForm updateUserAccountForm = new UpdateUserAccountForm(userGridDto);
                updateUserAccountForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening update user account form: {ex.Message}");
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUsernameSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsernameSearch.Text.Trim();
                var filteredUsers = userAccountController.FilterUsersForGridByUsername(username);
                if (filteredUsers.Count == 0)
                {
                    MessageBox.Show(
                        "No user accounts found matching the specified username.",
                        "No Results",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    dgUserAccount.DataSource = filteredUsers;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error filtering user accounts: {ex.Message}");
                MessageBox.Show(
                    ex.Message,
                    "Error Searching Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateUserAccountForm createUserAccountForm = new CreateUserAccountForm();
            createUserAccountForm.Show();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadUserAccountsAsync();
        }
    }
}
