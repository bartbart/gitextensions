namespace GitFlow
{
    partial class GitFlowForm
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
            this.buttonInit = new System.Windows.Forms.Button();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.textBoxLogging = new System.Windows.Forms.TextBox();
            this.buttonFeature = new System.Windows.Forms.Button();
            this.buttonRelease = new System.Windows.Forms.Button();
            this.buttonHotfix = new System.Windows.Forms.Button();
            this.buttonSupport = new System.Windows.Forms.Button();
            this.buttonVersion = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.panelAction = new System.Windows.Forms.Panel();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInit.Location = new System.Drawing.Point(4, 12);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(100, 25);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.OnButtonInitClicked);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.Location = new System.Drawing.Point(12, 12);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.groupBoxAction);
            this.mainSplitContainer.Panel1.Controls.Add(this.buttonExecute);
            this.mainSplitContainer.Panel1.Controls.Add(this.buttonVersion);
            this.mainSplitContainer.Panel1.Controls.Add(this.buttonSupport);
            this.mainSplitContainer.Panel1.Controls.Add(this.buttonHotfix);
            this.mainSplitContainer.Panel1.Controls.Add(this.buttonRelease);
            this.mainSplitContainer.Panel1.Controls.Add(this.buttonFeature);
            this.mainSplitContainer.Panel1.Controls.Add(this.buttonInit);
            this.mainSplitContainer.Panel1MinSize = 150;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.groupBoxLogging);
            this.mainSplitContainer.Panel2MinSize = 195;
            this.mainSplitContainer.Size = new System.Drawing.Size(568, 549);
            this.mainSplitContainer.SplitterDistance = 314;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // textBoxLogging
            // 
            this.textBoxLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogging.Location = new System.Drawing.Point(6, 19);
            this.textBoxLogging.Multiline = true;
            this.textBoxLogging.Name = "textBoxLogging";
            this.textBoxLogging.Size = new System.Drawing.Size(550, 200);
            this.textBoxLogging.TabIndex = 0;
            // 
            // buttonFeature
            // 
            this.buttonFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFeature.Location = new System.Drawing.Point(4, 43);
            this.buttonFeature.Name = "buttonFeature";
            this.buttonFeature.Size = new System.Drawing.Size(100, 25);
            this.buttonFeature.TabIndex = 1;
            this.buttonFeature.Text = "Feature";
            this.buttonFeature.UseVisualStyleBackColor = true;
            // 
            // buttonRelease
            // 
            this.buttonRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRelease.Location = new System.Drawing.Point(4, 74);
            this.buttonRelease.Name = "buttonRelease";
            this.buttonRelease.Size = new System.Drawing.Size(100, 25);
            this.buttonRelease.TabIndex = 2;
            this.buttonRelease.Text = "Release";
            this.buttonRelease.UseVisualStyleBackColor = true;
            // 
            // buttonHotfix
            // 
            this.buttonHotfix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHotfix.Location = new System.Drawing.Point(4, 105);
            this.buttonHotfix.Name = "buttonHotfix";
            this.buttonHotfix.Size = new System.Drawing.Size(100, 25);
            this.buttonHotfix.TabIndex = 3;
            this.buttonHotfix.Text = "Hotfix";
            this.buttonHotfix.UseVisualStyleBackColor = true;
            // 
            // buttonSupport
            // 
            this.buttonSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupport.Location = new System.Drawing.Point(4, 136);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(100, 25);
            this.buttonSupport.TabIndex = 4;
            this.buttonSupport.Text = "Support";
            this.buttonSupport.UseVisualStyleBackColor = true;
            // 
            // buttonVersion
            // 
            this.buttonVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVersion.Location = new System.Drawing.Point(4, 167);
            this.buttonVersion.Name = "buttonVersion";
            this.buttonVersion.Size = new System.Drawing.Size(100, 25);
            this.buttonVersion.TabIndex = 5;
            this.buttonVersion.Text = "Version";
            this.buttonVersion.UseVisualStyleBackColor = true;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Location = new System.Drawing.Point(465, 286);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(100, 25);
            this.buttonExecute.TabIndex = 0;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAction.Controls.Add(this.panelAction);
            this.groupBoxAction.Location = new System.Drawing.Point(110, 3);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(455, 277);
            this.groupBoxAction.TabIndex = 6;
            this.groupBoxAction.TabStop = false;
            // 
            // panelAction
            // 
            this.panelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAction.Location = new System.Drawing.Point(6, 19);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(443, 252);
            this.panelAction.TabIndex = 0;
            // 
            // groupBoxLogging
            // 
            this.groupBoxLogging.Controls.Add(this.textBoxLogging);
            this.groupBoxLogging.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLogging.Name = "groupBoxLogging";
            this.groupBoxLogging.Size = new System.Drawing.Size(562, 225);
            this.groupBoxLogging.TabIndex = 1;
            this.groupBoxLogging.TabStop = false;
            this.groupBoxLogging.Text = "Logging";
            // 
            // GitFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 573);
            this.Controls.Add(this.mainSplitContainer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "GitFlowForm";
            this.Text = "Git flow";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button buttonVersion;
        private System.Windows.Forms.Button buttonSupport;
        private System.Windows.Forms.Button buttonHotfix;
        private System.Windows.Forms.Button buttonRelease;
        private System.Windows.Forms.Button buttonFeature;
        private System.Windows.Forms.TextBox textBoxLogging;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.GroupBox groupBoxLogging;
    }
}