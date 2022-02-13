
namespace Log_In
{
    partial class Reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDatepickerCome = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDatepickerLeft = new Bunifu.Framework.UI.BunifuDatepicker();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalPlatalabel = new System.Windows.Forms.Label();
            this.totalPlată = new System.Windows.Forms.Label();
            this.reserveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AccountBalance = new System.Windows.Forms.Label();
            this.AccountBalanceLabel = new System.Windows.Forms.Label();
            this.DateAvertisement = new System.Windows.Forms.Label();
            this.labelLei = new System.Windows.Forms.Label();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.TypeCameraAdvertisement = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data sosirii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data plecării";
            // 
            // bunifuDatepickerCome
            // 
            this.bunifuDatepickerCome.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepickerCome.BorderRadius = 0;
            this.bunifuDatepickerCome.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepickerCome.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepickerCome.FormatCustom = null;
            this.bunifuDatepickerCome.Location = new System.Drawing.Point(46, 185);
            this.bunifuDatepickerCome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepickerCome.Name = "bunifuDatepickerCome";
            this.bunifuDatepickerCome.Size = new System.Drawing.Size(300, 42);
            this.bunifuDatepickerCome.TabIndex = 4;
            this.bunifuDatepickerCome.Value = new System.DateTime(2022, 1, 16, 14, 9, 58, 463);
            this.bunifuDatepickerCome.onValueChanged += new System.EventHandler(this.bunifuDatepickerCome_onValueChanged);
            // 
            // bunifuDatepickerLeft
            // 
            this.bunifuDatepickerLeft.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepickerLeft.BorderRadius = 0;
            this.bunifuDatepickerLeft.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepickerLeft.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepickerLeft.FormatCustom = null;
            this.bunifuDatepickerLeft.Location = new System.Drawing.Point(440, 185);
            this.bunifuDatepickerLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepickerLeft.Name = "bunifuDatepickerLeft";
            this.bunifuDatepickerLeft.Size = new System.Drawing.Size(300, 42);
            this.bunifuDatepickerLeft.TabIndex = 5;
            this.bunifuDatepickerLeft.Value = new System.DateTime(2022, 1, 16, 14, 9, 58, 463);
            this.bunifuDatepickerLeft.onValueChanged += new System.EventHandler(this.bunifuDatepickerLeft_onValueChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(826, 196);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(277, 30);
            this.metroComboBox1.TabIndex = 6;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(826, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipul camerei";
            // 
            // TotalPlatalabel
            // 
            this.TotalPlatalabel.AutoSize = true;
            this.TotalPlatalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPlatalabel.Location = new System.Drawing.Point(671, 564);
            this.TotalPlatalabel.Name = "TotalPlatalabel";
            this.TotalPlatalabel.Size = new System.Drawing.Size(92, 20);
            this.TotalPlatalabel.TabIndex = 8;
            this.TotalPlatalabel.Text = "Total plată:";
            // 
            // totalPlată
            // 
            this.totalPlată.AutoSize = true;
            this.totalPlată.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPlată.Location = new System.Drawing.Point(767, 564);
            this.totalPlată.Name = "totalPlată";
            this.totalPlată.Size = new System.Drawing.Size(87, 20);
            this.totalPlată.TabIndex = 9;
            this.totalPlată.Text = "Total plată";
            this.totalPlată.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.Firebrick;
            this.reserveButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.reserveButton.Location = new System.Drawing.Point(919, 540);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(206, 64);
            this.reserveButton.TabIndex = 10;
            this.reserveButton.Text = "Rezervă";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AccountBalance);
            this.panel1.Controls.Add(this.profilePictureBox);
            this.panel1.Controls.Add(this.AccountBalanceLabel);
            this.panel1.Location = new System.Drawing.Point(854, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 80);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(249, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "lei";
            // 
            // AccountBalance
            // 
            this.AccountBalance.AutoSize = true;
            this.AccountBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.AccountBalance.Location = new System.Drawing.Point(216, 32);
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Size = new System.Drawing.Size(46, 17);
            this.AccountBalance.TabIndex = 2;
            this.AccountBalance.Text = "label6";
            // 
            // AccountBalanceLabel
            // 
            this.AccountBalanceLabel.AutoSize = true;
            this.AccountBalanceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AccountBalanceLabel.Location = new System.Drawing.Point(92, 32);
            this.AccountBalanceLabel.Name = "AccountBalanceLabel";
            this.AccountBalanceLabel.Size = new System.Drawing.Size(118, 17);
            this.AccountBalanceLabel.TabIndex = 0;
            this.AccountBalanceLabel.Text = "Account Balance:";
            // 
            // DateAvertisement
            // 
            this.DateAvertisement.AutoSize = true;
            this.DateAvertisement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAvertisement.ForeColor = System.Drawing.Color.Red;
            this.DateAvertisement.Location = new System.Drawing.Point(302, 242);
            this.DateAvertisement.Name = "DateAvertisement";
            this.DateAvertisement.Size = new System.Drawing.Size(176, 20);
            this.DateAvertisement.TabIndex = 12;
            this.DateAvertisement.Text = "Selectati corect datele";
            // 
            // labelLei
            // 
            this.labelLei.AutoSize = true;
            this.labelLei.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLei.Location = new System.Drawing.Point(828, 564);
            this.labelLei.Name = "labelLei";
            this.labelLei.Size = new System.Drawing.Size(26, 20);
            this.labelLei.TabIndex = 13;
            this.labelLei.Text = "lei";
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.ColumnHeadersHeight = 29;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRooms.Location = new System.Drawing.Point(150, 275);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(825, 242);
            this.dataGridViewRooms.TabIndex = 14;
            // 
            // TypeCameraAdvertisement
            // 
            this.TypeCameraAdvertisement.AutoSize = true;
            this.TypeCameraAdvertisement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCameraAdvertisement.ForeColor = System.Drawing.Color.Red;
            this.TypeCameraAdvertisement.Location = new System.Drawing.Point(822, 242);
            this.TypeCameraAdvertisement.Name = "TypeCameraAdvertisement";
            this.TypeCameraAdvertisement.Size = new System.Drawing.Size(175, 20);
            this.TypeCameraAdvertisement.TabIndex = 15;
            this.TypeCameraAdvertisement.Text = "Selectati tipul camerei";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(16, 11);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(59, 54);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1148, 614);
            this.Controls.Add(this.TypeCameraAdvertisement);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.labelLei);
            this.Controls.Add(this.DateAvertisement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.totalPlată);
            this.Controls.Add(this.TotalPlatalabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.bunifuDatepickerLeft);
            this.Controls.Add(this.bunifuDatepickerCome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepickerCome;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepickerLeft;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalPlatalabel;
        private System.Windows.Forms.Label totalPlată;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AccountBalance;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label AccountBalanceLabel;
        private System.Windows.Forms.Label DateAvertisement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLei;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Label TypeCameraAdvertisement;
    }
}