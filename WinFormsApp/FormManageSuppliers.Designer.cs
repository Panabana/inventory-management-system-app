namespace WinFormsApp
{
    partial class FormManageSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageSuppliers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSupplierAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSupplierPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSupplierId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFindSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxSupplierIdFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExitSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRemoveSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageSupplierssMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSupplierAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSupplierPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSupplierName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSupplierId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New supplier details";
            // 
            // textBoxSupplierAddress
            // 
            this.textBoxSupplierAddress.Location = new System.Drawing.Point(454, 83);
            this.textBoxSupplierAddress.Name = "textBoxSupplierAddress";
            this.textBoxSupplierAddress.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(388, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // textBoxSupplierPhone
            // 
            this.textBoxSupplierPhone.Location = new System.Drawing.Point(110, 83);
            this.textBoxSupplierPhone.Name = "textBoxSupplierPhone";
            this.textBoxSupplierPhone.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone number:";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(454, 34);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(350, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier name:";
            // 
            // textBoxSupplierId
            // 
            this.textBoxSupplierId.Location = new System.Drawing.Point(110, 34);
            this.textBoxSupplierId.Name = "textBoxSupplierId";
            this.textBoxSupplierId.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindSupplier);
            this.groupBox2.Controls.Add(this.textBoxSupplierIdFind);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(15, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 93);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find a supplier";
            // 
            // buttonFindSupplier
            // 
            this.buttonFindSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindSupplier.Appearance.Options.UseFont = true;
            this.buttonFindSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindSupplier.ImageOptions.Image")));
            this.buttonFindSupplier.Location = new System.Drawing.Point(440, 35);
            this.buttonFindSupplier.Name = "buttonFindSupplier";
            this.buttonFindSupplier.Size = new System.Drawing.Size(95, 35);
            this.buttonFindSupplier.TabIndex = 6;
            this.buttonFindSupplier.Text = "Find";
            // 
            // textBoxSupplierIdFind
            // 
            this.textBoxSupplierIdFind.Location = new System.Drawing.Point(217, 39);
            this.textBoxSupplierIdFind.Name = "textBoxSupplierIdFind";
            this.textBoxSupplierIdFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxSupplierIdFind.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(133, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Supplier ID:";
            // 
            // buttonExitSupplier
            // 
            this.buttonExitSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExitSupplier.Appearance.Options.UseFont = true;
            this.buttonExitSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitSupplier.ImageOptions.Image")));
            this.buttonExitSupplier.Location = new System.Drawing.Point(482, 282);
            this.buttonExitSupplier.Name = "buttonExitSupplier";
            this.buttonExitSupplier.Size = new System.Drawing.Size(106, 44);
            this.buttonExitSupplier.TabIndex = 15;
            this.buttonExitSupplier.Text = "Exit";
            // 
            // buttonRemoveSupplier
            // 
            this.buttonRemoveSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveSupplier.Appearance.Options.UseFont = true;
            this.buttonRemoveSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveSupplier.ImageOptions.Image")));
            this.buttonRemoveSupplier.Location = new System.Drawing.Point(356, 282);
            this.buttonRemoveSupplier.Name = "buttonRemoveSupplier";
            this.buttonRemoveSupplier.Size = new System.Drawing.Size(106, 44);
            this.buttonRemoveSupplier.TabIndex = 14;
            this.buttonRemoveSupplier.Text = "Remove";
            // 
            // buttonEditSupplier
            // 
            this.buttonEditSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditSupplier.Appearance.Options.UseFont = true;
            this.buttonEditSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditSupplier.ImageOptions.Image")));
            this.buttonEditSupplier.Location = new System.Drawing.Point(233, 282);
            this.buttonEditSupplier.Name = "buttonEditSupplier";
            this.buttonEditSupplier.Size = new System.Drawing.Size(106, 44);
            this.buttonEditSupplier.TabIndex = 13;
            this.buttonEditSupplier.Text = "Edit";
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSupplier.Appearance.Options.UseFont = true;
            this.buttonAddSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddSupplier.ImageOptions.Image")));
            this.buttonAddSupplier.Location = new System.Drawing.Point(110, 282);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(106, 44);
            this.buttonAddSupplier.TabIndex = 12;
            this.buttonAddSupplier.Text = "Add";
            // 
            // labelManageSupplierssMessage
            // 
            this.labelManageSupplierssMessage.AutoSize = true;
            this.labelManageSupplierssMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageSupplierssMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageSupplierssMessage.Location = new System.Drawing.Point(325, 341);
            this.labelManageSupplierssMessage.Name = "labelManageSupplierssMessage";
            this.labelManageSupplierssMessage.Size = new System.Drawing.Size(48, 18);
            this.labelManageSupplierssMessage.TabIndex = 16;
            this.labelManageSupplierssMessage.Text = "****";
            // 
            // FormManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 368);
            this.Controls.Add(this.labelManageSupplierssMessage);
            this.Controls.Add(this.buttonExitSupplier);
            this.Controls.Add(this.buttonRemoveSupplier);
            this.Controls.Add(this.buttonEditSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManageSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Suppliers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxSupplierAddress;
        private Label label4;
        private TextBox textBoxSupplierPhone;
        private Label label3;
        private TextBox textBoxSupplierName;
        private Label label2;
        private TextBox textBoxSupplierId;
        private Label label1;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton buttonFindSupplier;
        private TextBox textBoxSupplierIdFind;
        private Label label8;
        private DevExpress.XtraEditors.SimpleButton buttonExitSupplier;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveSupplier;
        private DevExpress.XtraEditors.SimpleButton buttonEditSupplier;
        private DevExpress.XtraEditors.SimpleButton buttonAddSupplier;
        private Label labelManageSupplierssMessage;
    }
}