using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happytech;
using HappyTech.Classes;
using Microsoft.VisualBasic;

namespace HappyTech.Pages
{
    public partial class EditTemplates : UserControl
    {
        // Variables for the core functionality of the program (Don't delete)
        Database db = new Database();
        Template SelectedTemplate = new Template();
        Int32 SelectedSectionID = 0;



        public EditTemplates()
        {
            InitializeComponent();
            List<Template> Templates = db.GetTemplateNames();

            // Set up
            flSection.HorizontalScroll.Maximum = 0;
            flSection.AutoScroll = false;
            flSection.VerticalScroll.Visible = false;
            flSection.AutoScroll = true;

            // Insert the existing templates into the Dropdown Menu
            foreach (Template template in Templates)
                cbSelectTemplate.Items.Insert(template.TemplateId, template.Name);
        }

        private void SelectTemplate(object sender, EventArgs e)
        {
            // Clear previous template footprint.
            SelectedSectionID = 0;
            flSectionButtons.Controls.Clear();
            flSection.Controls.Clear();
            grpSection.Text = "No section selected";

            // Disable the delete section button
            btnDeleteSection.Visible = false;
            btnAddComment.Visible = false;
            btnUpdateFields.Visible = false;

            // Return if no template was selected
            if (cbSelectTemplate.SelectedIndex == 0)
                return;

            // Select the template.
            SelectedTemplate = db.GetTemplateData(cbSelectTemplate.SelectedIndex);

            // Generate section buttons related to the selected template.
            foreach (var section in SelectedTemplate.Sections)
                flSectionButtons.Controls.Add(GenerateButton(section));

            // Generate 'Add Section' Button.
            flSectionButtons.Controls.Add(GenerateAddSectionButton());

        }

        private void AddComment(object sender, EventArgs e)
        {
            // Generate a new comment
            Comment comment = new Comment();
            comment.ShortName = "Short code: Replace";
            comment.CommentText = "Comment: Replace";

            // Add comment to the database
            db.AddComments(comment, SelectedSectionID);

            // Refresh the section controls
            Control section = new Control();
            section.Name = SelectedSectionID.ToString();
            SelectTemplate(sender, e);
            SelectSection(section, new EventArgs());
        }


        private void UpdateTemplate(object sender, EventArgs e)
        {
           // Ask user if he is sure.
           if(MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           {
                foreach(TextBox comment in flSection.Controls)
                {
                    // If it's a comment
                    if (comment.Multiline)
                        db.UpdateComment(comment.Text, int.Parse(comment.Tag.ToString()));
                    else
                        db.UpdateShortName(comment.Text, int.Parse(comment.Tag.ToString()));
                }
           }
        }

        private Button GenerateAddSectionButton()
        {
            // Set data properties
            Button btn = new Button();
            btn.Name = "btnAddSection";
            btn.Text = "+";

            // Set appearance properties
            btn.BackColor = Color.FromArgb(182, 42, 101);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Width = 33;
            btn.Height = 33;

            // Subscribe to the select selection event
            btn.Click += AddSection;
            return btn;
        }

        private Button GenerateButton(Section section)
        {
            // Generate button
            var btn = new Button();

            // Set data properties
            btn.Name = section.SectionId.ToString();
            btn.Text = section.Title;

            // Set appearance properties
            btn.BackColor = Color.FromArgb(182, 42, 101);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Width = 88;
            btn.Height = 33;

            // Subscribe to the select selection event
            btn.Click += SelectSection;
            return btn;
        }

        private void GenerateComment(Comment comment)
        {
            // Generate short code
            TextBox shortCode = new TextBox();

            // Set appearance
            shortCode.ForeColor = Color.White;
            shortCode.BackColor = Color.FromArgb(39, 44, 74);
            shortCode.Font = new Font("Segoe UI", 12);
            shortCode.BorderStyle = BorderStyle.None;
            shortCode.Width = flSection.Width - 15;

            // Set the text to the existing text in the DB
            shortCode.Name = $"Short {comment.CommentId}";
            shortCode.Text = comment.ShortName;
            shortCode.Tag = comment.CommentId;                


            // Generate comment
            TextBox com = new TextBox();

            // Set appearance
            com.Font = new Font("Segoe UI", 12);
            com.BorderStyle = BorderStyle.None;
            com.BackColor = Color.FromArgb(39, 44, 74);
            com.Margin = new Padding(0, 0, 0, 17);
            com.ForeColor = Color.White;
            com.Multiline = true;
            com.Width = flSection.Width - 15;
            com.Height = 54;

            // Set the text to the existing text in the DB
            com.Name = $"Comment {comment.CommentId}";
            com.Text = comment.CommentText;
            com.Tag = comment.CommentId;

            // Add to the section displayer
            flSection.Controls.Add(shortCode);
            flSection.Controls.Add(com);    
        }

        private void SelectSection(object sender, EventArgs e)
        {
            // Store section ID
            SelectedSectionID = int.Parse(((Control)sender).Name);

            // Display section related buttons
            btnDeleteSection.Visible = true;
            btnAddComment.Visible = true;
            btnUpdateFields.Visible = true;

            // Clear previous section (no warning if not saved yet)
            flSection.Controls.Clear();

            // Find the section related to the button clicked
            foreach(var section in SelectedTemplate.Sections)
            {
                if(section.SectionId == SelectedSectionID)
                {
                    // Update information
                    grpSection.Text = section.Title;

                    // Fill out the panel with the section information
                    foreach (Comment comment in section.Comments)
                        GenerateComment(comment);
                }
            }


        }

        private void AddSection(object sender, EventArgs e)
        {
            // Ask for the section name and verify that it is not empty.
            string sectionName = Interaction.InputBox("Inser the section's name: ", "Section name", "");
            if(!string.IsNullOrEmpty(sectionName))
            {
                // Add section to database
                db.AddSection(SelectedTemplate, sectionName);

                // Refresh section list
                SelectTemplate(sender, e);

            }
            else
                MessageBox.Show("Invalid name, please try again.", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeleteSection(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete the selected section?", "Delete section", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.RemoveSection(SelectedSectionID);
                SelectTemplate(sender, e);
            }
        }
    }
}
