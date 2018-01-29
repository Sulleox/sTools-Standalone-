using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectHierarchyGenerator_Form
{
    public partial class MainForm : Form
    {

        private string m_FolderPath = string.Empty;
        private string m_TemplatePath = string.Empty;

        private bool m_UseTemplate = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HierarchyTemplate_RichTextBox.AcceptsTab = true;
        }

        //BROWSE FOLDER CLICK
        private void Browse_Button_Click(object sender, EventArgs e)
        {
            var m_Fdb = new FolderBrowserDialog();
            DialogResult result = m_Fdb.ShowDialog();

            if (result == DialogResult.OK)
            {
                FolderPath_TextB.Text = m_Fdb.SelectedPath;
            }
        }

        //BROWSE TEMPLATE CLICK
        private void ExempleFolder_Browse_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                m_TemplatePath = fileDialog.FileName;
                TemplatePath_TextBox.Text = m_TemplatePath;
            }
        }

        //GENERATE BUTTON CLICK
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PreGenerateFolder();
        }

        //FOLDER PATH TEXT BOX
        private void FolderPath_TextB_TextChanged(object sender, EventArgs e)
        {
            CheckFolderPath(FolderPath_TextB.Text);
        }

        //TEMPLATE FILE TEXT BOX
        private void TemplatePath_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (m_UseTemplate) CheckFolderPath(TemplatePath_TextBox.Text);
        }

        //USE TEMPLATE CHECKBOX
        private void UseTemplate_CheckedChanged(object sender, EventArgs e)
        {
            m_UseTemplate = !m_UseTemplate;
        }

        //CHECK FOLDER PATH
        private void CheckFolderPath(string folderPath)
        {

            if (!string.IsNullOrWhiteSpace(folderPath) && Directory.Exists(folderPath))
            {
                CheckFolderFiles(folderPath);
            }
            else
            {
                MessageBox.Show("The folder path is not valid.", "[ERROR] Folder Path");
            }
        }

        //CHECK IF FOLDER IS EMPTY
        private void CheckFolderFiles(string folderPath)
        {
            string[] filesPath = Directory.GetFiles(folderPath);

            if (filesPath.Length > 0)
            {
                var ClearResult = MessageBox.Show("There are files in the folder you choose, do you want to clear the folder ?",
                                                  "[ERROR] The Project Folder isn't Empty",
                                                  MessageBoxButtons.YesNo);

                if (ClearResult == DialogResult.Yes)
                {
                    foreach (String filePath in filesPath)
                    {
                        File.Delete(filePath);
                        m_FolderPath = folderPath;
                        PreGenerateFolder();
                    }
                }
                else
                {
                    MessageBox.Show("Change the folder to an empty one.", "[ERROR] Filled Folder");
                }
            }
            else
            {
                m_FolderPath = folderPath;
            }
        }

        //GENERATE PROJECT HIERARCHY
        private void PreGenerateFolder()
        {
            if (m_FolderPath != string.Empty)
            {
                if (m_UseTemplate)
                {
                    string[] foldersNames = File.ReadAllLines(m_TemplatePath);
                    GenerateFolder(foldersNames);
                }
                else
                {

                    string[] foldersNames = HierarchyTemplate_RichTextBox.Text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    GenerateFolder(foldersNames);
                }
            }
        }

        public void GenerateFolder(string[] foldersNames)
        {
            int lastTabNumber = 0;
            string lastFolderCreatePath = m_FolderPath;

            foreach (String folderName in foldersNames)
            {
                int tabNumber = 0;
                string currentFolderName = folderName;

                for (int i = 0; i < folderName.Length; i++)
                {
                    if (folderName[i] == '\t')
                    {
                        tabNumber++;
                        if (tabNumber > 0) currentFolderName = folderName.Remove(0, tabNumber);
                    }
                }

                if (tabNumber == 0)
                {
                    //Créer dans le dossier racine
                    string newFolderPath = Path.Combine(m_FolderPath, currentFolderName);
                    Directory.CreateDirectory(newFolderPath);
                    lastFolderCreatePath = newFolderPath;
                }
                else if (tabNumber > lastTabNumber)
                {
                    //Enfant du dernier dossier créer
                    string newFolderPath = Path.Combine(lastFolderCreatePath, currentFolderName);
                    Directory.CreateDirectory(newFolderPath);
                    lastFolderCreatePath = newFolderPath;
                }
                else if (tabNumber < lastTabNumber)
                {
                    //Créer dans un dossier enfant du racine
                    string newFolderPath = lastFolderCreatePath;
                    for (int i = 0; i < ((lastTabNumber + 1) - tabNumber); i++)
                    {
                        int lastIndex = newFolderPath.LastIndexOf('\\');
                        Console.WriteLine(lastIndex);
                        newFolderPath = newFolderPath.Remove(lastIndex);
                        Console.WriteLine(newFolderPath);
                    }
                    newFolderPath = Path.Combine(newFolderPath, currentFolderName);
                    Directory.CreateDirectory(newFolderPath);
                    lastFolderCreatePath = newFolderPath;
                }
                else if (tabNumber == lastTabNumber)
                {
                    string newFolderPath = lastFolderCreatePath;
                    int lastIndex = newFolderPath.LastIndexOf('\\');
                    newFolderPath = Path.Combine(newFolderPath.Remove(lastIndex), currentFolderName);
                    Directory.CreateDirectory(newFolderPath);
                    lastFolderCreatePath = newFolderPath;
                }

                lastTabNumber = tabNumber;
            }
        }
    }
}
