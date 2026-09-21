using System.Data;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace apex_management_sys
{
    public sealed class RP_Reception : Form
    {
        private readonly Color navy = Color.FromArgb(8, 63, 85);
        private readonly Color blue = Color.FromArgb(64, 145, 196);
        private readonly Color paleBlue = Color.FromArgb(222, 235, 245);
        private readonly Color pageBackground = Color.FromArgb(245, 248, 252);

        private readonly DataGridView patientGrid = new();
        private readonly TextBox txtSearch = new();
        private readonly TextBox txtFirstName = new();
        private readonly TextBox txtLastName = new();
        private readonly ComboBox cmbIdentificationType = new();
        private readonly TextBox txtIdentificationNumber = new();
        private readonly TextBox txtContactNumber = new();
        private readonly TextBox txtEmergencyNumber = new();
        private readonly DateTimePicker dtpDateOfBirth = new();
        private readonly ComboBox cmbGender = new();
        private readonly TextBox txtAddress = new();
        private readonly Label lblPatientNumber = new();
        private readonly Label lblRegisteredAt = new();
        private readonly Label lblStatus = new();
        private int selectedPatientId;

        public RP_Reception()
        {
            Text = "Reception Management";
            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(1250, 760);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = pageBackground;
            Font = new Font("Segoe UI", 10F);

            BuildInterface();

            if (Session.CurrentReceptionist == null ||
                !Session.CurrentReceptionist.IsReceptionist())
            {
                Shown += (_, _) => DenyAccess();
                return;
            }

            LoadPatients();
        }

        private void BuildInterface()
        {
            TableLayoutPanel page = new()
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                BackColor = pageBackground,
                ColumnCount = 2,
                RowCount = 2
            };
            page.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215F));
            page.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            page.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            page.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            TableLayoutPanel sidebar = BuildSidebar();
            page.Controls.Add(sidebar, 0, 0);
            page.SetRowSpan(sidebar, 2);
            page.Controls.Add(BuildHeader(), 1, 0);

            TableLayoutPanel content = new()
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = new Padding(24),
                BackColor = pageBackground,
                ColumnCount = 2,
                RowCount = 1
            };
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            content.Controls.Add(BuildPatientList(), 0, 0);
            content.Controls.Add(BuildPatientEditor(), 1, 0);
            page.Controls.Add(content, 1, 1);
            Controls.Add(page);
        }

        private Panel BuildHeader()
        {
            Panel header = new()
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                BackColor = Color.White
            };
            header.Controls.Add(new Label
            {
                Text = "Reception Management",
                AutoSize = true,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = navy,
                Location = new Point(32, 17)
            });
            header.Controls.Add(new Label
            {
                Text = "Register patients and quickly find existing patient records",
                AutoSize = true,
                Font = new Font("Segoe UI", 10.5F),
                ForeColor = Color.DimGray,
                Location = new Point(35, 66)
            });

            Panel accountArea = new()
            {
                Dock = DockStyle.Right,
                Width = 330,
                Padding = new Padding(10, 0, 28, 0)
            };
            accountArea.Controls.Add(new Label
            {
                Text = Session.CurrentReceptionist == null
                    ? "Receptionist access only"
                    : $"Signed in: {Session.CurrentReceptionist.GetFullName()}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = navy
            });
            header.Controls.Add(accountArea);
            return header;
        }

        private TableLayoutPanel BuildSidebar()
        {
            ComponentResourceManager resources = new(typeof(home));
            TableLayoutPanel sidebar = new()
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                BackColor = paleBlue,
                Padding = Padding.Empty,
                ColumnCount = 1,
                RowCount = 3
            };
            sidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            sidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));

            PictureBox logo = new()
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(25, 6, 25, 2),
                Image = resources.GetObject("Logo.Image") as Image ?? Properties.Resources.apex_logo,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = paleBlue
            };
            sidebar.Controls.Add(logo, 0, 0);

            FlowLayoutPanel menu = new()
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(14, 20, 14, 0),
                Margin = Padding.Empty
            };
            menu.Controls.Add(CreateNavButton("Reception", null, true));
            menu.Controls.Add(CreateNavButton("New patient", ClearEditor));
            sidebar.Controls.Add(menu, 0, 1);

            TableLayoutPanel accountMenu = new()
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = new Padding(14, 0, 14, 8),
                ColumnCount = 1,
                RowCount = 2
            };
            accountMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            accountMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            Button changeLogin = CreateBottomNavButton(
                "Change login", Properties.Resources._lock, ShowCredentialChange);
            Button logout = CreateBottomNavButton(
                "Log out",
                resources.GetObject("Logout.Image") as Image ?? Properties.Resources.enter,
                Logout);
            accountMenu.Controls.Add(changeLogin, 0, 0);
            accountMenu.Controls.Add(logout, 0, 1);
            sidebar.Controls.Add(accountMenu, 0, 2);
            return sidebar;
        }

        private Button CreateBottomNavButton(string text, Image icon, Action action)
        {
            Button button = new()
            {
                Text = text,
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 2, 0, 2),
                FlatStyle = FlatStyle.Flat,
                BackColor = paleBlue,
                ForeColor = Color.FromArgb(30, 45, 55),
                Font = new Font("Segoe UI", 10.5F),
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleLeft,
                ImageAlign = ContentAlignment.MiddleLeft,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Image = icon,
                Padding = new Padding(10, 0, 0, 0)
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += (_, _) => action();
            return button;
        }

        private Button CreateNavButton(string text, Action? action, bool selected = false)
        {
            Button button = new()
            {
                Text = text,
                Width = 180,
                Height = 50,
                Margin = new Padding(0, 4, 0, 4),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(18, 0, 0, 0),
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10.5F,
                    selected ? FontStyle.Bold : FontStyle.Regular),
                BackColor = selected ? navy : paleBlue,
                ForeColor = selected ? Color.White : Color.FromArgb(30, 45, 55)
            };
            button.FlatAppearance.BorderSize = 0;
            if (action != null)
                button.Click += (_, _) => action();
            return button;
        }

        private Panel BuildPatientList()
        {
            Panel card = CreateCard();
            card.Margin = new Padding(0, 0, 12, 0);

            TableLayoutPanel listLayout = new()
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                ColumnCount = 1,
                RowCount = 2
            };
            listLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            listLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            Panel searchArea = new()
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = new Padding(20, 14, 20, 10),
                BackColor = Color.White
            };
            searchArea.Controls.Add(new Label
            {
                Text = "Search patients",
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = navy,
                Location = new Point(20, 12)
            });
            txtSearch.PlaceholderText = "Patient ID or name, e.g. PATIENT001 or Nomvula Zulu";
            txtSearch.Location = new Point(20, 50);
            txtSearch.Width = 380;
            txtSearch.TextChanged += (_, _) => LoadPatients(txtSearch.Text.Trim());
            txtSearch.KeyDown += (_, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LoadPatients(txtSearch.Text.Trim());
                    e.SuppressKeyPress = true;
                }
            };

            Button search = CreateActionButton("Search", blue, 90);
            search.Location = new Point(415, 47);
            search.Click += (_, _) => LoadPatients(txtSearch.Text.Trim());
            Button clearSearch = CreateActionButton("Clear", Color.Gray, 80);
            clearSearch.Location = new Point(515, 47);
            clearSearch.Click += (_, _) =>
            {
                txtSearch.Clear();
                LoadPatients();
                txtSearch.Focus();
            };
            searchArea.Controls.Add(txtSearch);
            searchArea.Controls.Add(search);
            searchArea.Controls.Add(clearSearch);
            listLayout.Controls.Add(searchArea, 0, 0);

            patientGrid.Dock = DockStyle.Fill;
            patientGrid.BackgroundColor = Color.White;
            patientGrid.BorderStyle = BorderStyle.None;
            patientGrid.ReadOnly = true;
            patientGrid.AllowUserToAddRows = false;
            patientGrid.AllowUserToDeleteRows = false;
            patientGrid.AllowUserToResizeRows = false;
            patientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            patientGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientGrid.MultiSelect = false;
            patientGrid.RowHeadersVisible = false;
            patientGrid.RowTemplate.Height = 34;
            patientGrid.EnableHeadersVisualStyles = false;
            patientGrid.ColumnHeadersHeight = 42;
            patientGrid.ColumnHeadersDefaultCellStyle.BackColor = navy;
            patientGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            patientGrid.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Bold);
            patientGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 230, 244);
            patientGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            patientGrid.CellClick += PatientGrid_CellClick;
            listLayout.Controls.Add(patientGrid, 0, 1);
            card.Controls.Add(listLayout);
            return card;
        }

        private Panel BuildPatientEditor()
        {
            Panel card = CreateCard();
            card.Margin = new Padding(12, 0, 0, 0);
            card.AutoScroll = true;
            card.Controls.Add(new Label
            {
                Text = "Patient details",
                AutoSize = true,
                Font = new Font("Segoe UI", 17F, FontStyle.Bold),
                ForeColor = navy,
                Location = new Point(24, 18)
            });

            lblPatientNumber.Text = "Patient ID: Generated automatically";
            lblPatientNumber.AutoSize = true;
            lblPatientNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPatientNumber.ForeColor = blue;
            lblPatientNumber.Location = new Point(26, 55);
            card.Controls.Add(lblPatientNumber);

            lblRegisteredAt.Text = "Date added: Recorded automatically";
            lblRegisteredAt.AutoSize = true;
            lblRegisteredAt.Font = new Font("Segoe UI", 9F);
            lblRegisteredAt.ForeColor = Color.DimGray;
            lblRegisteredAt.Location = new Point(26, 78);
            card.Controls.Add(lblRegisteredAt);

            int y = 108;
            AddField(card, "Name *", txtFirstName, ref y);
            AddField(card, "Surname *", txtLastName, ref y);
            cmbIdentificationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdentificationType.Items.AddRange(new object[] { "SA ID", "Passport" });
            cmbIdentificationType.SelectedIndex = 0;
            AddField(card, "Identification type *", cmbIdentificationType, ref y);
            AddField(card, "ID / Passport number *", txtIdentificationNumber, ref y);
            AddField(card, "Contact number *", txtContactNumber, ref y);
            AddField(card, "Emergency contact number *", txtEmergencyNumber, ref y);

            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.MaxDate = DateTime.Today;
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-18);
            AddField(card, "Date of birth *", dtpDateOfBirth, ref y);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Female", "Male", "Other", "Prefer not to say" });
            cmbGender.SelectedIndex = 0;
            AddField(card, "Gender *", cmbGender, ref y);
            AddField(card, "Address", txtAddress, ref y);

            FlowLayoutPanel actions = new()
            {
                Location = new Point(24, y + 4),
                Width = 360,
                Height = 52,
                FlowDirection = FlowDirection.LeftToRight
            };
            Button save = CreateActionButton("Save patient", navy, 130);
            Button clear = CreateActionButton("New / Clear", Color.Gray, 115);
            save.Click += SavePatient_Click;
            clear.Click += (_, _) => ClearEditor();
            actions.Controls.Add(save);
            actions.Controls.Add(clear);
            card.Controls.Add(actions);

            lblStatus.Location = new Point(24, y + 62);
            lblStatus.AutoSize = true;
            lblStatus.MaximumSize = new Size(370, 0);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Text = "Enter the patient information, then select Save patient.";
            card.Controls.Add(lblStatus);
            return card;
        }

        private static Panel CreateCard()
        {
            return new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        private static void AddField(Control parent, string labelText, Control input, ref int y)
        {
            parent.Controls.Add(new Label
            {
                Text = labelText,
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 55, 65),
                Location = new Point(24, y)
            });
            input.Location = new Point(24, y + 24);
            input.Width = 350;
            parent.Controls.Add(input);
            y += 65;
        }

        private static Button CreateActionButton(string text, Color backColor, int width)
        {
            Button button = new()
            {
                Text = text,
                Width = width,
                Height = 38,
                BackColor = backColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 8, 8)
            };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private void LoadPatients(string search = "")
        {
            if (Session.CurrentReceptionist == null ||
                !Session.CurrentReceptionist.IsReceptionist())
                return;

            try
            {
                using MySqlConnection conn = DatabaseHelper.GetConnection();
                const string sql = @"
                    SELECT PatientID AS InternalID,
                           CONCAT('PATIENT', LPAD(PatientID, 3, '0')) AS `Patient ID`,
                           FirstName AS Name,
                           LastName AS Surname,
                           IdentificationType AS `ID type`,
                           IdentificationNumber AS `ID / Passport`,
                           ContactNumber AS Contact,
                           EmergencyContactNumber AS Emergency,
                           DateOfBirth AS `Date of birth`,
                           Gender, Address, RegisteredDate AS `Date added`
                    FROM Patient
                    WHERE @Search = ''
                       OR UPPER(FirstName) LIKE @Pattern
                       OR UPPER(LastName) LIKE @Pattern
                       OR UPPER(CONCAT(FirstName, ' ', LastName)) LIKE @Pattern
                       OR UPPER(CONCAT(LastName, ' ', FirstName)) LIKE @Pattern
                       OR UPPER(IdentificationNumber) LIKE @Pattern
                       OR UPPER(REPLACE(CONCAT('PATIENT', LPAD(PatientID, 3, '0')), ' ', ''))
                          LIKE @CodePattern
                       OR CAST(PatientID AS CHAR) = @NumericID
                    ORDER BY PatientID DESC";

                string code = search.Replace(" ", "").Replace("-", "").ToUpperInvariant();
                string digits = new string(search.Where(char.IsDigit).ToArray());
                using MySqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@Search", search);
                cmd.Parameters.AddWithValue("@Pattern", $"%{search.ToUpperInvariant()}%");
                cmd.Parameters.AddWithValue("@CodePattern", $"%{code}%");
                cmd.Parameters.AddWithValue("@NumericID", digits);

                DataTable table = new();
                using MySqlDataAdapter adapter = new(cmd);
                adapter.Fill(table);
                patientGrid.DataSource = table;

                if (patientGrid.Columns.Contains("InternalID"))
                    patientGrid.Columns["InternalID"].Visible = false;
                if (patientGrid.Columns.Contains("Address"))
                    patientGrid.Columns["Address"].Visible = false;
                if (patientGrid.Columns.Contains("ID type"))
                    patientGrid.Columns["ID type"].Visible = false;
                if (patientGrid.Columns.Contains("Date of birth"))
                    patientGrid.Columns["Date of birth"].Visible = false;
                if (patientGrid.Columns.Contains("Gender"))
                    patientGrid.Columns["Gender"].Visible = false;
                if (patientGrid.Columns.Contains("Date added"))
                {
                    patientGrid.Columns["Date added"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                    patientGrid.Columns["Date added"].MinimumWidth = 135;
                }
                lblStatus.Text = $"{table.Rows.Count} patient record(s) found.";
            }
            catch (MySqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void PatientGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = patientGrid.Rows[e.RowIndex];
            selectedPatientId = Convert.ToInt32(row.Cells["InternalID"].Value);
            lblPatientNumber.Text = "Patient ID: " + Convert.ToString(row.Cells["Patient ID"].Value);
            lblRegisteredAt.Text = "Date added: " +
                Convert.ToDateTime(row.Cells["Date added"].Value).ToString("dd MMM yyyy, HH:mm");
            txtFirstName.Text = Convert.ToString(row.Cells["Name"].Value);
            txtLastName.Text = Convert.ToString(row.Cells["Surname"].Value);
            cmbIdentificationType.Text = Convert.ToString(row.Cells["ID type"].Value);
            txtIdentificationNumber.Text = Convert.ToString(row.Cells["ID / Passport"].Value);
            txtContactNumber.Text = Convert.ToString(row.Cells["Contact"].Value);
            txtEmergencyNumber.Text = Convert.ToString(row.Cells["Emergency"].Value);
            dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["Date of birth"].Value);
            cmbGender.Text = Convert.ToString(row.Cells["Gender"].Value);
            txtAddress.Text = Convert.ToString(row.Cells["Address"].Value);
            lblStatus.Text = "Patient selected. Update details and click Save patient if needed.";
        }

        private void SavePatient_Click(object? sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string identificationNumber = txtIdentificationNumber.Text.Trim();
            string contact = txtContactNumber.Text.Trim();
            string emergency = txtEmergencyNumber.Text.Trim();

            if (firstName.Length == 0 || lastName.Length == 0 ||
                identificationNumber.Length == 0 || contact.Length == 0 || emergency.Length == 0)
            {
                MessageBox.Show("Complete all fields marked with *.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbIdentificationType.Text == "SA ID" &&
                (identificationNumber.Length != 13 || !identificationNumber.All(char.IsDigit)))
            {
                MessageBox.Show("A South African ID number must contain exactly 13 digits.",
                    "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using MySqlConnection conn = DatabaseHelper.GetConnection();
                using MySqlCommand cmd = conn.CreateCommand();
                if (selectedPatientId == 0)
                {
                    cmd.CommandText = @"
                        INSERT INTO Patient
                            (FirstName, LastName, DateOfBirth, Gender, IdentificationType,
                             IdentificationNumber, ContactNumber, EmergencyContactNumber,
                             Address, RegisteredDate)
                        VALUES
                            (@FirstName, @LastName, @DateOfBirth, @Gender, @IdentificationType,
                             @IdentificationNumber, @ContactNumber, @EmergencyNumber,
                             @Address, CURRENT_TIMESTAMP)";
                }
                else
                {
                    cmd.CommandText = @"
                        UPDATE Patient
                        SET FirstName = @FirstName, LastName = @LastName,
                            DateOfBirth = @DateOfBirth, Gender = @Gender,
                            IdentificationType = @IdentificationType,
                            IdentificationNumber = @IdentificationNumber,
                            ContactNumber = @ContactNumber,
                            EmergencyContactNumber = @EmergencyNumber, Address = @Address
                        WHERE PatientID = @PatientID";
                    cmd.Parameters.AddWithValue("@PatientID", selectedPatientId);
                }

                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.Date);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@IdentificationType", cmbIdentificationType.Text);
                cmd.Parameters.AddWithValue("@IdentificationNumber", identificationNumber);
                cmd.Parameters.AddWithValue("@ContactNumber", contact);
                cmd.Parameters.AddWithValue("@EmergencyNumber", emergency);
                cmd.Parameters.AddWithValue("@Address",
                    string.IsNullOrWhiteSpace(txtAddress.Text) ? DBNull.Value : txtAddress.Text.Trim());
                cmd.ExecuteNonQuery();

                long savedId = selectedPatientId == 0 ? cmd.LastInsertedId : selectedPatientId;
                string patientCode = $"PATIENT{savedId:000}";
                string message = selectedPatientId == 0
                    ? $"Patient registered successfully.\n\nGenerated patient ID: {patientCode}"
                    : $"{patientCode} was updated successfully.";
                MessageBox.Show(message, "Patient Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEditor();
                LoadPatients(txtSearch.Text.Trim());
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("A patient with that ID or passport number already exists.",
                    "Duplicate Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void ClearEditor()
        {
            selectedPatientId = 0;
            lblPatientNumber.Text = "Patient ID: Generated automatically";
            lblRegisteredAt.Text = "Date added: Recorded automatically";
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbIdentificationType.SelectedIndex = 0;
            txtIdentificationNumber.Clear();
            txtContactNumber.Clear();
            txtEmergencyNumber.Clear();
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-18);
            cmbGender.SelectedIndex = 0;
            txtAddress.Clear();
            patientGrid.ClearSelection();
            lblStatus.Text = "Ready to register a new patient.";
            txtFirstName.Focus();
        }

        private void ShowCredentialChange()
        {
            if (Session.CurrentReceptionist == null ||
                !Session.CurrentReceptionist.IsReceptionist())
                return;
            using CredentialChangeForm form =
                new CredentialChangeForm(Session.CurrentReceptionist, false);
            form.ShowDialog(this);
        }

        private static void ShowDatabaseError(MySqlException ex)
        {
            MessageBox.Show("The database operation could not be completed.\n\n" + ex.Message,
                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Logout()
        {
            Session.Logout();
            new Login().Show();
            Close();
        }

        private void DenyAccess()
        {
            MessageBox.Show("Only a logged-in receptionist can use Reception Management.",
                "Receptionist Access Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (Session.CurrentReceptionist?.IsAdministrator() == true)
                new home().Show();
            else
                new Login().Show();
            Close();
        }
    }
}
