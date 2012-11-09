namespace GitFlow.UiControls
{
    partial class InitUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxForce = new System.Windows.Forms.CheckBox();
            this.checkBoxDefaults = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxForce
            // 
            this.checkBoxForce.AutoSize = true;
            this.checkBoxForce.Location = new System.Drawing.Point(3, 26);
            this.checkBoxForce.Name = "checkBoxForce";
            this.checkBoxForce.Size = new System.Drawing.Size(59, 17);
            this.checkBoxForce.TabIndex = 4;
            this.checkBoxForce.Text = "Forced";
            this.checkBoxForce.UseVisualStyleBackColor = true;
            this.checkBoxForce.CheckedChanged += new System.EventHandler(this.CheckBoxForceCheckedChanged);
            // 
            // checkBoxDefaults
            // 
            this.checkBoxDefaults.AutoSize = true;
            this.checkBoxDefaults.Checked = true;
            this.checkBoxDefaults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDefaults.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDefaults.Name = "checkBoxDefaults";
            this.checkBoxDefaults.Size = new System.Drawing.Size(93, 17);
            this.checkBoxDefaults.TabIndex = 3;
            this.checkBoxDefaults.Text = "Using defaults";
            this.checkBoxDefaults.UseVisualStyleBackColor = true;
            this.checkBoxDefaults.CheckedChanged += new System.EventHandler(this.CheckBoxDefaultsCheckedChanged);
            // 
            // InitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxForce);
            this.Controls.Add(this.checkBoxDefaults);
            this.Name = "InitUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxForce;
        private System.Windows.Forms.CheckBox checkBoxDefaults;
    }
}
