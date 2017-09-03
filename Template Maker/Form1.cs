using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Template_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////////////
        // Variables
        ////////////

        public string templateName = "";
        public string defaultTemplateText = "Add Template Name Here";
        public string txtTemplate = "";
        public string pathTemplate = @"..\..\Templates\";
        public string btnOperator = "";


        //////////
        // Methods
        //////////


        public void changeBtnOperator(string newOperator)
        {
            switch (newOperator)
            {
                case "Create":
                    btnOperator = "Create";
                    btnCreateEdit.Text = "Create Template";
                    break;
                case "Edit":
                    btnOperator = "Edit";
                    btnCreateEdit.Text = "Edit Template";
                    break;
            }
        }

        public bool checkFields()
        {
            string output = "";

            // Check if a template is selected
            if (cbTemplates.Text == "")
            {
                MessageBox.Show("Please select a template.", "Template Maker - Missing Template", MessageBoxButtons.OK);
                return false;
            }
            // If a template is selected, check the Subject, Message, and Template Name fields;
            // If any of these fields are missing, prompt the user to fill them out.
            else if (tbSubject.Text == "" || tbMessage.Text == "" || (cbTemplates.Text == "[Create New Template]" && tbNewTempName.Text == defaultTemplateText))
            {
                output = "The following fields are blank:" + Environment.NewLine;

                if (tbSubject.Text == "")
                    output += Environment.NewLine + "Subject";

                if (tbMessage.Text == "")
                    output += Environment.NewLine + "Message";
                if (cbTemplates.Text == "[Create New Template]" && tbNewTempName.Text == defaultTemplateText)
                    output += Environment.NewLine + "New Template Name";

                    MessageBox.Show(output, "Template Maker - Missing Fields", MessageBoxButtons.OK);
                return false;
            }
            
            return true;
        }


        public void clearFields()
        {
            // Clear the form fields
            tbNewTempName.Text = "";
            tbFrom.Text = "";
            tbTo.Text = "";
            tbCC.Text = "";
            tbBCC.Text = "";
            tbSubject.Text = "";
            tbMessage.Text = "";
        }

        
        //public void colorThemeChange(string colorTheme)
        //{
        //    if (colorTheme == "Dark")
        //    {
        //        menuColorDark.Checked = true;
        //        menuColorLight.Checked = false;
        //        this.BackColor = Color.Black;
        //        frm1MenuStrip.BackColor = Color.FromArgb(27, 1, 66);
        //        menuFile.BackColor = Color.FromArgb(27, 1, 66);
        //        menuFile.ForeColor = Color.White;
        //        menuExit.ForeColor = Color.White;
        //        menuConfig.BackColor = Color.FromArgb(27, 1, 66);
        //        menuConfig.ForeColor = Color.White;
        //        menuColor.BackColor = Color.FromArgb(27, 1, 66);
        //        menuColor.ForeColor = Color.White;
        //        menuColorDark.ForeColor = Color.White;
        //        menuColorLight.ForeColor = Color.White;
        //        menuHelp.ForeColor = Color.White;
        //        menuHelp.BackColor = Color.FromArgb(27, 1, 66);
        //        menuAbout.ForeColor = Color.White;
                
        //    }
        //    else
        //    {
        //        menuColorDark.Checked = false;
        //        menuColorLight.Checked = true;
        //        this.BackColor = SystemColors.Control;
        //        frm1MenuStrip.BackColor = SystemColors.Control;
        //        menuFile.BackColor = SystemColors.Control;
        //        menuFile.ForeColor = Color.Black;
        //        menuExit.ForeColor = Color.Black;
        //        menuConfig.BackColor = SystemColors.Control;
        //        menuConfig.ForeColor = Color.Black;
        //        menuColor.BackColor = SystemColors.Control;
        //        menuColor.ForeColor = Color.Black;
        //        menuColorDark.ForeColor = Color.Black;
        //        menuColorLight.ForeColor = Color.Black;
        //        menuHelp.ForeColor = Color.Black;
        //        menuHelp.BackColor = SystemColors.Control;
        //        menuAbout.ForeColor = Color.Black;
        //    }
        //}


        public string compileTemplate(string opType)
        {
            // If the opType (btnOperator) is "Create", use the name in the tbNewTemplateName field
            // If the opType is "Edit", use the existing name in the cbTemplates combobox
            if (opType == "Create" || opType == "Preview")
                txtTemplate = "Template Name: " + tbNewTempName.Text + Environment.NewLine;
            else
                txtTemplate = "Template Name: " + cbTemplates.Text + Environment.NewLine;

            txtTemplate += "From: " + tbFrom.Text + Environment.NewLine +
                "To: " + tbTo.Text + Environment.NewLine +
                "CC: " + tbCC.Text + Environment.NewLine +
                "BCC: " + tbBCC.Text + Environment.NewLine +
                "Subject: " + tbSubject.Text + Environment.NewLine +
                "Message: " + tbMessage.Text;

            return txtTemplate;
        }


        public void enterKeyPressed(char keyChar)
        {
            // If the ENTER key is selected, perform a click even on btnCreateEdit
            if (keyChar == Convert.ToChar(Keys.Enter))
            {
                btnCreateEdit.PerformClick();
            }
        }


        public void loadDirTemplates()
        {
            cbTemplates.Items.Clear();
            cbTemplates.Items.Add("[Create New Template]");

            // Load templates to the cbTempaltes comboBox from the Templates folder
            string[] dir = Directory.GetFiles(pathTemplate, "*.txt");
            foreach (string str in dir)
            {
                cbTemplates.Items.Add(Path.GetFileNameWithoutExtension(str));
            }
        }

        public void loadTemplateData()
        {
            string filePath = pathTemplate + cbTemplates.Text + ".txt";

            foreach (var line in File.ReadAllLines(filePath))
            {
                //if (line.StartsWith("Template Name: "))
                //    tbNewTempName.Text = line.Substring(15, line.Count() - 15);
                if (line.StartsWith("From: "))
                    tbFrom.Text = line.Substring(5, line.Count() - 5);
                else if (line.StartsWith("To: "))
                    tbTo.Text = line.Substring(3, line.Count() - 3);
                else if (line.StartsWith("CC: "))
                    tbCC.Text = line.Substring(3, line.Count() - 3);
                else if (line.StartsWith("BCC: "))
                    tbBCC.Text = line.Substring(4, line.Count() - 4);
                else if (line.StartsWith("Subject: "))
                    tbSubject.Text = line.Substring(9, line.Count() - 9);
                else if (line.StartsWith("Message: "))
                    tbMessage.Text = line.Substring(9, line.Count() - 9);
                else
                    tbMessage.Text += Environment.NewLine + line;
            }
        }


        /////////
        // Events
        /////////

        private void btnCreateEdit_Click(object sender, EventArgs e)
        {
            // If all necessary fields are filled out, create/edit the template
            if (checkFields() == true)
            {
                if (btnOperator == "Create")
                {
                    txtTemplate = compileTemplate("Create");

                    using (StreamWriter sw = File.CreateText(pathTemplate + tbNewTempName.Text + ".txt"))
                    {
                        sw.WriteLine(txtTemplate);
                    }

                    MessageBox.Show("The " + tbNewTempName.Text + "template has been created.", "Template Maker - Template Created", MessageBoxButtons.OK);
                    clearFields();
                    loadDirTemplates();
                }
                else
                {
                    txtTemplate = compileTemplate("Edit");

                    File.WriteAllText(pathTemplate + cbTemplates.Text + ".txt", string.Empty);
                    File.AppendAllText(pathTemplate + cbTemplates.Text + ".txt", txtTemplate);

                    MessageBox.Show("The " + tbNewTempName.Text + "template has been edited.", "Template Maker - Template Edited", MessageBoxButtons.OK);
                }
            }
            
        }

        private void tbNewTempName_Leave(object sender, EventArgs e)
        {
            // If the tbNewTempName field is no longer an active control, determine if the text is blank.
            // If there is no text, add the default text
            if (tbNewTempName.Text == "")
            {
                tbNewTempName.Text = defaultTemplateText;
                tbNewTempName.ForeColor = Color.DarkGray;
            }
        }

        private void cbTemplates_SelectedValueChanged(object sender, EventArgs e)
        {
            // If an existing template, disable the New Template Name field
            // If the "Create New Template" option is selected, enable the New Template Name field
            if (cbTemplates.Text != "[Create New Template]")
            {
                loadTemplateData();
                tbNewTempName.Text = "";
                tbNewTempName.Enabled = false;

                changeBtnOperator("Edit");
                btnRemove.Enabled = true;
            }
            else
            {
                clearFields();
                tbNewTempName.Enabled = true;
                tbNewTempName.Text = defaultTemplateText;
                tbNewTempName.ForeColor = Color.DarkGray;

                changeBtnOperator("Create");
                btnRemove.Enabled = false;
            }

        }

        private void tbNewTempName_Enter(object sender, EventArgs e)
        {
            // Maintain the default text ("Add Template Name Here") when a new template name has not been added
            tbNewTempName.ForeColor = Color.Black;
            if (tbNewTempName.Text == defaultTemplateText)
                tbNewTempName.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDirTemplates();
            changeBtnOperator("Create");
        }

        private void tbNewTempName_KeyPress(object sender, KeyPressEventArgs e)
        {
            enterKeyPressed(e.KeyChar);
        }

        private void tbFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            enterKeyPressed(e.KeyChar);
        }

        private void tbTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            enterKeyPressed(e.KeyChar);
        }

        private void tbCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            enterKeyPressed(e.KeyChar);
        }

        private void tbBCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            enterKeyPressed(e.KeyChar);
        }

        private void tbSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            enterKeyPressed(e.KeyChar);
        }

        private void btnCreateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            enterKeyPressed(e.KeyChar);
        }

        private void btnRemove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnRemove.PerformClick();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // If a template is seleted and the btnRemove key has been pressed, the template will be removed
            // from the Templates folder, the fields template fields will be cleared, and the templates in
            // the Templates folder will be loaded to the cbTemplates combobox.
            if (cbTemplates.Text == "" || cbTemplates.Text == "[Create New Template]")
            {
                MessageBox.Show("No template selected to remove.", "Template Maker - Remove Template", MessageBoxButtons.OK);
            }
            else
            {
                File.Delete(pathTemplate + cbTemplates.Text + ".txt");

                MessageBox.Show("The " + cbTemplates.Text + "template has been removed.", "Template Maker - Remove Template", MessageBoxButtons.OK);

                clearFields();
                loadDirTemplates();
                cbTemplates.Text = "";
            }
        }
        

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.tbPreview.Text = compileTemplate("Preview");
            frm2.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void menuColorLight_Click(object sender, EventArgs e)
        {
            // If the color theme is changed to Light
            // colorThemeChange("Light");
        }

        private void menuColorDark_Click(object sender, EventArgs e)
        {
            // If the color theme is changed to Dark
            // colorThemeChange("Dark");
        }
    }
}
