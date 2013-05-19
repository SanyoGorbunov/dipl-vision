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
            this.btnLibAdd = new System.Windows.Forms.Button();
            this.lbLib = new System.Windows.Forms.ListBox();
            this.dlgLibOpen = new System.Windows.Forms.OpenFileDialog();
            this.pnlLibType = new System.Windows.Forms.Panel();
            this.gbLibType = new System.Windows.Forms.GroupBox();
            this.rbLibTypeFromFile = new System.Windows.Forms.RadioButton();
            this.rbLibTypeAuto = new System.Windows.Forms.RadioButton();
            this.rbLibTypeManual = new System.Windows.Forms.RadioButton();
            this.pnlSelectRegion = new System.Windows.Forms.Panel();
            this.pbFace = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblRedMean = new System.Windows.Forms.Label();
            this.lblRedMeanRes = new System.Windows.Forms.Label();
            this.lblRedDispRes = new System.Windows.Forms.Label();
            this.lblRedDisp = new System.Windows.Forms.Label();
            this.lblBlueDispRes = new System.Windows.Forms.Label();
            this.lblBlueDisp = new System.Windows.Forms.Label();
            this.lblBlueMeanRes = new System.Windows.Forms.Label();
            this.lblBlueMean = new System.Windows.Forms.Label();
            this.pnlLib.SuspendLayout();
            this.pnlLibType.SuspendLayout();
            this.gbLibType.SuspendLayout();
            this.pnlSelectRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).BeginInit();
            this.pnlResults.SuspendLayout();
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
            // lbLib
            // 
            this.lbLib.FormattingEnabled = true;
            this.lbLib.Location = new System.Drawing.Point(13, 16);
            this.lbLib.Name = "lbLib";
            this.lbLib.Size = new System.Drawing.Size(191, 238);
            this.lbLib.TabIndex = 0;
            this.lbLib.SelectedIndexChanged += new System.EventHandler(this.lbLib_SelectedIndexChanged);
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
            // pnlSelectRegion
            // 
            this.pnlSelectRegion.Controls.Add(this.pbFace);
            this.pnlSelectRegion.Location = new System.Drawing.Point(330, 109);
            this.pnlSelectRegion.Name = "pnlSelectRegion";
            this.pnlSelectRegion.Size = new System.Drawing.Size(299, 265);
            this.pnlSelectRegion.TabIndex = 2;
            // 
            // pbFace
            // 
            this.pbFace.Location = new System.Drawing.Point(3, 3);
            this.pbFace.Name = "pbFace";
            this.pbFace.Size = new System.Drawing.Size(167, 189);
            this.pbFace.TabIndex = 0;
            this.pbFace.TabStop = false;
            this.pbFace.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFace_Paint);
            this.pbFace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFace_MouseDown);
            this.pbFace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFace_MouseMove);
            this.pbFace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbFace_MouseUp);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(682, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 43);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.lblBlueDispRes);
            this.pnlResults.Controls.Add(this.lblBlueDisp);
            this.pnlResults.Controls.Add(this.lblBlueMeanRes);
            this.pnlResults.Controls.Add(this.lblBlueMean);
            this.pnlResults.Controls.Add(this.lblRedDispRes);
            this.pnlResults.Controls.Add(this.lblRedDisp);
            this.pnlResults.Controls.Add(this.lblRedMeanRes);
            this.pnlResults.Controls.Add(this.lblRedMean);
            this.pnlResults.Location = new System.Drawing.Point(682, 61);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(171, 135);
            this.pnlResults.TabIndex = 4;
            // 
            // lblRedMean
            // 
            this.lblRedMean.AutoSize = true;
            this.lblRedMean.Location = new System.Drawing.Point(3, 10);
            this.lblRedMean.Name = "lblRedMean";
            this.lblRedMean.Size = new System.Drawing.Size(107, 13);
            this.lblRedMean.TabIndex = 0;
            this.lblRedMean.Text = "Chromatic Red Mean";
            // 
            // lblRedMeanRes
            // 
            this.lblRedMeanRes.AutoSize = true;
            this.lblRedMeanRes.Location = new System.Drawing.Point(116, 10);
            this.lblRedMeanRes.Name = "lblRedMeanRes";
            this.lblRedMeanRes.Size = new System.Drawing.Size(35, 13);
            this.lblRedMeanRes.TabIndex = 1;
            this.lblRedMeanRes.Text = "label1";
            // 
            // lblRedDispRes
            // 
            this.lblRedDispRes.AutoSize = true;
            this.lblRedDispRes.Location = new System.Drawing.Point(116, 35);
            this.lblRedDispRes.Name = "lblRedDispRes";
            this.lblRedDispRes.Size = new System.Drawing.Size(35, 13);
            this.lblRedDispRes.TabIndex = 3;
            this.lblRedDispRes.Text = "label1";
            // 
            // lblRedDisp
            // 
            this.lblRedDisp.AutoSize = true;
            this.lblRedDisp.Location = new System.Drawing.Point(3, 35);
            this.lblRedDisp.Name = "lblRedDisp";
            this.lblRedDisp.Size = new System.Drawing.Size(101, 13);
            this.lblRedDisp.TabIndex = 2;
            this.lblRedDisp.Text = "Chromatic Red Disp";
            // 
            // lblBlueDispRes
            // 
            this.lblBlueDispRes.AutoSize = true;
            this.lblBlueDispRes.Location = new System.Drawing.Point(116, 94);
            this.lblBlueDispRes.Name = "lblBlueDispRes";
            this.lblBlueDispRes.Size = new System.Drawing.Size(35, 13);
            this.lblBlueDispRes.TabIndex = 7;
            this.lblBlueDispRes.Text = "label1";
            // 
            // lblBlueDisp
            // 
            this.lblBlueDisp.AutoSize = true;
            this.lblBlueDisp.Location = new System.Drawing.Point(3, 94);
            this.lblBlueDisp.Name = "lblBlueDisp";
            this.lblBlueDisp.Size = new System.Drawing.Size(102, 13);
            this.lblBlueDisp.TabIndex = 6;
            this.lblBlueDisp.Text = "Chromatic Blue Disp";
            // 
            // lblBlueMeanRes
            // 
            this.lblBlueMeanRes.AutoSize = true;
            this.lblBlueMeanRes.Location = new System.Drawing.Point(116, 69);
            this.lblBlueMeanRes.Name = "lblBlueMeanRes";
            this.lblBlueMeanRes.Size = new System.Drawing.Size(35, 13);
            this.lblBlueMeanRes.TabIndex = 5;
            this.lblBlueMeanRes.Text = "label1";
            // 
            // lblBlueMean
            // 
            this.lblBlueMean.AutoSize = true;
            this.lblBlueMean.Location = new System.Drawing.Point(3, 69);
            this.lblBlueMean.Name = "lblBlueMean";
            this.lblBlueMean.Size = new System.Drawing.Size(108, 13);
            this.lblBlueMean.TabIndex = 4;
            this.lblBlueMean.Text = "Chromatic Blue Mean";
            // 
            // FaceColorLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 409);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlSelectRegion);
            this.Controls.Add(this.pnlLibType);
            this.Controls.Add(this.pnlLib);
            this.Name = "FaceColorLib";
            this.Text = "Face Color Library";
            this.pnlLib.ResumeLayout(false);
            this.pnlLibType.ResumeLayout(false);
            this.gbLibType.ResumeLayout(false);
            this.gbLibType.PerformLayout();
            this.pnlSelectRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).EndInit();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
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
        private System.Windows.Forms.Panel pnlSelectRegion;
        private System.Windows.Forms.PictureBox pbFace;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblBlueDispRes;
        private System.Windows.Forms.Label lblBlueDisp;
        private System.Windows.Forms.Label lblBlueMeanRes;
        private System.Windows.Forms.Label lblBlueMean;
        private System.Windows.Forms.Label lblRedDispRes;
        private System.Windows.Forms.Label lblRedDisp;
        private System.Windows.Forms.Label lblRedMeanRes;
        private System.Windows.Forms.Label lblRedMean;

    }
}

