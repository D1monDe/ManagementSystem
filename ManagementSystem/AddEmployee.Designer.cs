namespace ManagementSystem
{
    partial class AddEmployee
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
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_clearBtn = new System.Windows.Forms.Button();
            this.addEmployee_deleteBtn = new System.Windows.Forms.Button();
            this.addEmployee_updateBtn = new System.Windows.Forms.Button();
            this.addEmployee_addBtn = new System.Windows.Forms.Button();
            this.addEmployee_importBtn = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_phoneNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addEmployee_status);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addEmployee_position);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addEmployee_clearBtn);
            this.panel1.Controls.Add(this.addEmployee_deleteBtn);
            this.panel1.Controls.Add(this.addEmployee_updateBtn);
            this.panel1.Controls.Add(this.addEmployee_addBtn);
            this.panel1.Controls.Add(this.addEmployee_importBtn);
            this.panel1.Controls.Add(this.addEmployee_picture);
            this.panel1.Controls.Add(this.addEmployee_phoneNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addEmployee_gender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addEmployee_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addEmployee_fullName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 220);
            this.panel1.TabIndex = 0;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Present",
            "Not Present"});
            this.addEmployee_status.Location = new System.Drawing.Point(418, 119);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(164, 26);
            this.addEmployee_status.TabIndex = 17;
            this.addEmployee_status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(326, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Наявність:";
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "Front-end developer",
            "Back-end developer",
            "QA tester",
            "DataServ admin",
            "Designer Ux/Ui"});
            this.addEmployee_position.Location = new System.Drawing.Point(82, 119);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(154, 26);
            this.addEmployee_position.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Посада:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addEmployee_clearBtn
            // 
            this.addEmployee_clearBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addEmployee_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_clearBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_clearBtn.Location = new System.Drawing.Point(378, 169);
            this.addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            this.addEmployee_clearBtn.Size = new System.Drawing.Size(100, 38);
            this.addEmployee_clearBtn.TabIndex = 13;
            this.addEmployee_clearBtn.Text = "Очистити";
            this.addEmployee_clearBtn.UseVisualStyleBackColor = false;
            this.addEmployee_clearBtn.Click += new System.EventHandler(this.addEmployee_clearBtn_Click);
            // 
            // addEmployee_deleteBtn
            // 
            this.addEmployee_deleteBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addEmployee_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_deleteBtn.Location = new System.Drawing.Point(511, 169);
            this.addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            this.addEmployee_deleteBtn.Size = new System.Drawing.Size(100, 38);
            this.addEmployee_deleteBtn.TabIndex = 12;
            this.addEmployee_deleteBtn.Text = "Видалити";
            this.addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            this.addEmployee_deleteBtn.Click += new System.EventHandler(this.addEmployee_deleteBtn_Click);
            // 
            // addEmployee_updateBtn
            // 
            this.addEmployee_updateBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addEmployee_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_updateBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_updateBtn.Location = new System.Drawing.Point(248, 169);
            this.addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            this.addEmployee_updateBtn.Size = new System.Drawing.Size(100, 38);
            this.addEmployee_updateBtn.TabIndex = 11;
            this.addEmployee_updateBtn.Text = "Оновити";
            this.addEmployee_updateBtn.UseVisualStyleBackColor = false;
            this.addEmployee_updateBtn.Click += new System.EventHandler(this.addEmployee_updateBtn_Click);
            // 
            // addEmployee_addBtn
            // 
            this.addEmployee_addBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addEmployee_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_addBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_addBtn.Location = new System.Drawing.Point(120, 169);
            this.addEmployee_addBtn.Name = "addEmployee_addBtn";
            this.addEmployee_addBtn.Size = new System.Drawing.Size(100, 38);
            this.addEmployee_addBtn.TabIndex = 10;
            this.addEmployee_addBtn.Text = "Додати";
            this.addEmployee_addBtn.UseVisualStyleBackColor = false;
            this.addEmployee_addBtn.Click += new System.EventHandler(this.addEmployee_addBtn_Click);
            // 
            // addEmployee_importBtn
            // 
            this.addEmployee_importBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addEmployee_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_importBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_importBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.addEmployee_importBtn.Location = new System.Drawing.Point(667, 141);
            this.addEmployee_importBtn.Name = "addEmployee_importBtn";
            this.addEmployee_importBtn.Size = new System.Drawing.Size(116, 38);
            this.addEmployee_importBtn.TabIndex = 9;
            this.addEmployee_importBtn.Text = "Завантажити";
            this.addEmployee_importBtn.UseVisualStyleBackColor = false;
            this.addEmployee_importBtn.Click += new System.EventHandler(this.addEmployee_importBtn_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Location = new System.Drawing.Point(676, 20);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(94, 115);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 8;
            this.addEmployee_picture.TabStop = false;
            // 
            // addEmployee_phoneNum
            // 
            this.addEmployee_phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployee_phoneNum.Location = new System.Drawing.Point(418, 24);
            this.addEmployee_phoneNum.Name = "addEmployee_phoneNum";
            this.addEmployee_phoneNum.Size = new System.Drawing.Size(164, 24);
            this.addEmployee_phoneNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(270, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Номер телефону:";
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Famale"});
            this.addEmployee_gender.Location = new System.Drawing.Point(82, 69);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(154, 26);
            this.addEmployee_gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(384, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addEmployee_id
            // 
            this.addEmployee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployee_id.Location = new System.Drawing.Point(418, 69);
            this.addEmployee_id.Name = "addEmployee_id";
            this.addEmployee_id.Size = new System.Drawing.Size(164, 24);
            this.addEmployee_id.TabIndex = 3;
            this.addEmployee_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cтать:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addEmployee_fullName
            // 
            this.addEmployee_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployee_fullName.Location = new System.Drawing.Point(82, 24);
            this.addEmployee_fullName.Name = "addEmployee_fullName";
            this.addEmployee_fullName.Size = new System.Drawing.Size(154, 24);
            this.addEmployee_fullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ФІО:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(22, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 295);
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 232);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Інформація персоналу";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(850, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_fullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEmployee_clearBtn;
        private System.Windows.Forms.Button addEmployee_deleteBtn;
        private System.Windows.Forms.Button addEmployee_updateBtn;
        private System.Windows.Forms.Button addEmployee_addBtn;
        private System.Windows.Forms.Button addEmployee_importBtn;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.TextBox addEmployee_phoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label7;
    }
}
