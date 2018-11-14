using cDevWorkflow.cDevDeAPI;
using cDevWorkflow.cDevDecisionEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_CodFlowWright_Code_Samplese_App
{
    public partial class RenderDefinition : Form
    {
        public RenderDefinition()
        {
            InitializeComponent();
        }

        private void RenderDefinition_Load(object sender, EventArgs e)
        {
            deRuntime oRuntime = new deRuntime(clsModGlobal.getConnStr(), "admin");

            DataTable oDT = oRuntime.getInstancesData();

            ddlWFInstList.Items.Clear();

            ddlWFInstList.DisplayMember = "INSTANCENAME";
            ddlWFInstList.ValueMember = "INSTANCEID";
            ddlWFInstList.DataSource = oDT;

        }

        private void ddlWFInstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string instanceID = ddlWFInstList.SelectedValue.ToString();

            deRuntime oRuntime = new deRuntime(clsModGlobal.getConnStr(), "admin");

            deInstance oInst = oRuntime.getInstance(instanceID);

            if (oInst == null) return;

            string imageFilePath = clsConfigurationSettings.getValue(clsModGlobal.getConnStr(), "imageFilePath");

            if(!Directory.Exists(@"c:\temp"))
            {
                Directory.CreateDirectory(@"c:\temp");
            }

            string sFilePath = $@"c:\temp\{instanceID}.png";

            bool bFlag= oInst.generateModelGraphic(true, ref sFilePath,  imageFilePath);

            if(bFlag)
            {
                wfPic.Image = Image.FromFile(sFilePath);
            }
        }
    }
}
