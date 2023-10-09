using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public class ChildFormManager
    {
        public Form CurrentChildForm;
        public List<Form> currentChildForms = new List<Form>();

        public void ShowChildForm(Control parent, Form childForm)
        {
            CloseCurrentChildForm();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parent.Controls.Add(childForm);
            childForm.Show();

            CurrentChildForm = childForm;
            currentChildForms.Add(childForm);
        }

        public void CloseCurrentChildForm()
        {
            if (CurrentChildForm != null && !CurrentChildForm.IsDisposed)
            {
                CurrentChildForm.Close();
                currentChildForms.Remove(CurrentChildForm);
            }
            CurrentChildForm = null;
        }

        public void CloseAllChildForms()
        {
            foreach (Form form in currentChildForms)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                }
            }
            currentChildForms.Clear();
            CurrentChildForm = null;
        }
    }
}