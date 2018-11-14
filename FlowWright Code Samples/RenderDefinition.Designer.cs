namespace FlowWright_Code_Samples
{
    partial class RenderDefinition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ddlWFInstList = new System.Windows.Forms.ComboBox();
            this.wfPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.wfPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Workflow Instance:";
            // 
            // ddlWFInstList
            // 
            this.ddlWFInstList.FormattingEnabled = true;
            this.ddlWFInstList.Location = new System.Drawing.Point(342, 46);
            this.ddlWFInstList.Name = "ddlWFInstList";
            this.ddlWFInstList.Size = new System.Drawing.Size(335, 33);
            this.ddlWFInstList.TabIndex = 1;
            this.ddlWFInstList.SelectedIndexChanged += new System.EventHandler(this.ddlWFInstList_SelectedIndexChanged);
            // 
            // wfPic
            // 
            this.wfPic.Location = new System.Drawing.Point(15, 12);
            this.wfPic.Name = "wfPic";
            this.wfPic.Size = new System.Drawing.Size(1397, 919);
            this.wfPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.wfPic.TabIndex = 2;
            this.wfPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.wfPic);
            this.panel1.Location = new System.Drawing.Point(55, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 954);
            this.panel1.TabIndex = 3;
            // 
            // RenderDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 1111);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ddlWFInstList);
            this.Controls.Add(this.label1);
            this.Name = "RenderDefinition";
            this.Text = "RenderDefinition";
            this.Load += new System.EventHandler(this.RenderDefinition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wfPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlWFInstList;
        private System.Windows.Forms.PictureBox wfPic;
        private System.Windows.Forms.Panel panel1;
    }
}