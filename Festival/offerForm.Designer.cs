namespace Festival
{
    partial class offerForm
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
            this.txtboxusername = new System.Windows.Forms.TextBox();
            this.txtboxevtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxtickcount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpost = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtboxusername
            // 
            this.txtboxusername.Location = new System.Drawing.Point(140, 167);
            this.txtboxusername.Name = "txtboxusername";
            this.txtboxusername.Size = new System.Drawing.Size(127, 20);
            this.txtboxusername.TabIndex = 1;
            // 
            // txtboxevtname
            // 
            this.txtboxevtname.Location = new System.Drawing.Point(140, 33);
            this.txtboxevtname.Name = "txtboxevtname";
            this.txtboxevtname.Size = new System.Drawing.Size(327, 20);
            this.txtboxevtname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Name";
            // 
            // txtboxtickcount
            // 
            this.txtboxtickcount.Location = new System.Drawing.Point(140, 103);
            this.txtboxtickcount.Name = "txtboxtickcount";
            this.txtboxtickcount.Size = new System.Drawing.Size(127, 20);
            this.txtboxtickcount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ticket Count";
            // 
            // txtboxprice
            // 
            this.txtboxprice.Location = new System.Drawing.Point(332, 104);
            this.txtboxprice.Name = "txtboxprice";
            this.txtboxprice.Size = new System.Drawing.Size(135, 20);
            this.txtboxprice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // btnpost
            // 
            this.btnpost.BackColor = System.Drawing.Color.Transparent;
            this.btnpost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpost.Location = new System.Drawing.Point(136, 261);
            this.btnpost.Name = "btnpost";
            this.btnpost.Size = new System.Drawing.Size(75, 32);
            this.btnpost.TabIndex = 8;
            this.btnpost.Text = "Post";
            this.btnpost.UseVisualStyleBackColor = false;
            this.btnpost.Click += new System.EventHandler(this.btnpost_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(282, 261);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 32);
            this.btnback.TabIndex = 18;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // offerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Festival.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 383);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnpost);
            this.Controls.Add(this.txtboxprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxtickcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxevtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxusername);
            this.Controls.Add(this.label1);
            this.Name = "offerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "offerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxusername;
        private System.Windows.Forms.TextBox txtboxevtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxtickcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnpost;
        private System.Windows.Forms.Button btnback;
    }
}