namespace SkinDetection
{
    partial class FaceColorLib
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
            this.pnlLib = new System.Windows.Forms.Panel();
            this.lbLib = new System.Windows.Forms.ListBox();
            this.btnLibAdd = new System.Windows.Forms.Button();
            this.dlgLibOpen = new System.Windows.Forms.OpenFileDialog();
            this.pnlLibType = new System.Windows.Forms.Panel();
            this.gbLibType = new System.Windows.Forms.GroupBox();
            this.rbLibTypeManual = new System.Windows.Forms.RadioButton();
            this.rbLibTypeAuto = new System.Windows.Forms.RadioButton();
            this.rbLibTypeFromFile = new System.Windows.Forms.RadioButton();
            this.pnlLib.SuspendLayout();
            this.pnlLibType.SuspendLayout();
            this.gbLibType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLib
            // 
            this.pnlLib.Controls.Add(this.btnLibAdd);
            this.pnlLib.Controls.Add(this.lbLib);
            this.pnlLib.Location = new System.Drawing.Point(12, 109);
            this.pnlLib.Name = "pnlLib";
            this.pnlLib.Size = new System.Drawing.Size(312, 265);
            this.pnlLib.TabIndex = 0;
            // 
            // lbLib
            // 
            this.lbLib.FormattingEnabled = true;
            this.lbLib.Location = new System.Drawing.Point(13, 16);
            this.lbLib.Name = "lbLib";
            this.lbLib.Size = new System.Drawing.Size(191, 238);
            this.lbLib.TabIndex = 0;
            // 
            // btnLibAdd
            // 
            this.btnLibAdd.Location = new System.Drawing.Point(210, 16);
            this.btnLibAdd.Name = "btnLibAdd";
            this.btnLibAdd.Size = new System.Drawing.Size(75, 23);
            this.btnLibAdd.TabIndex = 1;
            this.btnLibAdd.Text = "Add";
            this.btnLibAdd.UseVisualStyleBackColor = true;
            this.btnLibAdd.Click += new System.EventHandler(this.btnLibAdd_Click);
            // 
            // dlgLibOpen
            // 
            this.dlgLibOpen.FileName = "openFileDialog1";
            // 
            // pnlLibType
            // 
            this.pnlLibType.Controls.Add(this.gbLibType);
            this.pnlLibType.Location = new System.Drawing.Point(12, 12);
            this.pnlLibType.Name = "pnlLibType";
            this.pnlLibType.Size = new System.Drawing.Size(312, 60);
            this.pnlLibType.TabIndex = 1;
            // 
            // gbLibType
            // 
            this.gbLibType.Controls.Add(this.rbLibTypeFromFile);
            this.gbLibType.Controls.Add(this.rbLibTypeAuto);
            this.gbLibType.Controls.Add(this.rbLibTypeManual);
            this.gbLibType.Location = new System.Drawing.Point(4, 7);
            this.gbLibType.Name = "gbLibType";
            this.gbLibType.Size = new System.Drawing.Size(305, 50);
            this.gbLibType.TabIndex = 0;
            this.gbLibType.TabStop = false;
            this.gbLibType.Text = "Lib Type";
            // 
            // rbLibTypeManual
            // 
            this.rbLibTypeManual.AutoSize = true;
            this.rbLibTypeManual.Location = new System.Drawing.Point(9, 19);
            this.rbLibTypeManual.Name = "rbLibTypeManual";
            this.rbLibTypeManual.Size = new System.Drawing.Size(60, 17);
            this.rbLibTypeManual.TabIndex = 0;
            this.rbLibTypeManual.TabStop = true;
            this.rbLibTypeManual.Text = "Manual";
            this.rbLibTypeManual.UseVisualStyleBackColor = true;
            // 
            // rbLibTypeAuto
            // 
            this.rbLibTypeAuto.AutoSize = true;
            this.rbLibTypeAuto.Location = new System.Drawing.Point(75, 19);
            this.rbLibTypeAuto.Name = "rbLibTypeAuto";
            this.rbLibTypeAuto.Size = new System.Drawing.Size(47, 17);
            this.rbLibTypeAuto.TabIndex = 2;
            this.rbLibTypeAuto.TabStop = true;
            this.rbLibTypeAuto.Text = "Auto";
            this.rbLibTypeAuto.UseVisualStyleBackColor = true;
            // 
            // rbLibTypeFromFile
            // 
            this.rbLibTypeFromFile.AutoSize = true;
            this.rbLibTypeFromFile.Location = new System.Drawing.Point(128, 19);
            this.rbLibTypeFromFile.Name = "rbLibTypeFromFile";
            this.rbLibTypeFromFile.Size = new System.Drawing.Size(67, 17);
            this.rbLibTypeFromFile.TabIndex = 3;
            this.rbLibTypeFromFile.TabStop = true;
            this.rbLibTypeFromFile.Text = "From File";
            this.rbLibTypeFromFile.UseVisualStyleBackColor = true;
            // 
            // FaceColorLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 409);
            this.Controls.Add(this.pnlLibType);
            this.Controls.Add(this.pnlLib);
            this.Name = "FaceColorLib";
            this.Text = "Form1";
            this.pnlLib.ResumeLayout(false);
            this.pnlLibType.ResumeLayout(false);
            this.gbLibType.ResumeLayout(false);
            this.gbLibType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLib;
        private System.Windows.Forms.Button btnLibAdd;
        private System.Windows.Forms.ListBox lbLib;
        private System.Windows.Forms.OpenFileDialog dlgLibOpen;
        private System.Windows.Forms.Panel pnlLibType;
        private System.Windows.Forms.GroupBox gbLibType;
        private System.Windows.Forms.RadioButton rbLibTypeFromFile;
        private System.Windows.Forms.RadioButton rbLibTypeAuto;
        private System.Windows.Forms.RadioButton rbLibTypeManual;

    }
}

