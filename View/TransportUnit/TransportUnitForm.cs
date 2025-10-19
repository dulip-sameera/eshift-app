using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eshift.View.TransportUnit
{
    public partial class TransportUnitForm : Form
    {
        private readonly ITransportUnitController transportUnitController;

        public TransportUnitForm()
        {
            InitializeComponent();
            transportUnitController = new TransportUnitControllerImpl();
        }

        private void btnTransportUnitSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string tuId = txtTransportUnitSearch.Text.Trim();
                var pattern = @"^TU\d{4}\d{5}$";
                if (string.IsNullOrWhiteSpace(tuId))
                {
                    MessageBox.Show("Please enter a Transport Unit ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(tuId, pattern))
                {
                    MessageBox.Show("Transport Unit ID must follow the pattern: TUYYYYNNNNN", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TransportUnitGridDto? tuGridDto = transportUnitController.GetTransportUnitForGridByTuId(tuId);
                if (tuGridDto != null)
                {
                    dgTransportUnit.DataSource = new List<TransportUnitGridDto> { tuGridDto };
                }
                else
                {
                    MessageBox.Show($"No transport unit found with ID: {tuId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgTransportUnit.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching transport unit: {ex.Message}");
                MessageBox.Show($"An error occurred while searching for the transport unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateTransportUnit_Click(object sender, EventArgs e)
        {
            CreateTransportUnitForm createTransportUnitForm = new CreateTransportUnitForm();
            createTransportUnitForm.Show();
        }

        private void btnUpdateTransportUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgTransportUnit.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a transport unit to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgTransportUnit.SelectedRows[0];
                var tuGridDto = selectedRow.DataBoundItem as TransportUnitGridDto;
                if (tuGridDto == null || string.IsNullOrWhiteSpace(tuGridDto.TransportUnitId))
                {
                    MessageBox.Show("Selected row does not have a valid Transport Unit ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UpdateTransportUnitForm updateTransportUnitForm = new UpdateTransportUnitForm(tuGridDto);
                updateTransportUnitForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening Update Transport Unit form: {ex.Message}");
                MessageBox.Show($"An error occurred while opening the Update Transport Unit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTransportUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgTransportUnit.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a transport unit to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgTransportUnit.SelectedRows[0];
                var tuGridDto = selectedRow.DataBoundItem as TransportUnitGridDto;
                if (tuGridDto == null || string.IsNullOrWhiteSpace(tuGridDto.TransportUnitId))
                {
                    MessageBox.Show("Selected row does not have a valid Transport Unit ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete transport unit {tuGridDto.TransportUnitId}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                transportUnitController.DeleteTransportUnitByTuId(tuGridDto.TransportUnitId);
                MessageBox.Show($"Transport unit {tuGridDto.TransportUnitId} deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh.PerformClick();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting transport unit: {ex.Message}");
                MessageBox.Show($"An error occurred while deleting the transport unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTransportUnitSearch.Text))
                txtTransportUnitSearch.Text = string.Empty;
            this.TransportUnitForm_Load(sender, e);
        }

        private void TransportUnitForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<TransportUnitGridDto>? tuList = transportUnitController.GetAllTransportUnitsForGrid();
                dgTransportUnit.DataSource = tuList;
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show($"No transport units found: {ex.Message}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgTransportUnit.DataSource = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading transport units: {ex.Message}");
                MessageBox.Show($"An error occurred while loading transport units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
