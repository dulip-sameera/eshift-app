using eshift.Controller;
using eshift.Controller.Impl;
using eshift.Dto;
using eshift.Enums;
using eshift.Utils.Mapper;
using System;
using System.Windows.Forms;

namespace eshift.View.TransportUnit
{
    public partial class UpdateTransportUnitForm : Form
    {
        private readonly TransportUnitGridDto transportUnitGridDto;
        private readonly ITransportUnitController transportUnitController;
        private readonly IStaffController staffController;
        private readonly IVehicleController vehicleController;

        private int? driverDbId = null;
        private int? assistantDbId = null;
        private int? vehicleDbId = null;
        private VehicleDto? selectedVehicleDto = null;

        public UpdateTransportUnitForm(TransportUnitGridDto transportUnitGridDto)
        {
            InitializeComponent();
            this.transportUnitGridDto = transportUnitGridDto;
            transportUnitController = new TransportUnitControllerImpl();
            staffController = new StaffControllerImpl();
            vehicleController = new VehilceConrollerImpl();
            LoadTransportUnitData();
        }

        private void LoadTransportUnitData()
        {
            try
            {
                lblFormTitle.Text = $"Update Transport Unit #{transportUnitGridDto.TransportUnitId}";

                // Extract IDs from grid DTO
                string tuId = transportUnitGridDto.TransportUnitId;
                string vehicleRegNo = transportUnitGridDto.Vehicle;
                string driverStaffId = transportUnitGridDto.Driver.Split(' ')[0];
                string assistantStaffId = transportUnitGridDto.Assistant.Split(' ')[0];

                // Get driver data
                var driverDto = staffController.GetStaffByStaffId(driverStaffId);
                if (driverDto != null)
                {
                    txtDriverId.Text = driverDto.StaffId;
                    txtDriverName.Text = driverDto.FirstName + " " + driverDto.LastName;
                    driverDbId = driverDto.Id;
                }

                // Get assistant data
                var assistantDto = staffController.GetStaffByStaffId(assistantStaffId);
                if (assistantDto != null)
                {
                    txtAssistantId.Text = assistantDto.StaffId;
                    txtAssistantName.Text = assistantDto.FirstName + " " + assistantDto.LastName;
                    assistantDbId = assistantDto.Id;
                }

                // Get vehicle data
                selectedVehicleDto = vehicleController.getVehicleByRegNo(vehicleRegNo);
                if (selectedVehicleDto != null)
                {
                    txtVehicleRegNo.Text = selectedVehicleDto.RegistrationNumber;
                    txtVehicleName.Text = $"{selectedVehicleDto.Brand} | {selectedVehicleDto.Model}";
                    txtContainerVolume.Text = selectedVehicleDto.ContainerVolume.ToString();
                    txtContainerMaxWeight.Text = selectedVehicleDto.MaxWeight.ToString();
                    vehicleDbId = transportUnitController.GetVehicleDbIdByRegNo(vehicleRegNo);
                }

                // set the availability
                cmbAvailability.Text = transportUnitGridDto.Available;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transport unit data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            lblDriverErrorMessage.Text = "";
            lblDriverErrorMessage.Visible = false;
            string staffId = txtDriverId.Text.Trim();
            var pattern = @"^STF\d{4}\d{5}$";
            if (string.IsNullOrWhiteSpace(staffId))
            {
                lblDriverErrorMessage.Text = "Please enter a Staff ID.";
                lblDriverErrorMessage.Visible = true;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(staffId, pattern))
            {
                lblDriverErrorMessage.Text = "Staff ID must follow the pattern: STFYYYYNNNNN";
                lblDriverErrorMessage.Visible = true;
                return;
            }
            try
            {
                var staffDto = staffController.GetStaffByStaffId(staffId);
                if (staffDto == null)
                {
                    lblDriverErrorMessage.Text = "No staff found with this ID.";
                    lblDriverErrorMessage.Visible = true;
                    return;
                }
                if (staffDto.Type.Name != StaffTypeEnum.DRIVER.ToString())
                {
                    MessageBox.Show("Selected staff is not a driver. Please enter a valid driver Staff ID.", "Invalid Driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDriverId.Text = "";
                    txtDriverName.Text = "";
                    driverDbId = null;
                    return;
                }
                if (transportUnitController.IsDriverInTransportUnit(staffDto.Id ?? 0) && staffDto.StaffId != transportUnitGridDto.Driver.Split(' ')[0])
                {
                    MessageBox.Show("This driver is already assigned to a transport unit.", "Driver Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDriverId.Text = "";
                    txtDriverName.Text = "";
                    driverDbId = null;
                    return;
                }
                txtDriverName.Text = staffDto.FirstName + " " + staffDto.LastName;
                driverDbId = staffDto.Id;
            }
            catch (Exception ex)
            {
                lblDriverErrorMessage.Text = $"Error: {ex.Message}";
                lblDriverErrorMessage.Visible = true;
            }
        }

        private void btnAddAssistant_Click(object sender, EventArgs e)
        {
            lblAssistantErrorMessage.Text = "";
            lblAssistantErrorMessage.Visible = false;
            string staffId = txtAssistantId.Text.Trim();
            var pattern = @"^STF\d{4}\d{5}$";
            if (string.IsNullOrWhiteSpace(staffId))
            {
                lblAssistantErrorMessage.Text = "Please enter a Staff ID.";
                lblAssistantErrorMessage.Visible = true;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(staffId, pattern))
            {
                lblAssistantErrorMessage.Text = "Staff ID must follow the pattern: STFYYYYNNNNN";
                lblAssistantErrorMessage.Visible = true;
                return;
            }
            try
            {
                var staffDto = staffController.GetStaffByStaffId(staffId);
                if (staffDto == null)
                {
                    lblAssistantErrorMessage.Text = "No staff found with this ID.";
                    lblAssistantErrorMessage.Visible = true;
                    return;
                }
                if (staffDto.Type.Name != StaffTypeEnum.ASSISTANT.ToString())
                {
                    MessageBox.Show("Selected staff is not an assistant. Please enter a valid assistant Staff ID.", "Invalid Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAssistantId.Text = "";
                    txtAssistantName.Text = "";
                    assistantDbId = null;
                    return;
                }
                if (transportUnitController.IsAssistantInTransportUnit(staffDto.Id ?? 0) && staffDto.StaffId != transportUnitGridDto.Assistant.Split(' ')[0])
                {
                    MessageBox.Show("This assistant is already assigned to a transport unit.", "Assistant Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAssistantId.Text = "";
                    txtAssistantName.Text = "";
                    assistantDbId = null;
                    return;
                }
                txtAssistantName.Text = staffDto.FirstName + " " + staffDto.LastName;
                assistantDbId = staffDto.Id;
            }
            catch (Exception ex)
            {
                lblAssistantErrorMessage.Text = $"Error: {ex.Message}";
                lblAssistantErrorMessage.Visible = true;
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            lblVehicleErrorMessage.Text = "";
            lblVehicleErrorMessage.Visible = false;
            string regNo = txtVehicleRegNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(regNo))
            {
                lblVehicleErrorMessage.Text = "Please enter a vehicle registration number.";
                lblVehicleErrorMessage.Visible = true;
                return;
            }
            try
            {
                selectedVehicleDto = vehicleController.getVehicleByRegNo(regNo);
                if (selectedVehicleDto == null)
                {
                    lblVehicleErrorMessage.Text = "No vehicle found with this registration number.";
                    lblVehicleErrorMessage.Visible = true;
                    txtVehicleName.Text = "";
                    txtContainerVolume.Text = "";
                    txtContainerMaxWeight.Text = "";
                    vehicleDbId = null;
                    return;
                }
                int dbId = transportUnitController.GetVehicleDbIdByRegNo(regNo);
                if (transportUnitController.IsVehicleInTransportUnit(dbId) && selectedVehicleDto.RegistrationNumber != transportUnitGridDto.Vehicle)
                {
                    MessageBox.Show("This vehicle is already assigned to a transport unit.", "Vehicle Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVehicleRegNo.Text = "";
                    txtVehicleName.Text = "";
                    txtContainerVolume.Text = "";
                    txtContainerMaxWeight.Text = "";
                    vehicleDbId = null;
                    return;
                }
                txtVehicleName.Text = $"{selectedVehicleDto.Brand} | {selectedVehicleDto.Model}";
                txtContainerVolume.Text = selectedVehicleDto.ContainerVolume.ToString();
                txtContainerMaxWeight.Text = selectedVehicleDto.MaxWeight.ToString();
                vehicleDbId = dbId;
            }
            catch (Exception ex)
            {
                lblVehicleErrorMessage.Text = $"Error: {ex.Message}";
                lblVehicleErrorMessage.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (driverDbId == null || assistantDbId == null || vehicleDbId == null)
                {
                    MessageBox.Show("Please add valid driver, assistant, and vehicle before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double containerVolume, maxWeight;
                if (!double.TryParse(txtContainerVolume.Text, out containerVolume) || !double.TryParse(txtContainerMaxWeight.Text, out maxWeight))
                {
                    MessageBox.Show("Invalid container volume or max weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TU ID and DB ID are not updatable
                var transportUnitDto = new TransportUnitDto(
                    null,
                    tuId: transportUnitGridDto.TransportUnitId,
                    vehicleId: vehicleDbId.Value,
                    driverId: driverDbId.Value,
                    assistantId: assistantDbId.Value,
                    available: cmbAvailability.Text.Trim() == "Yes" ? TransportUnitAvailableEnum.YES : TransportUnitAvailableEnum.NO
                );

                transportUnitController.UpdateTransportUnit(transportUnitDto);
                MessageBox.Show("Transport unit updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                windowClose();
                var parentForm = Application.OpenForms["TransportUnitForm"] as TransportUnitForm;
                parentForm?.btnRefresh_Click(sender, e);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating transport unit: {ex.Message}");
                MessageBox.Show($"An error occurred while updating the transport unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            windowClose();
        }

        private void windowClose()
        {
            this.Close();
        }
    }
}
