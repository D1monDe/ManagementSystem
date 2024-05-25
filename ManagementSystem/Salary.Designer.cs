namespace ManagementSystem
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salary_clearBtn = new System.Windows.Forms.Button();
            this.salary_updateBtn = new System.Windows.Forms.Button();
            this.salary_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salary_position = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_employeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.salary_clearBtn);
            this.panel1.Controls.Add(this.salary_updateBtn);
            this.panel1.Controls.Add(this.salary_salary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.salary_position);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.salary_employeeID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salary_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(560, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 531);
            this.panel1.TabIndex = 0;
            // 
            // salary_clearBtn
            // 
            this.salary_clearBtn.BackColor = System.Drawing.Color.LightGreen;
            this.salary_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_clearBtn.FlatAppearance.BorderSize = 0;
            this.salary_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.salary_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.salary_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.salary_clearBtn.Location = new System.Drawing.Point(153, 341);
            this.salary_clearBtn.Name = "salary_clearBtn";
            this.salary_clearBtn.Size = new System.Drawing.Size(100, 38);
            this.salary_clearBtn.TabIndex = 12;
            this.salary_clearBtn.Text = "Очистити";
            this.salary_clearBtn.UseVisualStyleBackColor = false;
            this.salary_clearBtn.Click += new System.EventHandler(this.salary_clearBtn_Click);
            // 
            // salary_updateBtn
            // 
            this.salary_updateBtn.BackColor = System.Drawing.Color.LightGreen;
            this.salary_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_updateBtn.FlatAppearance.BorderSize = 0;
            this.salary_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.salary_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.salary_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.salary_updateBtn.Location = new System.Drawing.Point(23, 341);
            this.salary_updateBtn.Name = "salary_updateBtn";
            this.salary_updateBtn.Size = new System.Drawing.Size(100, 38);
            this.salary_updateBtn.TabIndex = 11;
            this.salary_updateBtn.Text = "Оновити";
            this.salary_updateBtn.UseVisualStyleBackColor = false;
            this.salary_updateBtn.Click += new System.EventHandler(this.salary_updateBtn_Click);
            // 
            // salary_salary
            // 
            this.salary_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary_salary.Location = new System.Drawing.Point(23, 289);
            this.salary_salary.Multiline = true;
            this.salary_salary.Name = "salary_salary";
            this.salary_salary.Size = new System.Drawing.Size(230, 22);
            this.salary_salary.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Зарплата:";
            // 
            // salary_position
            // 
            this.salary_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary_position.Location = new System.Drawing.Point(23, 216);
            this.salary_position.Multiline = true;
            this.salary_position.Name = "salary_position";
            this.salary_position.Size = new System.Drawing.Size(230, 22);
            this.salary_position.TabIndex = 5;
            this.salary_position.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Посада:";
            // 
            // salary_employeeID
            // 
            this.salary_employeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary_employeeID.Location = new System.Drawing.Point(23, 139);
            this.salary_employeeID.Multiline = true;
            this.salary_employeeID.Name = "salary_employeeID";
            this.salary_employeeID.Size = new System.Drawing.Size(230, 22);
            this.salary_employeeID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // salary_name
            // 
            this.salary_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary_name.Location = new System.Drawing.Point(23, 60);
            this.salary_name.Multiline = true;
            this.salary_name.Name = "salary_name";
            this.salary_name.Size = new System.Drawing.Size(230, 22);
            this.salary_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ФІО:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 531);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 478);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Працівники";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(850, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary_employeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salary_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salary_clearBtn;
        private System.Windows.Forms.Button salary_updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
