namespace StudyTracker
{
    partial class MainForm
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
            lblHeading = new Label();
            lblDate = new Label();
            lblHours = new Label();
            lblDescription = new Label();
            txtHours = new TextBox();
            dpDate = new DateTimePicker();
            txtDescription = new TextBox();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(599, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(230, 41);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "ActivityTracker";
            lblHeading.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(41, 139);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(64, 32);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHours.Location = new Point(41, 198);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(91, 32);
            lblHours.TabIndex = 2;
            lblHours.Text = "Hour(s)";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(41, 257);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(135, 32);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtHours
            // 
            txtHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHours.Location = new Point(178, 202);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(140, 39);
            txtHours.TabIndex = 4;
            txtHours.KeyPress += textBox1_KeyPress;
            // 
            // dpDate
            // 
            dpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpDate.Location = new Point(178, 139);
            dpDate.Name = "dpDate";
            dpDate.Size = new Size(300, 39);
            dpDate.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(178, 263);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(381, 123);
            txtDescription.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(178, 411);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 53);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(639, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(543, 421);
            dataGridView1.TabIndex = 8;
            // 
            // btnReset
            // 
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(314, 411);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 53);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 559);
            Controls.Add(btnReset);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(dpDate);
            Controls.Add(txtHours);
            Controls.Add(lblDescription);
            Controls.Add(lblHours);
            Controls.Add(lblDate);
            Controls.Add(lblHeading);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblHeading;
        private Label lblDate;
        private Label lblHours;
        private Label lblDescription;
        private TextBox txtHours;
        private DateTimePicker dpDate;
        private TextBox txtDescription;
        private Button btnSave;
        private DataGridView dataGridView1;
        private Button btnReset;
    }
}