namespace Brgy_Clinic_Design
{
    partial class NurseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.NurseDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchFunctionTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.NursePasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.Edit = new Guna.UI2.WinForms.Guna2Button();
            this.NursePhoneTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.NurseFirstNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.NurseLastNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.NurseBDAY = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.NurseGenderCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NurseAddressCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NurseGB = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CloseGB = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.NurseIdTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddShowGB = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NurseLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EditShowGB = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NurseDGV)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.NurseGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.BorderRadius = 10;
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // Delete
            // 
            this.Delete.BorderRadius = 30;
            this.Delete.BorderThickness = 1;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(104)))));
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.ImageSize = new System.Drawing.Size(30, 30);
            this.Delete.Location = new System.Drawing.Point(1218, 916);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(239, 60);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // NurseDGV
            // 
            this.NurseDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NurseDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NurseDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.NurseDGV.ColumnHeadersHeight = 35;
            this.NurseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NurseDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.NurseDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NurseDGV.Location = new System.Drawing.Point(66, 238);
            this.NurseDGV.Name = "NurseDGV";
            this.NurseDGV.ReadOnly = true;
            this.NurseDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NurseDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.NurseDGV.RowHeadersVisible = false;
            this.NurseDGV.Size = new System.Drawing.Size(1415, 635);
            this.NurseDGV.TabIndex = 13;
            this.NurseDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.NurseDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.NurseDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.NurseDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.NurseDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.NurseDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.NurseDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NurseDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NurseDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.NurseDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NurseDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.NurseDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.NurseDGV.ThemeStyle.HeaderStyle.Height = 35;
            this.NurseDGV.ThemeStyle.ReadOnly = true;
            this.NurseDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.NurseDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.NurseDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NurseDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NurseDGV.ThemeStyle.RowsStyle.Height = 22;
            this.NurseDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NurseDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NurseDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NurseDGV_CellClick);
            this.NurseDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NurseDGV_CellContentClick);
            // 
            // SearchFunctionTB
            // 
            this.SearchFunctionTB.Animated = true;
            this.SearchFunctionTB.BorderColor = System.Drawing.Color.Black;
            this.SearchFunctionTB.BorderRadius = 20;
            this.SearchFunctionTB.BorderThickness = 2;
            this.SearchFunctionTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchFunctionTB.CustomizableEdges.TopRight = false;
            this.SearchFunctionTB.DefaultText = "";
            this.SearchFunctionTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchFunctionTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchFunctionTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchFunctionTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchFunctionTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchFunctionTB.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SearchFunctionTB.ForeColor = System.Drawing.Color.Black;
            this.SearchFunctionTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchFunctionTB.Location = new System.Drawing.Point(312, 29);
            this.SearchFunctionTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.SearchFunctionTB.Name = "SearchFunctionTB";
            this.SearchFunctionTB.PasswordChar = '\0';
            this.SearchFunctionTB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.SearchFunctionTB.PlaceholderText = "Search";
            this.SearchFunctionTB.SelectedText = "";
            this.SearchFunctionTB.Size = new System.Drawing.Size(1000, 50);
            this.SearchFunctionTB.TabIndex = 16;
            this.SearchFunctionTB.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.NursePasswordTB);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(48, 449);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(441, 174);
            this.guna2GroupBox2.TabIndex = 36;
            this.guna2GroupBox2.Text = "Create Password";
            // 
            // NursePasswordTB
            // 
            this.NursePasswordTB.Animated = true;
            this.NursePasswordTB.BorderColor = System.Drawing.Color.Black;
            this.NursePasswordTB.BorderRadius = 20;
            this.NursePasswordTB.BorderThickness = 2;
            this.NursePasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NursePasswordTB.CustomizableEdges.TopLeft = false;
            this.NursePasswordTB.DefaultText = "";
            this.NursePasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NursePasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NursePasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NursePasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NursePasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NursePasswordTB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NursePasswordTB.ForeColor = System.Drawing.Color.Black;
            this.NursePasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NursePasswordTB.Location = new System.Drawing.Point(111, 88);
            this.NursePasswordTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.NursePasswordTB.Name = "NursePasswordTB";
            this.NursePasswordTB.PasswordChar = '\0';
            this.NursePasswordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NursePasswordTB.PlaceholderText = "Password";
            this.NursePasswordTB.SelectedText = "";
            this.NursePasswordTB.Size = new System.Drawing.Size(222, 50);
            this.NursePasswordTB.TabIndex = 25;
            this.NursePasswordTB.TextChanged += new System.EventHandler(this.NursePasswordTB_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.BorderRadius = 30;
            this.Add.BorderThickness = 1;
            this.Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.Add.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.ImageSize = new System.Drawing.Size(30, 30);
            this.Add.Location = new System.Drawing.Point(246, 641);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(65, 62);
            this.Add.TabIndex = 39;
            this.Add.Text = "+";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Transparent;
            this.Edit.BorderRadius = 30;
            this.Edit.BorderThickness = 1;
            this.Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Edit.FillColor = System.Drawing.Color.Empty;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Edit.ForeColor = System.Drawing.Color.Black;
            this.Edit.ImageSize = new System.Drawing.Size(30, 30);
            this.Edit.Location = new System.Drawing.Point(160, 643);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(239, 60);
            this.Edit.TabIndex = 12;
            this.Edit.Text = "Save Changes";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // NursePhoneTB
            // 
            this.NursePhoneTB.Animated = true;
            this.NursePhoneTB.BackColor = System.Drawing.Color.Transparent;
            this.NursePhoneTB.BorderColor = System.Drawing.Color.Black;
            this.NursePhoneTB.BorderRadius = 20;
            this.NursePhoneTB.BorderThickness = 2;
            this.NursePhoneTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NursePhoneTB.CustomizableEdges.TopLeft = false;
            this.NursePhoneTB.DefaultText = "";
            this.NursePhoneTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NursePhoneTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NursePhoneTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NursePhoneTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NursePhoneTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NursePhoneTB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NursePhoneTB.ForeColor = System.Drawing.Color.Black;
            this.NursePhoneTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NursePhoneTB.Location = new System.Drawing.Point(30, 380);
            this.NursePhoneTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.NursePhoneTB.Name = "NursePhoneTB";
            this.NursePhoneTB.PasswordChar = '\0';
            this.NursePhoneTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NursePhoneTB.PlaceholderText = "Phone";
            this.NursePhoneTB.SelectedText = "";
            this.NursePhoneTB.Size = new System.Drawing.Size(303, 44);
            this.NursePhoneTB.TabIndex = 23;
            this.NursePhoneTB.TextChanged += new System.EventHandler(this.NursePhoneTB_TextChanged);
            this.NursePhoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NursePhoneTB_KeyPress);
            // 
            // NurseFirstNameTB
            // 
            this.NurseFirstNameTB.Animated = true;
            this.NurseFirstNameTB.BackColor = System.Drawing.Color.Transparent;
            this.NurseFirstNameTB.BorderColor = System.Drawing.Color.Black;
            this.NurseFirstNameTB.BorderRadius = 20;
            this.NurseFirstNameTB.BorderThickness = 2;
            this.NurseFirstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NurseFirstNameTB.CustomizableEdges.TopLeft = false;
            this.NurseFirstNameTB.DefaultText = "";
            this.NurseFirstNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NurseFirstNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NurseFirstNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NurseFirstNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NurseFirstNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NurseFirstNameTB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NurseFirstNameTB.ForeColor = System.Drawing.Color.Black;
            this.NurseFirstNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseFirstNameTB.Location = new System.Drawing.Point(47, 143);
            this.NurseFirstNameTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.NurseFirstNameTB.Name = "NurseFirstNameTB";
            this.NurseFirstNameTB.PasswordChar = '\0';
            this.NurseFirstNameTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NurseFirstNameTB.PlaceholderText = "First Name";
            this.NurseFirstNameTB.SelectedText = "";
            this.NurseFirstNameTB.Size = new System.Drawing.Size(441, 44);
            this.NurseFirstNameTB.TabIndex = 19;
            this.NurseFirstNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NurseFirstNameTB_KeyPress);
            // 
            // NurseLastNameTB
            // 
            this.NurseLastNameTB.Animated = true;
            this.NurseLastNameTB.BackColor = System.Drawing.Color.Transparent;
            this.NurseLastNameTB.BorderColor = System.Drawing.Color.Black;
            this.NurseLastNameTB.BorderRadius = 20;
            this.NurseLastNameTB.BorderThickness = 2;
            this.NurseLastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NurseLastNameTB.CustomizableEdges.TopLeft = false;
            this.NurseLastNameTB.DefaultText = "";
            this.NurseLastNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NurseLastNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NurseLastNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NurseLastNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NurseLastNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NurseLastNameTB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NurseLastNameTB.ForeColor = System.Drawing.Color.Black;
            this.NurseLastNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseLastNameTB.Location = new System.Drawing.Point(48, 73);
            this.NurseLastNameTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.NurseLastNameTB.Name = "NurseLastNameTB";
            this.NurseLastNameTB.PasswordChar = '\0';
            this.NurseLastNameTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NurseLastNameTB.PlaceholderText = "Last Name";
            this.NurseLastNameTB.SelectedText = "";
            this.NurseLastNameTB.Size = new System.Drawing.Size(441, 44);
            this.NurseLastNameTB.TabIndex = 21;
            this.NurseLastNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NurseLastNameTB_KeyPress);
            // 
            // NurseBDAY
            // 
            this.NurseBDAY.Animated = true;
            this.NurseBDAY.AutoRoundedCorners = true;
            this.NurseBDAY.BackColor = System.Drawing.Color.Transparent;
            this.NurseBDAY.BorderRadius = 24;
            this.NurseBDAY.BorderThickness = 2;
            this.NurseBDAY.Checked = true;
            this.NurseBDAY.CustomizableEdges.BottomRight = false;
            this.NurseBDAY.CustomizableEdges.TopLeft = false;
            this.NurseBDAY.FillColor = System.Drawing.Color.White;
            this.NurseBDAY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NurseBDAY.ForeColor = System.Drawing.Color.Black;
            this.NurseBDAY.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.NurseBDAY.Location = new System.Drawing.Point(131, 299);
            this.NurseBDAY.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.NurseBDAY.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.NurseBDAY.Name = "NurseBDAY";
            this.NurseBDAY.Size = new System.Drawing.Size(222, 50);
            this.NurseBDAY.TabIndex = 22;
            this.NurseBDAY.Value = new System.DateTime(2023, 12, 9, 0, 45, 29, 370);
            // 
            // NurseGenderCB
            // 
            this.NurseGenderCB.AutoRoundedCorners = true;
            this.NurseGenderCB.BackColor = System.Drawing.Color.Transparent;
            this.NurseGenderCB.BorderColor = System.Drawing.Color.Black;
            this.NurseGenderCB.BorderRadius = 17;
            this.NurseGenderCB.BorderThickness = 2;
            this.NurseGenderCB.CustomizableEdges.BottomRight = false;
            this.NurseGenderCB.CustomizableEdges.TopLeft = false;
            this.NurseGenderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NurseGenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NurseGenderCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseGenderCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseGenderCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NurseGenderCB.ForeColor = System.Drawing.Color.Black;
            this.NurseGenderCB.ItemHeight = 30;
            this.NurseGenderCB.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.NurseGenderCB.Location = new System.Drawing.Point(111, 230);
            this.NurseGenderCB.Name = "NurseGenderCB";
            this.NurseGenderCB.Size = new System.Drawing.Size(150, 36);
            this.NurseGenderCB.TabIndex = 26;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(30, 299);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(95, 22);
            this.guna2HtmlLabel3.TabIndex = 30;
            this.guna2HtmlLabel3.Text = "B i r t h d a y\r\n";
            // 
            // NurseAddressCB
            // 
            this.NurseAddressCB.AutoRoundedCorners = true;
            this.NurseAddressCB.BackColor = System.Drawing.Color.Transparent;
            this.NurseAddressCB.BorderColor = System.Drawing.Color.Black;
            this.NurseAddressCB.BorderRadius = 17;
            this.NurseAddressCB.BorderThickness = 2;
            this.NurseAddressCB.CustomizableEdges.BottomRight = false;
            this.NurseAddressCB.CustomizableEdges.TopLeft = false;
            this.NurseAddressCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NurseAddressCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NurseAddressCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseAddressCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseAddressCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NurseAddressCB.ForeColor = System.Drawing.Color.Black;
            this.NurseAddressCB.ItemHeight = 30;
            this.NurseAddressCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.NurseAddressCB.Location = new System.Drawing.Point(358, 230);
            this.NurseAddressCB.Name = "NurseAddressCB";
            this.NurseAddressCB.Size = new System.Drawing.Size(110, 36);
            this.NurseAddressCB.TabIndex = 27;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(29, 230);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(76, 22);
            this.guna2HtmlLabel2.TabIndex = 29;
            this.guna2HtmlLabel2.Text = "G e n d e r";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(288, 230);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(64, 22);
            this.guna2HtmlLabel6.TabIndex = 35;
            this.guna2HtmlLabel6.Text = "P u r o k";
            // 
            // NurseGB
            // 
            this.NurseGB.BorderColor = System.Drawing.Color.Black;
            this.NurseGB.BorderRadius = 20;
            this.NurseGB.BorderThickness = 2;
            this.NurseGB.Controls.Add(this.Add);
            this.NurseGB.Controls.Add(this.CloseGB);
            this.NurseGB.Controls.Add(this.NursePhoneTB);
            this.NurseGB.Controls.Add(this.NurseLastNameTB);
            this.NurseGB.Controls.Add(this.NurseFirstNameTB);
            this.NurseGB.Controls.Add(this.NurseBDAY);
            this.NurseGB.Controls.Add(this.NurseAddressCB);
            this.NurseGB.Controls.Add(this.guna2GroupBox2);
            this.NurseGB.Controls.Add(this.NurseGenderCB);
            this.NurseGB.Controls.Add(this.Edit);
            this.NurseGB.Controls.Add(this.guna2HtmlLabel3);
            this.NurseGB.Controls.Add(this.guna2HtmlLabel6);
            this.NurseGB.Controls.Add(this.guna2HtmlLabel2);
            this.NurseGB.CustomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.NurseGB.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.NurseGB.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NurseGB.ForeColor = System.Drawing.Color.Black;
            this.NurseGB.Location = new System.Drawing.Point(557, 159);
            this.NurseGB.Name = "NurseGB";
            this.NurseGB.Size = new System.Drawing.Size(542, 735);
            this.NurseGB.TabIndex = 37;
            this.NurseGB.Text = "Personal Information";
            this.NurseGB.Visible = false;
            // 
            // CloseGB
            // 
            this.CloseGB.BackColor = System.Drawing.Color.Transparent;
            this.CloseGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseGB.FillColor = System.Drawing.Color.Transparent;
            this.CloseGB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseGB.ForeColor = System.Drawing.Color.White;
            this.CloseGB.Image = ((System.Drawing.Image)(resources.GetObject("CloseGB.Image")));
            this.CloseGB.Location = new System.Drawing.Point(495, 12);
            this.CloseGB.Name = "CloseGB";
            this.CloseGB.Size = new System.Drawing.Size(30, 30);
            this.CloseGB.TabIndex = 70;
            this.CloseGB.Click += new System.EventHandler(this.CloseGB_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 99);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1536, 10);
            this.guna2Separator1.TabIndex = 14;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // NurseIdTB
            // 
            this.NurseIdTB.Animated = true;
            this.NurseIdTB.BackColor = System.Drawing.Color.Transparent;
            this.NurseIdTB.BorderColor = System.Drawing.Color.Black;
            this.NurseIdTB.BorderRadius = 20;
            this.NurseIdTB.BorderThickness = 2;
            this.NurseIdTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NurseIdTB.CustomizableEdges.TopLeft = false;
            this.NurseIdTB.DefaultText = "";
            this.NurseIdTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NurseIdTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NurseIdTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NurseIdTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NurseIdTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseIdTB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NurseIdTB.ForeColor = System.Drawing.Color.Black;
            this.NurseIdTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseIdTB.Location = new System.Drawing.Point(1324, 29);
            this.NurseIdTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.NurseIdTB.Name = "NurseIdTB";
            this.NurseIdTB.PasswordChar = '\0';
            this.NurseIdTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NurseIdTB.PlaceholderText = "Id";
            this.NurseIdTB.SelectedText = "";
            this.NurseIdTB.Size = new System.Drawing.Size(68, 50);
            this.NurseIdTB.TabIndex = 64;
            this.NurseIdTB.Visible = false;
            // 
            // AddShowGB
            // 
            this.AddShowGB.BackColor = System.Drawing.Color.Transparent;
            this.AddShowGB.BorderRadius = 30;
            this.AddShowGB.BorderThickness = 1;
            this.AddShowGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddShowGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddShowGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddShowGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddShowGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.AddShowGB.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShowGB.ForeColor = System.Drawing.Color.Black;
            this.AddShowGB.ImageSize = new System.Drawing.Size(30, 30);
            this.AddShowGB.Location = new System.Drawing.Point(1453, 17);
            this.AddShowGB.Name = "AddShowGB";
            this.AddShowGB.Size = new System.Drawing.Size(65, 62);
            this.AddShowGB.TabIndex = 40;
            this.AddShowGB.Text = "+";
            this.AddShowGB.Click += new System.EventHandler(this.AddShowGB_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, -10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(230, 252);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 66;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // NurseLbl
            // 
            this.NurseLbl.BackColor = System.Drawing.Color.Transparent;
            this.NurseLbl.Font = new System.Drawing.Font("Segoe UI Black", 50F);
            this.NurseLbl.Location = new System.Drawing.Point(206, 2);
            this.NurseLbl.Name = "NurseLbl";
            this.NurseLbl.Size = new System.Drawing.Size(75, 91);
            this.NurseLbl.TabIndex = 67;
            this.NurseLbl.Text = "10";
            // 
            // EditShowGB
            // 
            this.EditShowGB.BackColor = System.Drawing.Color.Transparent;
            this.EditShowGB.BorderRadius = 30;
            this.EditShowGB.BorderThickness = 1;
            this.EditShowGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditShowGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditShowGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditShowGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditShowGB.FillColor = System.Drawing.Color.Empty;
            this.EditShowGB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditShowGB.ForeColor = System.Drawing.Color.Black;
            this.EditShowGB.ImageSize = new System.Drawing.Size(30, 30);
            this.EditShowGB.Location = new System.Drawing.Point(945, 916);
            this.EditShowGB.Name = "EditShowGB";
            this.EditShowGB.Size = new System.Drawing.Size(239, 60);
            this.EditShowGB.TabIndex = 68;
            this.EditShowGB.Text = "Edit";
            this.EditShowGB.Click += new System.EventHandler(this.EditShowGB_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Black", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(226, 159);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(332, 91);
            this.guna2HtmlLabel5.TabIndex = 73;
            this.guna2HtmlLabel5.Text = "Nurse List";
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1550, 1037);
            this.Controls.Add(this.EditShowGB);
            this.Controls.Add(this.NurseLbl);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.AddShowGB);
            this.Controls.Add(this.NurseIdTB);
            this.Controls.Add(this.NurseGB);
            this.Controls.Add(this.SearchFunctionTB);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.NurseDGV);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NurseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NurseForm";
            this.Load += new System.EventHandler(this.NurseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NurseDGV)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.NurseGB.ResumeLayout(false);
            this.NurseGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2DataGridView NurseDGV;
        private Guna.UI2.WinForms.Guna2TextBox SearchFunctionTB;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button Edit;
        private Guna.UI2.WinForms.Guna2TextBox NursePhoneTB;
        private Guna.UI2.WinForms.Guna2TextBox NurseFirstNameTB;
        private Guna.UI2.WinForms.Guna2TextBox NurseLastNameTB;
        private Guna.UI2.WinForms.Guna2DateTimePicker NurseBDAY;
        private Guna.UI2.WinForms.Guna2ComboBox NurseGenderCB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox NurseAddressCB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2GroupBox NurseGB;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button Add;
        private Guna.UI2.WinForms.Guna2TextBox NurseIdTB;
        private Guna.UI2.WinForms.Guna2Button AddShowGB;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel NurseLbl;
        private Guna.UI2.WinForms.Guna2TextBox NursePasswordTB;
        private Guna.UI2.WinForms.Guna2Button CloseGB;
        private Guna.UI2.WinForms.Guna2Button EditShowGB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}