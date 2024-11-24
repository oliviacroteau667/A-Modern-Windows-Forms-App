namespace Names
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
            btnAdd = new Button();
            lstNames = new ListBox();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(470, 213);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 69);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.Location = new Point(55, 134);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(360, 244);
            lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(470, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 55);
            txtName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 68);
            label1.Name = "label1";
            label1.Size = new Size(130, 48);
            label1.TabIndex = 4;
            label1.Text = "Names";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListBox lstNames;
        private TextBox txtName;
        private Label label1;
    }
}
