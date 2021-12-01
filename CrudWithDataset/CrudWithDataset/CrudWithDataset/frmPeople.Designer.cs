namespace CrudWithDataset
{
    partial class frmPeople
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
            this.tlpPeople = new System.Windows.Forms.TableLayoutPanel();
            this.pPeople = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tlpPeople.SuspendLayout();
            this.pPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPeople
            // 
            this.tlpPeople.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tlpPeople.ColumnCount = 1;
            this.tlpPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPeople.Controls.Add(this.pPeople, 0, 0);
            this.tlpPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPeople.Location = new System.Drawing.Point(0, 0);
            this.tlpPeople.Name = "tlpPeople";
            this.tlpPeople.RowCount = 1;
            this.tlpPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPeople.Size = new System.Drawing.Size(396, 224);
            this.tlpPeople.TabIndex = 0;
            // 
            // pPeople
            // 
            this.pPeople.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pPeople.Controls.Add(this.btnExit);
            this.pPeople.Controls.Add(this.btnSave);
            this.pPeople.Controls.Add(this.numAge);
            this.pPeople.Controls.Add(this.txtName);
            this.pPeople.Controls.Add(this.lblAge);
            this.pPeople.Controls.Add(this.lblName);
            this.pPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPeople.Location = new System.Drawing.Point(3, 3);
            this.pPeople.Name = "pPeople";
            this.pPeople.Size = new System.Drawing.Size(390, 218);
            this.pPeople.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(32, 119);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 18);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 20);
            this.txtName.TabIndex = 2;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(79, 118);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(276, 20);
            this.numAge.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(119, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 224);
            this.Controls.Add(this.tlpPeople);
            this.Name = "frmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar personas";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.tlpPeople.ResumeLayout(false);
            this.pPeople.ResumeLayout(false);
            this.pPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPeople;
        private System.Windows.Forms.Panel pPeople;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}