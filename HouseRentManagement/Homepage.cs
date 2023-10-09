using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class Homepage : DevExpress.XtraEditors.XtraForm
    {
        public Homepage()
        {
            InitializeComponent();
            lblName.Parent = picBoxCondo.Parent;
            picBoxCondo.Controls.Add(lblName);
        }

    }
}