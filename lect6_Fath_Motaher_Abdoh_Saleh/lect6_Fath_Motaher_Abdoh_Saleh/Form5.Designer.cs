namespace lect6_Fath_Motaher_Abdoh_Saleh
{
    partial class Form5
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
            this.lblsec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblhour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.Location = new System.Drawing.Point(311, 39);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(45, 33);
            this.lblsec.TabIndex = 0;
            this.lblsec.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(238, 39);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(45, 33);
            this.lblmin.TabIndex = 2;
            this.lblmin.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhour.Location = new System.Drawing.Point(156, 39);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(45, 33);
            this.lblhour.TabIndex = 4;
            this.lblhour.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(65, 39);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(45, 33);
            this.lblday.TabIndex = 6;
            this.lblday.Text = "00";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(244, 111);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(98, 54);
            this.btnstart.TabIndex = 7;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(35, 111);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(94, 54);
            this.btnstop.TabIndex = 8;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 177);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsec);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Timer timer1;
    }
}