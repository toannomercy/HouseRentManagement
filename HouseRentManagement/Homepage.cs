using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class Homepage : XtraForm
    {
        public Homepage()
        {
            InitializeComponent();
            SetupLabel();
        }

        private void SetupLabel()
        {
            lblName.Parent = picBoxCondo.Parent;
            picBoxCondo.Controls.Add(lblName);
        }
    }
}