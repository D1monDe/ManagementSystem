namespace ManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.addEmployee_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new ManagementSystem.Dashboard();
            this.addEmployee1 = new ManagementSystem.AddEmployee();
            this.salary1 = new ManagementSystem.Salary();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 40);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(466, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Менеджер Персоналу";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(1067, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.salary_btn);
            this.panel2.Controls.Add(this.addEmployee_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(850, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 560);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Salmon;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.logout_btn.ForeColor = System.Drawing.Color.Snow;
            this.logout_btn.Location = new System.Drawing.Point(57, 508);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(140, 40);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Вихід";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.BackColor = System.Drawing.Color.LightGreen;
            this.salary_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.salary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.salary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.salary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salary_btn.Location = new System.Drawing.Point(15, 350);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Size = new System.Drawing.Size(223, 55);
            this.salary_btn.TabIndex = 3;
            this.salary_btn.Text = "ЗАРПЛАТА";
            this.salary_btn.UseVisualStyleBackColor = false;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);
            // 
            // addEmployee_btn
            // 
            this.addEmployee_btn.BackColor = System.Drawing.Color.LightGreen;
            this.addEmployee_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addEmployee_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployee_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addEmployee_btn.Location = new System.Drawing.Point(15, 279);
            this.addEmployee_btn.Name = "addEmployee_btn";
            this.addEmployee_btn.Size = new System.Drawing.Size(223, 55);
            this.addEmployee_btn.TabIndex = 2;
            this.addEmployee_btn.Text = "ДОДАТИ ПРАЦІВНИКА";
            this.addEmployee_btn.UseVisualStyleBackColor = false;
            this.addEmployee_btn.Click += new System.EventHandler(this.addEmployee_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.LightGreen;
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboard_btn.Location = new System.Drawing.Point(15, 207);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(223, 55);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "КОНТРОЛЬ АКТИВНОСТІ";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 560);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(850, 560);
            this.dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(850, 560);
            this.addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(850, 560);
            this.salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Button addEmployee_btn;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
    }
}