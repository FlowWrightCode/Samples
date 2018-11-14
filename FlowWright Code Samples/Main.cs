using cDevWorkflow.cDevDeAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace FlowWright_Code_Samples
{
    public partial class Main : Form
    {
        deDesign oDesign = null;

        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            oDesign = new deDesign(clsModGlobal.getConnStr(), "admin");
        }

        private void btnCreateWFDef_Click(object sender, EventArgs e)
        {
            deDefinition oDef = oDesign.createDefinition("Test Definition");
            if(oDef != null)
            {
                MessageBox.Show("Definition was created...");
            }
        }
    }
}
