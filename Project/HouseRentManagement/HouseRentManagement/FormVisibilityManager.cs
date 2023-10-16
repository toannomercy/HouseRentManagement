using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public class FormVisibilityManager
    {
        private bool isVisible;
        private Control formPanel;
        private Form currentForm;

        public FormVisibilityManager(Control panel)
        {
            this.formPanel = panel;
            isVisible = false;
        }

        public void ShowForm(Form form)
        {
            formPanel.Controls.Clear();
            formPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            formPanel.Visible = true;
            isVisible = true;
            currentForm = form;
        }

        public void HideForm()
        {
            formPanel.Visible = false;
            isVisible = false;
            currentForm = null;
        }

        public bool IsFormVisible()
        {
            return isVisible;
        }

        public Form GetCurrentForm()
        {
            return currentForm;
        }
    }
}