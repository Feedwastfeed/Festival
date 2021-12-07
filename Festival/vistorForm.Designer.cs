namespace Festival
{
    partial class vistorForm
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
            this.btnbuy = new System.Windows.Forms.Button();
            this.datagridviewevt = new System.Windows.Forms.DataGridView();
            this.btnfeedback = new System.Windows.Forms.Button();
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewevt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuy
            // 
            this.btnbuy.BackColor = System.Drawing.Color.Transparent;
            this.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuy.ForeColor = System.Drawing.Color.Lime;
            this.btnbuy.Location = new System.Drawing.Point(574, 375);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(75, 31);
            this.btnbuy.TabIndex = 0;
            this.btnbuy.Text = "Buy";
            this.btnbuy.UseVisualStyleBackColor = false;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // datagridviewevt
            // 
            this.datagridviewevt.AllowUserToAddRows = false;
            this.datagridviewevt.AllowUserToDeleteRows = false;
            this.datagridviewevt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridviewevt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewevt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewevt.Location = new System.Drawing.Point(92, 63);
            this.datagridviewevt.MultiSelect = false;
            this.datagridviewevt.Name = "datagridviewevt";
            this.datagridviewevt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewevt.Size = new System.Drawing.Size(635, 294);
            this.datagridviewevt.TabIndex = 4;
            // 
            // btnfeedback
            // 
            this.btnfeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfeedback.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfeedback.ForeColor = System.Drawing.Color.Blue;
            this.btnfeedback.Location = new System.Drawing.Point(211, 375);
            this.btnfeedback.Name = "btnfeedback";
            this.btnfeedback.Size = new System.Drawing.Size(87, 31);
            this.btnfeedback.TabIndex = 5;
            this.btnfeedback.Text = "FeedBack";
            this.btnfeedback.UseVisualStyleBackColor = false;
            this.btnfeedback.Click += new System.EventHandler(this.btnfeedback_Click);
            // 
            // txtboxusername
            // 
            this.txtboxusername.Location = new System.Drawing.Point(403, 377);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(136, 20);
            this.txtboxusername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // vistorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Festival.Properties.Resources._82409_636282992381780999_16x9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfeedback);
            this.Controls.Add(this.datagridviewevt);
            this.Controls.Add(this.btnbuy);
            this.Name = "vistorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vistorForm";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewevt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.DataGridView datagridviewevt;
        private System.Windows.Forms.Button btnfeedback;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.Label label1;
    }
}