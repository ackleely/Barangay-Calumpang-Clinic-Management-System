namespace Brgy_Clinic_Design
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Edit = new Guna.UI2.WinForms.Guna2Button();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.PrescriptionMedicineTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NurseIDCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PatientIDCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PrescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.PrescriptionDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchFunctionTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Print = new Guna.UI2.WinForms.Guna2Button();
            this.PrescriptionIDTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.Edit);
            this.guna2GroupBox2.Controls.Add(this.Add);
            this.guna2GroupBox2.Controls.Add(this.PrescriptionMedicineTB);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(472, 129);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(534, 263);
            this.guna2GroupBox2.TabIndex = 55;
            this.guna2GroupBox2.Text = "Patient Medicine";
            // 
            // Edit
            // 
            this.Edit.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.Edit.Location = new System.Drawing.Point(440, 159);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(65, 60);
            this.Edit.TabIndex = 69;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Animated = true;
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.BorderColor = System.Drawing.Color.White;
            this.Add.BorderRadius = 30;
            this.Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add.FillColor = System.Drawing.Color.White;
            this.Add.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageSize = new System.Drawing.Size(65, 60);
            this.Add.Location = new System.Drawing.Point(440, 84);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 68);
            this.Add.TabIndex = 39;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // PrescriptionMedicineTB
            // 
            this.PrescriptionMedicineTB.Animated = true;
            this.PrescriptionMedicineTB.BorderColor = System.Drawing.Color.Black;
            this.PrescriptionMedicineTB.BorderRadius = 20;
            this.PrescriptionMedicineTB.BorderThickness = 2;
            this.PrescriptionMedicineTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrescriptionMedicineTB.CustomizableEdges.TopLeft = false;
            this.PrescriptionMedicineTB.DefaultText = "";
            this.PrescriptionMedicineTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrescriptionMedicineTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrescriptionMedicineTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrescriptionMedicineTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrescriptionMedicineTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PrescriptionMedicineTB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PrescriptionMedicineTB.ForeColor = System.Drawing.Color.Black;
            this.PrescriptionMedicineTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrescriptionMedicineTB.Location = new System.Drawing.Point(42, 89);
            this.PrescriptionMedicineTB.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.PrescriptionMedicineTB.Name = "PrescriptionMedicineTB";
            this.PrescriptionMedicineTB.PasswordChar = '\0';
            this.PrescriptionMedicineTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.PrescriptionMedicineTB.PlaceholderText = "";
            this.PrescriptionMedicineTB.SelectedText = "";
            this.PrescriptionMedicineTB.Size = new System.Drawing.Size(376, 127);
            this.PrescriptionMedicineTB.TabIndex = 25;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(42, 60);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(98, 22);
            this.guna2HtmlLabel4.TabIndex = 33;
            this.guna2HtmlLabel4.Text = "M e d i c i n e";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.NurseIDCB);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.PatientIDCB);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(40, 129);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(382, 263);
            this.guna2GroupBox1.TabIndex = 61;
            this.guna2GroupBox1.Text = "Select Patient";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(30, 159);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 22);
            this.guna2HtmlLabel1.TabIndex = 36;
            this.guna2HtmlLabel1.Text = "V o l u n t e e r";
            // 
            // NurseIDCB
            // 
            this.NurseIDCB.AutoRoundedCorners = true;
            this.NurseIDCB.BackColor = System.Drawing.Color.Transparent;
            this.NurseIDCB.BorderColor = System.Drawing.Color.Black;
            this.NurseIDCB.BorderRadius = 17;
            this.NurseIDCB.BorderThickness = 2;
            this.NurseIDCB.CustomizableEdges.BottomRight = false;
            this.NurseIDCB.CustomizableEdges.TopLeft = false;
            this.NurseIDCB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NurseIDCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NurseIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NurseIDCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseIDCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseIDCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NurseIDCB.ForeColor = System.Drawing.Color.Black;
            this.NurseIDCB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NurseIDCB.ItemHeight = 30;
            this.NurseIDCB.Location = new System.Drawing.Point(30, 183);
            this.NurseIDCB.Margin = new System.Windows.Forms.Padding(4);
            this.NurseIDCB.Name = "NurseIDCB";
            this.NurseIDCB.Size = new System.Drawing.Size(318, 36);
            this.NurseIDCB.TabIndex = 35;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(30, 54);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(137, 22);
            this.guna2HtmlLabel6.TabIndex = 34;
            this.guna2HtmlLabel6.Text = "P a t i e n t N a m e";
            // 
            // PatientIDCB
            // 
            this.PatientIDCB.AutoRoundedCorners = true;
            this.PatientIDCB.BackColor = System.Drawing.Color.Transparent;
            this.PatientIDCB.BorderColor = System.Drawing.Color.Black;
            this.PatientIDCB.BorderRadius = 17;
            this.PatientIDCB.BorderThickness = 2;
            this.PatientIDCB.CustomizableEdges.BottomRight = false;
            this.PatientIDCB.CustomizableEdges.TopLeft = false;
            this.PatientIDCB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PatientIDCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatientIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientIDCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientIDCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientIDCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PatientIDCB.ForeColor = System.Drawing.Color.Black;
            this.PatientIDCB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PatientIDCB.ItemHeight = 30;
            this.PatientIDCB.Location = new System.Drawing.Point(30, 82);
            this.PatientIDCB.Margin = new System.Windows.Forms.Padding(4);
            this.PatientIDCB.Name = "PatientIDCB";
            this.PatientIDCB.Size = new System.Drawing.Size(318, 36);
            this.PatientIDCB.TabIndex = 32;
            // 
            // PrescriptionRTB
            // 
            this.PrescriptionRTB.Location = new System.Drawing.Point(1091, 421);
            this.PrescriptionRTB.Margin = new System.Windows.Forms.Padding(4);
            this.PrescriptionRTB.Name = "PrescriptionRTB";
            this.PrescriptionRTB.Size = new System.Drawing.Size(400, 432);
            this.PrescriptionRTB.TabIndex = 62;
            this.PrescriptionRTB.Text = "";
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button4.BorderRadius = 30;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Empty;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button4.Location = new System.Drawing.Point(327, 1106);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(279, 78);
            this.guna2Button4.TabIndex = 64;
            this.guna2Button4.Text = "Edit";
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button5.BorderRadius = 30;
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(104)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.Location = new System.Drawing.Point(648, 1106);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(279, 78);
            this.guna2Button5.TabIndex = 63;
            this.guna2Button5.Text = "Delete";
            // 
            // PrescriptionDGV
            // 
            this.PrescriptionDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PrescriptionDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PrescriptionDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrescriptionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PrescriptionDGV.ColumnHeadersHeight = 30;
            this.PrescriptionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrescriptionDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrescriptionDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PrescriptionDGV.Location = new System.Drawing.Point(40, 421);
            this.PrescriptionDGV.Name = "PrescriptionDGV";
            this.PrescriptionDGV.ReadOnly = true;
            this.PrescriptionDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrescriptionDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PrescriptionDGV.RowHeadersVisible = false;
            this.PrescriptionDGV.Size = new System.Drawing.Size(966, 432);
            this.PrescriptionDGV.TabIndex = 65;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PrescriptionDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.PrescriptionDGV.ThemeStyle.ReadOnly = true;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PrescriptionDGV.ThemeStyle.RowsStyle.Height = 22;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PrescriptionDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PrescriptionDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescriptionDGV_CellClick);
            this.PrescriptionDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescriptionDGV_CellContentClick);
            // 
            // SearchFunctionTB
            // 
            this.SearchFunctionTB.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.SearchFunctionTB.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.SearchFunctionTB.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SearchFunctionTB.ForeColor = System.Drawing.Color.Black;
            this.SearchFunctionTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchFunctionTB.Location = new System.Drawing.Point(514, 16);
            this.SearchFunctionTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.SearchFunctionTB.Name = "SearchFunctionTB";
            this.SearchFunctionTB.PasswordChar = '\0';
            this.SearchFunctionTB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.SearchFunctionTB.PlaceholderText = "Search";
            this.SearchFunctionTB.SelectedText = "";
            this.SearchFunctionTB.Size = new System.Drawing.Size(838, 50);
            this.SearchFunctionTB.TabIndex = 67;
            this.SearchFunctionTB.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator1.FillThickness = 4;
            this.guna2Separator1.Location = new System.Drawing.Point(-109, 90);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1781, 10);
            this.guna2Separator1.TabIndex = 66;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BorderRadius = 30;
            this.Delete.BorderThickness = 1;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(116)))), ((int)(((byte)(104)))));
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.ImageSize = new System.Drawing.Size(30, 30);
            this.Delete.Location = new System.Drawing.Point(788, 874);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(218, 60);
            this.Delete.TabIndex = 68;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.Transparent;
            this.Print.BorderRadius = 30;
            this.Print.BorderThickness = 1;
            this.Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Print.FillColor = System.Drawing.Color.Peru;
            this.Print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Print.ForeColor = System.Drawing.Color.Black;
            this.Print.ImageSize = new System.Drawing.Size(30, 30);
            this.Print.Location = new System.Drawing.Point(1203, 874);
            this.Print.Margin = new System.Windows.Forms.Padding(4);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(207, 62);
            this.Print.TabIndex = 69;
            this.Print.Text = "Print";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // PrescriptionIDTB
            // 
            this.PrescriptionIDTB.Animated = true;
            this.PrescriptionIDTB.BackColor = System.Drawing.Color.Transparent;
            this.PrescriptionIDTB.BorderColor = System.Drawing.Color.Black;
            this.PrescriptionIDTB.BorderRadius = 20;
            this.PrescriptionIDTB.BorderThickness = 2;
            this.PrescriptionIDTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrescriptionIDTB.CustomizableEdges.TopLeft = false;
            this.PrescriptionIDTB.DefaultText = "";
            this.PrescriptionIDTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PrescriptionIDTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PrescriptionIDTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrescriptionIDTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PrescriptionIDTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrescriptionIDTB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PrescriptionIDTB.ForeColor = System.Drawing.Color.Black;
            this.PrescriptionIDTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PrescriptionIDTB.Location = new System.Drawing.Point(1364, 16);
            this.PrescriptionIDTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PrescriptionIDTB.Name = "PrescriptionIDTB";
            this.PrescriptionIDTB.PasswordChar = '\0';
            this.PrescriptionIDTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.PrescriptionIDTB.PlaceholderText = "Id";
            this.PrescriptionIDTB.SelectedText = "";
            this.PrescriptionIDTB.Size = new System.Drawing.Size(68, 50);
            this.PrescriptionIDTB.TabIndex = 70;
            this.PrescriptionIDTB.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1102, 106);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(371, 362);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 71;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.FillThickness = 4;
            this.guna2VSeparator1.Location = new System.Drawing.Point(1042, 94);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(13, 942);
            this.guna2VSeparator1.TabIndex = 72;
            this.guna2VSeparator1.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Black", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(20, 9);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(400, 91);
            this.guna2HtmlLabel5.TabIndex = 73;
            this.guna2HtmlLabel5.Text = "Prescription";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 1037);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.PrescriptionIDTB);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SearchFunctionTB);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.PrescriptionDGV);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.PrescriptionRTB);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrescriptionForm";
            this.Load += new System.EventHandler(this.PrescriptionForm_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button Add;
        private Guna.UI2.WinForms.Guna2TextBox PrescriptionMedicineTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox PatientIDCB;
        private System.Windows.Forms.RichTextBox PrescriptionRTB;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2DataGridView PrescriptionDGV;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox NurseIDCB;
        private Guna.UI2.WinForms.Guna2TextBox SearchFunctionTB;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button Edit;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Print;
        private Guna.UI2.WinForms.Guna2TextBox PrescriptionIDTB;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}