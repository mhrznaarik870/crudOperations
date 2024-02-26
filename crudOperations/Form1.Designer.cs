namespace crudOperations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelSid = new TextBox();
            searchBtn = new Button();
            labelFname = new TextBox();
            labelLname = new TextBox();
            updateBtn = new Button();
            insertBtn = new Button();
            deleteBtn = new Button();
            labelSuccess = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(181, 122);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            label1.Click += label1_Click;
            // 
            // labelSid
            // 
            labelSid.Location = new Point(284, 119);
            labelSid.Name = "labelSid";
            labelSid.Size = new Size(79, 27);
            labelSid.TabIndex = 1;
            labelSid.TextChanged += labelSid_TextChanged;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.GreenYellow;
            searchBtn.ForeColor = Color.DarkBlue;
            searchBtn.Location = new Point(369, 116);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(78, 33);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "SEARCH";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // labelFname
            // 
            labelFname.Location = new Point(284, 155);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(163, 27);
            labelFname.TabIndex = 5;
            // 
            // labelLname
            // 
            labelLname.Location = new Point(284, 191);
            labelLname.Name = "labelLname";
            labelLname.Size = new Size(163, 27);
            labelLname.TabIndex = 7;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Gold;
            updateBtn.ForeColor = SystemColors.ActiveCaptionText;
            updateBtn.Location = new Point(368, 224);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(78, 33);
            updateBtn.TabIndex = 8;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.Aqua;
            insertBtn.ForeColor = Color.DarkBlue;
            insertBtn.Location = new Point(284, 224);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(78, 33);
            insertBtn.TabIndex = 9;
            insertBtn.Text = "INSERT";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(333, 263);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(78, 33);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.BackColor = Color.White;
            labelSuccess.ForeColor = Color.Gainsboro;
            labelSuccess.Location = new Point(284, 299);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(67, 20);
            labelSuccess.TabIndex = 11;
            labelSuccess.Text = "message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(182, 194);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 12;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleTurquoise;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(181, 158);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 13;
            label3.Text = "First Name:";
            label3.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelSuccess);
            Controls.Add(deleteBtn);
            Controls.Add(insertBtn);
            Controls.Add(updateBtn);
            Controls.Add(labelLname);
            Controls.Add(labelFname);
            Controls.Add(searchBtn);
            Controls.Add(labelSid);
            Controls.Add(label1);
            ForeColor = Color.Crimson;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox labelSid;
        private Button searchBtn;
        private TextBox labelFname;
        private TextBox labelLname;
        private Button updateBtn;
        private Button insertBtn;
        private Button deleteBtn;
        private Label labelSuccess;
        private Label label2;
        private Label label3;
    }
}
