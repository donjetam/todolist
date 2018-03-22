namespace TDL
{
    partial class Update
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Label = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.update_button);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Location = new System.Drawing.Point(2, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 83);
            this.panel2.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Proxima Nova Th", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(585, 24);
            this.button3.Name = "btn_delete";
            this.button3.Size = new System.Drawing.Size(79, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Proxima Nova Th", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(468, 24);
            this.button2.Name = "btn_update";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DarkOrange;
            this.update_button.Font = new System.Drawing.Font("Proxima Nova Th", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button.Location = new System.Drawing.Point(374, 24);
            this.update_button.Name = "btn_view";
            this.update_button.Size = new System.Drawing.Size(79, 34);
            this.update_button.TabIndex = 0;
            this.update_button.Text = "VIEW";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.Font = new System.Drawing.Font("Proxima Nova Th", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(31, 16);
            this.button4.Name = "btn_dashboard";
            this.button4.Size = new System.Drawing.Size(146, 59);
            this.button4.TabIndex = 0;
            this.button4.Text = "DASHBOARD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_add.Font = new System.Drawing.Font("Proxima Nova Th", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(277, 24);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(79, 34);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button_Click);
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(12, 111);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.Size = new System.Drawing.Size(428, 269);
            this.dgvContactList.TabIndex = 23;
            this.dgvContactList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactList_CellContentClick);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(446, 172);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(328, 135);
            this.Description.TabIndex = 30;
            this.Description.Text = "";
            // 
            // Label
            // 
            this.Label.Location = new System.Drawing.Point(655, 150);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(93, 20);
            this.Label.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(600, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(446, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Description";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(617, 112);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(131, 20);
            this.Title.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(570, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Title";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOrange;
            this.button5.Font = new System.Drawing.Font("Proxima Nova Th", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(532, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 46);
            this.button5.TabIndex = 0;
            this.button5.Text = "SAVE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.IDlabel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IDlabel.ForeColor = System.Drawing.Color.Red;
            this.IDlabel.Location = new System.Drawing.Point(442, 112);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(24, 20);
            this.IDlabel.TabIndex = 27;
            this.IDlabel.Text = "ID";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(472, 111);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(92, 20);
            this.ID.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(2, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 481);
            this.panel1.TabIndex = 44;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 459);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.panel1);
            this.Name = "Update";
            this.Text = "Update";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Panel panel1;
    }
}