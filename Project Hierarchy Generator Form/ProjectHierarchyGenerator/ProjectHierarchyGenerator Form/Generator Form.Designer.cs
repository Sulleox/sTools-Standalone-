namespace ProjectHierarchyGenerator_Form
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
            this.FolderPath_Label = new System.Windows.Forms.Label();
            this.FolderPath_TextB = new System.Windows.Forms.TextBox();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.ExampleFolder_Label = new System.Windows.Forms.Label();
            this.ExempleFolderPath_TextBox = new System.Windows.Forms.TextBox();
            this.ExempleFolder_Browse_Button = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FolderPath_Label
            // 
            this.FolderPath_Label.AutoSize = true;
            this.FolderPath_Label.Location = new System.Drawing.Point(12, 20);
            this.FolderPath_Label.Name = "FolderPath_Label";
            this.FolderPath_Label.Size = new System.Drawing.Size(103, 13);
            this.FolderPath_Label.TabIndex = 0;
            this.FolderPath_Label.Text = "Project Folder Path :";
            // 
            // FolderPath_TextB
            // 
            this.FolderPath_TextB.Location = new System.Drawing.Point(137, 13);
            this.FolderPath_TextB.Name = "FolderPath_TextB";
            this.FolderPath_TextB.Size = new System.Drawing.Size(261, 20);
            this.FolderPath_TextB.TabIndex = 1;
            this.FolderPath_TextB.TextChanged += new System.EventHandler(this.FolderPath_TextB_TextChanged);
            // 
            // Browse_Button
            // 
            this.Browse_Button.Location = new System.Drawing.Point(405, 9);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(22, 23);
            this.Browse_Button.TabIndex = 2;
            this.Browse_Button.Text = "...";
            this.Browse_Button.UseVisualStyleBackColor = true;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // ExampleFolder_Label
            // 
            this.ExampleFolder_Label.AutoSize = true;
            this.ExampleFolder_Label.Location = new System.Drawing.Point(12, 54);
            this.ExampleFolder_Label.Name = "ExampleFolder_Label";
            this.ExampleFolder_Label.Size = new System.Drawing.Size(82, 13);
            this.ExampleFolder_Label.TabIndex = 3;
            this.ExampleFolder_Label.Text = "Template Path :";
            // 
            // ExempleFolderPath_TextBox
            // 
            this.ExempleFolderPath_TextBox.Location = new System.Drawing.Point(137, 47);
            this.ExempleFolderPath_TextBox.Name = "ExempleFolderPath_TextBox";
            this.ExempleFolderPath_TextBox.Size = new System.Drawing.Size(261, 20);
            this.ExempleFolderPath_TextBox.TabIndex = 4;
            this.ExempleFolderPath_TextBox.TextChanged += new System.EventHandler(this.ExempleFolderPath_TextBox_TextChanged);
            // 
            // ExempleFolder_Browse_Button
            // 
            this.ExempleFolder_Browse_Button.Location = new System.Drawing.Point(405, 43);
            this.ExempleFolder_Browse_Button.Name = "ExempleFolder_Browse_Button";
            this.ExempleFolder_Browse_Button.Size = new System.Drawing.Size(22, 23);
            this.ExempleFolder_Browse_Button.TabIndex = 5;
            this.ExempleFolder_Browse_Button.Text = "...";
            this.ExempleFolder_Browse_Button.UseVisualStyleBackColor = true;
            this.ExempleFolder_Browse_Button.Click += new System.EventHandler(this.ExempleFolder_Browse_Button_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(352, 82);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(444, 122);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ExempleFolder_Browse_Button);
            this.Controls.Add(this.ExempleFolderPath_TextBox);
            this.Controls.Add(this.ExampleFolder_Label);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.FolderPath_TextB);
            this.Controls.Add(this.FolderPath_Label);
            this.Name = "MainForm";
            this.Text = "Project Hierarchy Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FolderPath_Label;
        private System.Windows.Forms.TextBox FolderPath_TextB;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.Label ExampleFolder_Label;
        private System.Windows.Forms.TextBox ExempleFolderPath_TextBox;
        private System.Windows.Forms.Button ExempleFolder_Browse_Button;
        private System.Windows.Forms.Button GenerateButton;
    }
}

