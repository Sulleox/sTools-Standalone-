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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FolderPath_Label = new System.Windows.Forms.Label();
            this.FolderPath_TextB = new System.Windows.Forms.TextBox();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.ExampleFolder_Label = new System.Windows.Forms.Label();
            this.TemplatePath_TextBox = new System.Windows.Forms.TextBox();
            this.ExempleFolder_Browse_Button = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.TemplateCheckBox = new System.Windows.Forms.CheckBox();
            this.HierarchyTemplate_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FolderPath_Label
            // 
            this.FolderPath_Label.AutoSize = true;
            this.FolderPath_Label.Location = new System.Drawing.Point(9, 16);
            this.FolderPath_Label.Name = "FolderPath_Label";
            this.FolderPath_Label.Size = new System.Drawing.Size(103, 13);
            this.FolderPath_Label.TabIndex = 0;
            this.FolderPath_Label.Text = "Project Folder Path :";
            // 
            // FolderPath_TextB
            // 
            this.FolderPath_TextB.Location = new System.Drawing.Point(12, 32);
            this.FolderPath_TextB.Name = "FolderPath_TextB";
            this.FolderPath_TextB.Size = new System.Drawing.Size(179, 20);
            this.FolderPath_TextB.TabIndex = 1;
            this.FolderPath_TextB.TextChanged += new System.EventHandler(this.FolderPath_TextB_TextChanged);
            // 
            // Browse_Button
            // 
            this.Browse_Button.Location = new System.Drawing.Point(197, 30);
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
            this.ExampleFolder_Label.Location = new System.Drawing.Point(245, 16);
            this.ExampleFolder_Label.Name = "ExampleFolder_Label";
            this.ExampleFolder_Label.Size = new System.Drawing.Size(82, 13);
            this.ExampleFolder_Label.TabIndex = 3;
            this.ExampleFolder_Label.Text = "Template Path :";
            // 
            // TemplatePath_TextBox
            // 
            this.TemplatePath_TextBox.Location = new System.Drawing.Point(248, 31);
            this.TemplatePath_TextBox.Name = "TemplatePath_TextBox";
            this.TemplatePath_TextBox.Size = new System.Drawing.Size(179, 20);
            this.TemplatePath_TextBox.TabIndex = 4;
            this.TemplatePath_TextBox.TextChanged += new System.EventHandler(this.TemplatePath_TextBox_TextChanged);
            // 
            // ExempleFolder_Browse_Button
            // 
            this.ExempleFolder_Browse_Button.Location = new System.Drawing.Point(433, 29);
            this.ExempleFolder_Browse_Button.Name = "ExempleFolder_Browse_Button";
            this.ExempleFolder_Browse_Button.Size = new System.Drawing.Size(22, 23);
            this.ExempleFolder_Browse_Button.TabIndex = 5;
            this.ExempleFolder_Browse_Button.Text = "...";
            this.ExempleFolder_Browse_Button.UseVisualStyleBackColor = true;
            this.ExempleFolder_Browse_Button.Click += new System.EventHandler(this.ExempleFolder_Browse_Button_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 276);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // TemplateCheckBox
            // 
            this.TemplateCheckBox.AutoSize = true;
            this.TemplateCheckBox.Location = new System.Drawing.Point(248, 57);
            this.TemplateCheckBox.Name = "TemplateCheckBox";
            this.TemplateCheckBox.Size = new System.Drawing.Size(92, 17);
            this.TemplateCheckBox.TabIndex = 7;
            this.TemplateCheckBox.Text = "Use Template";
            this.TemplateCheckBox.UseVisualStyleBackColor = true;
            this.TemplateCheckBox.CheckedChanged += new System.EventHandler(this.UseTemplate_CheckedChanged);
            // 
            // HierarchyTemplate_RichTextBox
            // 
            this.HierarchyTemplate_RichTextBox.Location = new System.Drawing.Point(12, 80);
            this.HierarchyTemplate_RichTextBox.Name = "HierarchyTemplate_RichTextBox";
            this.HierarchyTemplate_RichTextBox.Size = new System.Drawing.Size(442, 190);
            this.HierarchyTemplate_RichTextBox.TabIndex = 8;
            this.HierarchyTemplate_RichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(464, 307);
            this.Controls.Add(this.HierarchyTemplate_RichTextBox);
            this.Controls.Add(this.TemplateCheckBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ExempleFolder_Browse_Button);
            this.Controls.Add(this.TemplatePath_TextBox);
            this.Controls.Add(this.ExampleFolder_Label);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.FolderPath_TextB);
            this.Controls.Add(this.FolderPath_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox TemplatePath_TextBox;
        private System.Windows.Forms.Button ExempleFolder_Browse_Button;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox TemplateCheckBox;
        private System.Windows.Forms.RichTextBox HierarchyTemplate_RichTextBox;
    }
}

