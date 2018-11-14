namespace FlowWright_Code_Samples
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oTabs = new System.Windows.Forms.TabControl();
            this.wfDefTab = new System.Windows.Forms.TabPage();
            this.btnWFDefValidate = new System.Windows.Forms.Button();
            this.btnExportWFDef = new System.Windows.Forms.Button();
            this.btnWFDefGetInsts = new System.Windows.Forms.Button();
            this.btnWFDefRemove = new System.Windows.Forms.Button();
            this.btnWFDefCopy = new System.Windows.Forms.Button();
            this.btnWFDefGetSubs = new System.Windows.Forms.Button();
            this.btnWFDefHistory = new System.Windows.Forms.Button();
            this.btnWFDefProps = new System.Windows.Forms.Button();
            this.btnGetWFDefusingName = new System.Windows.Forms.Button();
            this.btnWFDefGetusingID = new System.Windows.Forms.Button();
            this.btnCreateWFDef = new System.Windows.Forms.Button();
            this.wfInstTab = new System.Windows.Forms.TabPage();
            this.formDefTab = new System.Windows.Forms.TabPage();
            this.formInstTab = new System.Windows.Forms.TabPage();
            this.wfTaskTab = new System.Windows.Forms.TabPage();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.rolesTab = new System.Windows.Forms.TabPage();
            this.BITab = new System.Windows.Forms.TabPage();
            this.oTabs.SuspendLayout();
            this.wfDefTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // oTabs
            // 
            this.oTabs.Controls.Add(this.wfDefTab);
            this.oTabs.Controls.Add(this.wfInstTab);
            this.oTabs.Controls.Add(this.formDefTab);
            this.oTabs.Controls.Add(this.formInstTab);
            this.oTabs.Controls.Add(this.wfTaskTab);
            this.oTabs.Controls.Add(this.usersTab);
            this.oTabs.Controls.Add(this.rolesTab);
            this.oTabs.Controls.Add(this.BITab);
            this.oTabs.Location = new System.Drawing.Point(25, 26);
            this.oTabs.Name = "oTabs";
            this.oTabs.SelectedIndex = 0;
            this.oTabs.Size = new System.Drawing.Size(1631, 1247);
            this.oTabs.TabIndex = 0;
            // 
            // wfDefTab
            // 
            this.wfDefTab.Controls.Add(this.btnWFDefValidate);
            this.wfDefTab.Controls.Add(this.btnExportWFDef);
            this.wfDefTab.Controls.Add(this.btnWFDefGetInsts);
            this.wfDefTab.Controls.Add(this.btnWFDefRemove);
            this.wfDefTab.Controls.Add(this.btnWFDefCopy);
            this.wfDefTab.Controls.Add(this.btnWFDefGetSubs);
            this.wfDefTab.Controls.Add(this.btnWFDefHistory);
            this.wfDefTab.Controls.Add(this.btnWFDefProps);
            this.wfDefTab.Controls.Add(this.btnGetWFDefusingName);
            this.wfDefTab.Controls.Add(this.btnWFDefGetusingID);
            this.wfDefTab.Controls.Add(this.btnCreateWFDef);
            this.wfDefTab.Location = new System.Drawing.Point(8, 39);
            this.wfDefTab.Name = "wfDefTab";
            this.wfDefTab.Padding = new System.Windows.Forms.Padding(3);
            this.wfDefTab.Size = new System.Drawing.Size(1615, 1200);
            this.wfDefTab.TabIndex = 0;
            this.wfDefTab.Text = "Workflow Definitions";
            this.wfDefTab.UseVisualStyleBackColor = true;
            // 
            // btnWFDefValidate
            // 
            this.btnWFDefValidate.Location = new System.Drawing.Point(29, 848);
            this.btnWFDefValidate.Name = "btnWFDefValidate";
            this.btnWFDefValidate.Size = new System.Drawing.Size(286, 75);
            this.btnWFDefValidate.TabIndex = 10;
            this.btnWFDefValidate.Text = "Validate Definition";
            this.btnWFDefValidate.UseVisualStyleBackColor = true;
            this.btnWFDefValidate.Click += new System.EventHandler(this.btnWFDefValidate_Click);
            // 
            // btnExportWFDef
            // 
            this.btnExportWFDef.Location = new System.Drawing.Point(29, 951);
            this.btnExportWFDef.Name = "btnExportWFDef";
            this.btnExportWFDef.Size = new System.Drawing.Size(286, 75);
            this.btnExportWFDef.TabIndex = 9;
            this.btnExportWFDef.Text = "Export Definition";
            this.btnExportWFDef.UseVisualStyleBackColor = true;
            this.btnExportWFDef.Click += new System.EventHandler(this.btnExportWFDef_Click);
            // 
            // btnWFDefGetInsts
            // 
            this.btnWFDefGetInsts.Location = new System.Drawing.Point(29, 1054);
            this.btnWFDefGetInsts.Name = "btnWFDefGetInsts";
            this.btnWFDefGetInsts.Size = new System.Drawing.Size(286, 75);
            this.btnWFDefGetInsts.TabIndex = 8;
            this.btnWFDefGetInsts.Text = "Get Instances";
            this.btnWFDefGetInsts.UseVisualStyleBackColor = true;
            this.btnWFDefGetInsts.Click += new System.EventHandler(this.btnWFDefGetInsts_Click);
            // 
            // btnWFDefRemove
            // 
            this.btnWFDefRemove.Location = new System.Drawing.Point(29, 750);
            this.btnWFDefRemove.Name = "btnWFDefRemove";
            this.btnWFDefRemove.Size = new System.Drawing.Size(286, 75);
            this.btnWFDefRemove.TabIndex = 7;
            this.btnWFDefRemove.Text = "Remove Definition";
            this.btnWFDefRemove.UseVisualStyleBackColor = true;
            this.btnWFDefRemove.Click += new System.EventHandler(this.btnWFDefRemove_Click);
            // 
            // btnWFDefCopy
            // 
            this.btnWFDefCopy.Location = new System.Drawing.Point(29, 650);
            this.btnWFDefCopy.Name = "btnWFDefCopy";
            this.btnWFDefCopy.Size = new System.Drawing.Size(286, 75);
            this.btnWFDefCopy.TabIndex = 6;
            this.btnWFDefCopy.Text = "Copy Definition";
            this.btnWFDefCopy.UseVisualStyleBackColor = true;
            this.btnWFDefCopy.Click += new System.EventHandler(this.btnWFDefCopy_Click);
            // 
            // btnWFDefGetSubs
            // 
            this.btnWFDefGetSubs.Location = new System.Drawing.Point(29, 545);
            this.btnWFDefGetSubs.Name = "btnWFDefGetSubs";
            this.btnWFDefGetSubs.Size = new System.Drawing.Size(286, 75);
            this.btnWFDefGetSubs.TabIndex = 5;
            this.btnWFDefGetSubs.Text = "Get Sub-Workflows";
            this.btnWFDefGetSubs.UseVisualStyleBackColor = true;
            this.btnWFDefGetSubs.Click += new System.EventHandler(this.btnWFDefGetSubs_Click);
            // 
            // btnWFDefHistory
            // 
            this.btnWFDefHistory.Location = new System.Drawing.Point(29, 445);
            this.btnWFDefHistory.Name = "btnWFDefHistory";
            this.btnWFDefHistory.Size = new System.Drawing.Size(286, 75);
            this.btnWFDefHistory.TabIndex = 4;
            this.btnWFDefHistory.Text = "Get WF Definition History";
            this.btnWFDefHistory.UseVisualStyleBackColor = true;
            this.btnWFDefHistory.Click += new System.EventHandler(this.btnWFDefHistory_Click);
            // 
            // btnWFDefProps
            // 
            this.btnWFDefProps.Location = new System.Drawing.Point(29, 336);
            this.btnWFDefProps.Name = "btnWFDefProps";
            this.btnWFDefProps.Size = new System.Drawing.Size(286, 75);
            this.btnWFDefProps.TabIndex = 3;
            this.btnWFDefProps.Text = "Get WF Definition Properties";
            this.btnWFDefProps.UseVisualStyleBackColor = true;
            this.btnWFDefProps.Click += new System.EventHandler(this.btnWFDefProps_Click);
            // 
            // btnGetWFDefusingName
            // 
            this.btnGetWFDefusingName.Location = new System.Drawing.Point(29, 236);
            this.btnGetWFDefusingName.Name = "btnGetWFDefusingName";
            this.btnGetWFDefusingName.Size = new System.Drawing.Size(286, 75);
            this.btnGetWFDefusingName.TabIndex = 2;
            this.btnGetWFDefusingName.Text = "Get WF Definition using Name";
            this.btnGetWFDefusingName.UseVisualStyleBackColor = true;
            this.btnGetWFDefusingName.Click += new System.EventHandler(this.btnGetWFDefusingName_Click);
            // 
            // btnWFDefGetusingID
            // 
            this.btnWFDefGetusingID.Location = new System.Drawing.Point(29, 131);
            this.btnWFDefGetusingID.Name = "btnWFDefGetusingID";
            this.btnWFDefGetusingID.Size = new System.Drawing.Size(286, 75);
            this.btnWFDefGetusingID.TabIndex = 1;
            this.btnWFDefGetusingID.Text = "Get WF Definition Using ID";
            this.btnWFDefGetusingID.UseVisualStyleBackColor = true;
            this.btnWFDefGetusingID.Click += new System.EventHandler(this.btnWFDefGetusingID_Click);
            // 
            // btnCreateWFDef
            // 
            this.btnCreateWFDef.Location = new System.Drawing.Point(29, 31);
            this.btnCreateWFDef.Name = "btnCreateWFDef";
            this.btnCreateWFDef.Size = new System.Drawing.Size(286, 75);
            this.btnCreateWFDef.TabIndex = 0;
            this.btnCreateWFDef.Text = "Create WF Definition";
            this.btnCreateWFDef.UseVisualStyleBackColor = true;
            this.btnCreateWFDef.Click += new System.EventHandler(this.btnCreateWFDef_Click);
            // 
            // wfInstTab
            // 
            this.wfInstTab.Location = new System.Drawing.Point(8, 39);
            this.wfInstTab.Name = "wfInstTab";
            this.wfInstTab.Padding = new System.Windows.Forms.Padding(3);
            this.wfInstTab.Size = new System.Drawing.Size(1615, 1200);
            this.wfInstTab.TabIndex = 1;
            this.wfInstTab.Text = "Workflow Instances";
            this.wfInstTab.UseVisualStyleBackColor = true;
            // 
            // formDefTab
            // 
            this.formDefTab.Location = new System.Drawing.Point(8, 39);
            this.formDefTab.Name = "formDefTab";
            this.formDefTab.Size = new System.Drawing.Size(1615, 1200);
            this.formDefTab.TabIndex = 5;
            this.formDefTab.Text = "Form Definitions";
            this.formDefTab.UseVisualStyleBackColor = true;
            // 
            // formInstTab
            // 
            this.formInstTab.Location = new System.Drawing.Point(8, 39);
            this.formInstTab.Name = "formInstTab";
            this.formInstTab.Size = new System.Drawing.Size(1615, 1200);
            this.formInstTab.TabIndex = 6;
            this.formInstTab.Text = "Form Instances";
            this.formInstTab.UseVisualStyleBackColor = true;
            // 
            // wfTaskTab
            // 
            this.wfTaskTab.Location = new System.Drawing.Point(8, 39);
            this.wfTaskTab.Name = "wfTaskTab";
            this.wfTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.wfTaskTab.Size = new System.Drawing.Size(1615, 1200);
            this.wfTaskTab.TabIndex = 2;
            this.wfTaskTab.Text = "Tasks";
            this.wfTaskTab.UseVisualStyleBackColor = true;
            // 
            // usersTab
            // 
            this.usersTab.Location = new System.Drawing.Point(8, 39);
            this.usersTab.Name = "usersTab";
            this.usersTab.Size = new System.Drawing.Size(1615, 1200);
            this.usersTab.TabIndex = 3;
            this.usersTab.Text = "Users";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // rolesTab
            // 
            this.rolesTab.Location = new System.Drawing.Point(8, 39);
            this.rolesTab.Name = "rolesTab";
            this.rolesTab.Size = new System.Drawing.Size(1615, 1200);
            this.rolesTab.TabIndex = 4;
            this.rolesTab.Text = "Roles";
            this.rolesTab.UseVisualStyleBackColor = true;
            // 
            // BITab
            // 
            this.BITab.Location = new System.Drawing.Point(8, 39);
            this.BITab.Name = "BITab";
            this.BITab.Size = new System.Drawing.Size(1615, 1200);
            this.BITab.TabIndex = 7;
            this.BITab.Text = "Business Intelligence";
            this.BITab.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 1311);
            this.Controls.Add(this.oTabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.oTabs.ResumeLayout(false);
            this.wfDefTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl oTabs;
        private System.Windows.Forms.TabPage wfDefTab;
        private System.Windows.Forms.TabPage wfInstTab;
        private System.Windows.Forms.TabPage formDefTab;
        private System.Windows.Forms.TabPage formInstTab;
        private System.Windows.Forms.TabPage wfTaskTab;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.TabPage rolesTab;
        private System.Windows.Forms.TabPage BITab;
        private System.Windows.Forms.Button btnWFDefValidate;
        private System.Windows.Forms.Button btnExportWFDef;
        private System.Windows.Forms.Button btnWFDefGetInsts;
        private System.Windows.Forms.Button btnWFDefRemove;
        private System.Windows.Forms.Button btnWFDefCopy;
        private System.Windows.Forms.Button btnWFDefGetSubs;
        private System.Windows.Forms.Button btnWFDefHistory;
        private System.Windows.Forms.Button btnWFDefProps;
        private System.Windows.Forms.Button btnGetWFDefusingName;
        private System.Windows.Forms.Button btnWFDefGetusingID;
        private System.Windows.Forms.Button btnCreateWFDef;
    }
}

