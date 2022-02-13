
namespace Log_In
{
    partial class ReservesAdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservesAdminInterface));
            this.dataGridViewReserves = new System.Windows.Forms.DataGridView();
            this.deleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserves)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReserves
            // 
            this.dataGridViewReserves.AllowUserToAddRows = false;
            this.dataGridViewReserves.AllowUserToDeleteRows = false;
            this.dataGridViewReserves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserves.Location = new System.Drawing.Point(43, 77);
            this.dataGridViewReserves.Name = "dataGridViewReserves";
            this.dataGridViewReserves.ReadOnly = true;
            this.dataGridViewReserves.RowHeadersWidth = 51;
            this.dataGridViewReserves.RowTemplate.Height = 24;
            this.dataGridViewReserves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReserves.Size = new System.Drawing.Size(830, 399);
            this.dataGridViewReserves.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Activecolor = System.Drawing.Color.Red;
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.BorderRadius = 5;
            this.deleteButton.ButtonText = "Șterge ";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DisabledColor = System.Drawing.Color.Gray;
            this.deleteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteButton.Iconimage")));
            this.deleteButton.Iconimage_right = null;
            this.deleteButton.Iconimage_right_Selected = null;
            this.deleteButton.Iconimage_Selected = null;
            this.deleteButton.IconMarginLeft = 0;
            this.deleteButton.IconMarginRight = 0;
            this.deleteButton.IconRightVisible = true;
            this.deleteButton.IconRightZoom = 0D;
            this.deleteButton.IconVisible = true;
            this.deleteButton.IconZoom = 90D;
            this.deleteButton.IsTab = false;
            this.deleteButton.Location = new System.Drawing.Point(908, 250);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Normalcolor = System.Drawing.Color.Red;
            this.deleteButton.OnHovercolor = System.Drawing.Color.Red;
            this.deleteButton.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteButton.selected = false;
            this.deleteButton.Size = new System.Drawing.Size(187, 53);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Șterge ";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteButton.Textcolor = System.Drawing.Color.White;
            this.deleteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ReservesAdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1132, 565);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridViewReserves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservesAdminInterface";
            this.Text = "ReservesAdminInterface";
            this.Load += new System.EventHandler(this.ReservesAdminInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReserves;
        private Bunifu.Framework.UI.BunifuFlatButton deleteButton;
    }
}