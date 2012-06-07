namespace GitFlow.UiControls
{
    partial class GitFlowInitForm
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
            this.checkBoxDefaults = new System.Windows.Forms.CheckBox();
            this.checkBoxForce = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxDefaults
            // 
            this.checkBoxDefaults.AutoSize = true;
            this.checkBoxDefaults.Checked = true;
            this.checkBoxDefaults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDefaults.Location = new System.Drawing.Point(13, 13);
            this.checkBoxDefaults.Name = "checkBoxDefaults";
            this.checkBoxDefaults.Size = new System.Drawing.Size(93, 17);
            this.checkBoxDefaults.TabIndex = 1;
            this.checkBoxDefaults.Text = "Using defaults";
            this.checkBoxDefaults.UseVisualStyleBackColor = true;
            // 
            // checkBoxForce
            // 
            this.checkBoxForce.AutoSize = true;
            this.checkBoxForce.Location = new System.Drawing.Point(13, 37);
            this.checkBoxForce.Name = "checkBoxForce";
            this.checkBoxForce.Size = new System.Drawing.Size(59, 17);
            this.checkBoxForce.TabIndex = 2;
            this.checkBoxForce.Text = "Forced";
            this.checkBoxForce.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(297, 129);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClicked);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(216, 129);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.OnButtonOkClicked);
            // 
            // GitFlowInitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 164);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkBoxForce);
            this.Controls.Add(this.checkBoxDefaults);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "GitFlowInitForm";
            this.Text = "Git flow - Init";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDefaults;
        private System.Windows.Forms.CheckBox checkBoxForce;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}