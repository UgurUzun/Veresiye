using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veresiye.Service;

namespace Versiye.UI
{
    public partial class FrmMain : Form
    {
        private readonly ICompanyService companyService;
        public FrmMain(ICompanyService companyService)
        {
            this.companyService = companyService;
            InitializeComponent();
        }      

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show(companyService.GetAll().Count().ToString());
        }
    }
}
