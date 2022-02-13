
namespace Log_In
{
    partial class AccountsAdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsAdminInterface));
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.deleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.importXMLButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exportXMLButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(25, 64);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(880, 332);
            this.dataGridViewUsers.TabIndex = 0;
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
            this.deleteButton.Location = new System.Drawing.Point(927, 204);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Normalcolor = System.Drawing.Color.Red;
            this.deleteButton.OnHovercolor = System.Drawing.Color.Red;
            this.deleteButton.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteButton.selected = false;
            this.deleteButton.Size = new System.Drawing.Size(187, 53);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Șterge ";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteButton.Textcolor = System.Drawing.Color.White;
            this.deleteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // importXMLButton
            // 
            this.importXMLButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.importXMLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.importXMLButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.importXMLButton.BorderRadius = 0;
            this.importXMLButton.ButtonText = "Import XML";
            this.importXMLButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importXMLButton.DisabledColor = System.Drawing.Color.Gray;
            this.importXMLButton.Iconcolor = System.Drawing.Color.Transparent;
            this.importXMLButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("importXMLButton.Iconimage")));
            this.importXMLButton.Iconimage_right = null;
            this.importXMLButton.Iconimage_right_Selected = null;
            this.importXMLButton.Iconimage_Selected = null;
            this.importXMLButton.IconMarginLeft = 0;
            this.importXMLButton.IconMarginRight = 0;
            this.importXMLButton.IconRightVisible = true;
            this.importXMLButton.IconRightZoom = 0D;
            this.importXMLButton.IconVisible = true;
            this.importXMLButton.IconZoom = 90D;
            this.importXMLButton.IsTab = false;
            this.importXMLButton.Location = new System.Drawing.Point(97, 427);
            this.importXMLButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.importXMLButton.Name = "importXMLButton";
            this.importXMLButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.importXMLButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.importXMLButton.OnHoverTextColor = System.Drawing.Color.White;
            this.importXMLButton.selected = false;
            this.importXMLButton.Size = new System.Drawing.Size(255, 66);
            this.importXMLButton.TabIndex = 3;
            this.importXMLButton.Text = "Import XML";
            this.importXMLButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importXMLButton.Textcolor = System.Drawing.Color.White;
            this.importXMLButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importXMLButton.Click += new System.EventHandler(this.importXMLButton_Click);
            // 
            // exportXMLButton
            // 
            this.exportXMLButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exportXMLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exportXMLButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportXMLButton.BorderRadius = 0;
            this.exportXMLButton.ButtonText = "Export XML";
            this.exportXMLButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportXMLButton.DisabledColor = System.Drawing.Color.Gray;
            this.exportXMLButton.Iconcolor = System.Drawing.Color.Transparent;
            this.exportXMLButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("exportXMLButton.Iconimage")));
            this.exportXMLButton.Iconimage_right = null;
            this.exportXMLButton.Iconimage_right_Selected = null;
            this.exportXMLButton.Iconimage_Selected = null;
            this.exportXMLButton.IconMarginLeft = 0;
            this.exportXMLButton.IconMarginRight = 0;
            this.exportXMLButton.IconRightVisible = true;
            this.exportXMLButton.IconRightZoom = 0D;
            this.exportXMLButton.IconVisible = true;
            this.exportXMLButton.IconZoom = 90D;
            this.exportXMLButton.IsTab = false;
            this.exportXMLButton.Location = new System.Drawing.Point(394, 427);
            this.exportXMLButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportXMLButton.Name = "exportXMLButton";
            this.exportXMLButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exportXMLButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.exportXMLButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exportXMLButton.selected = false;
            this.exportXMLButton.Size = new System.Drawing.Size(255, 66);
            this.exportXMLButton.TabIndex = 4;
            this.exportXMLButton.Text = "Export XML";
            this.exportXMLButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exportXMLButton.Textcolor = System.Drawing.Color.White;
            this.exportXMLButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportXMLButton.Click += new System.EventHandler(this.exportXMLButton_Click);
            // 
            // AccountsAdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1127, 516);
            this.Controls.Add(this.exportXMLButton);
            this.Controls.Add(this.importXMLButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridViewUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsAdminInterface";
            this.Text = "AccountsAdminInterface";
            this.Load += new System.EventHandler(this.AccountsAdminInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private Bunifu.Framework.UI.BunifuFlatButton deleteButton;
        private Bunifu.Framework.UI.BunifuFlatButton importXMLButton;
        private Bunifu.Framework.UI.BunifuFlatButton exportXMLButton;
    }
}