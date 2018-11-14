using cDevWorkflow.cDevDeAPI;
using cDevWorkflow.cDevDecisionEngine;
using System;
using System.Collections;
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
        deDefinition oDef = null;
        bool bFlag = false;
        string definitionName = "USE YOUR DEFINITON NAME HERE";

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
            oDef = oDesign.createDefinition("Test Definition");
            if (oDef != null)
            {
                MessageBox.Show("Definition was created...");
            }
        }

        private void btnWFDefGetusingID_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefinition("WF DEFINITION ID");
        }

        private void btnGetWFDefusingName_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);
        }

        private void btnWFDefProps_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);

            Hashtable oProps = oDef.getProperties();

            oProps = oDef.getProperties("createdOn");
        }

        private void btnWFDefHistory_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);

            DataTable oDT = oDef.getHistoryDetails();
        }

        private void btnWFDefGetSubs_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);

            Dictionary<string, deDefinition> oSubs = oDef.getSubWorkflowDefinitions(subDefType.all, true);
        }

        private void btnWFDefCopy_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);

            deDefinition oCopyDef = oDef.copyDefinition(definitionName + "-copy");
        }

        private void btnWFDefRemove_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);

            bFlag = oDesign.removeDefinition(oDef.defID);
        }

        private void btnWFDefValidate_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);

            clsModelValidator oValidator = oDef.validateDefinition();
        }

        private void btnExportWFDef_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);

            string sXML = oDef.export();
        }

        private void btnWFDefGetInsts_Click(object sender, EventArgs e)
        {
            oDef = oDesign.getDefUsingName(definitionName);

            Dictionary<string, deInstance> oInsts = oDef.getInstances(executionStatus.all);
        }
    }
}
