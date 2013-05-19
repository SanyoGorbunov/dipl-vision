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
            this.lblMean = new System.Windows.Forms.Label();
            this.lblCov1 = new System.Windows.Forms.Label();
            this.lblCov2 = new System.Windows.Forms.Label();
            this.btnSaveColorModel = new System.Windows.Forms.Button();
            this.dlgSaveColorModel = new System.Windows.Forms.SaveFileDialog();
            this.btnLoadColorModel = new System.Windows.Forms.Button();
            this.dlgLoadColorModel = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadTestImage = new System.Windows.Forms.Button();
            this.dlgLoadTestImage = new System.Windows.Forms.OpenFileDialog();
            this.btnDisplayLikelihood = new System.Windows.Forms.Button();
            this.pnlThresholdingDemo = new System.Windows.Forms.Panel();
            this.lblTreshBound = new System.Windows.Forms.Label();
            this.txtTreshBound = new System.Windows.Forms.TextBox();
            this.btnSetTreshold = new System.Windows.Forms.Button();
            this.btnRunThresh = new System.Windows.Forms.Button();
            this.pnlLib.SuspendLayout();
            this.pnlLibType.SuspendLayout();
            this.gbLibType.SuspendLayout();
            this.pnlSelectRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).BeginInit();
            this.pnlResults.SuspendLayout();
            this.pnlThresholdingDemo.SuspendLayout();
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
            this.dlgLibOpen.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94\\";
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
            this.pnlResults.Controls.Add(this.btnDisplayLikelihood);
            this.pnlResults.Controls.Add(this.btnLoadColorModel);
            this.pnlResults.Controls.Add(this.btnSaveColorModel);
            this.pnlResults.Controls.Add(this.lblCov2);
            this.pnlResults.Controls.Add(this.lblCov1);
            this.pnlResults.Controls.Add(this.lblMean);
            this.pnlResults.Location = new System.Drawing.Point(682, 61);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(171, 194);
            this.pnlResults.TabIndex = 4;
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(27, 17);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(35, 13);
            this.lblMean.TabIndex = 0;
            this.lblMean.Text = "label1";
            // 
            // lblCov1
            // 
            this.lblCov1.AutoSize = true;
            this.lblCov1.Location = new System.Drawing.Point(27, 51);
            this.lblCov1.Name = "lblCov1";
            this.lblCov1.Size = new System.Drawing.Size(35, 13);
            this.lblCov1.TabIndex = 1;
            this.lblCov1.Text = "label1";
            // 
            // lblCov2
            // 
            this.lblCov2.AutoSize = true;
            this.lblCov2.Location = new System.Drawing.Point(27, 74);
            this.lblCov2.Name = "lblCov2";
            this.lblCov2.Size = new System.Drawing.Size(35, 13);
            this.lblCov2.TabIndex = 2;
            this.lblCov2.Text = "label1";
            // 
            // btnSaveColorModel
            // 
            this.btnSaveColorModel.Location = new System.Drawing.Point(23, 98);
            this.btnSaveColorModel.Name = "btnSaveColorModel";
            this.btnSaveColorModel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveColorModel.TabIndex = 3;
            this.btnSaveColorModel.Text = "Save";
            this.btnSaveColorModel.UseVisualStyleBackColor = true;
            this.btnSaveColorModel.Click += new System.EventHandler(this.btnSaveColorModel_Click);
            // 
            // dlgSaveColorModel
            // 
            this.dlgSaveColorModel.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\SkinC" +
                "olorModels";
            // 
            // btnLoadColorModel
            // 
            this.btnLoadColorModel.Location = new System.Drawing.Point(23, 127);
            this.btnLoadColorModel.Name = "btnLoadColorModel";
            this.btnLoadColorModel.Size = new System.Drawing.Size(75, 23);
            this.btnLoadColorModel.TabIndex = 4;
            this.btnLoadColorModel.Text = "Load";
            this.btnLoadColorModel.UseVisualStyleBackColor = true;
            this.btnLoadColorModel.Click += new System.EventHandler(this.btnLoadColorModel_Click);
            // 
            // dlgLoadColorModel
            // 
            this.dlgLoadColorModel.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\SkinC" +
                "olorModels";
            // 
            // btnLoadTestImage
            // 
            this.btnLoadTestImage.Location = new System.Drawing.Point(394, 23);
            this.btnLoadTestImage.Name = "btnLoadTestImage";
            this.btnLoadTestImage.Size = new System.Drawing.Size(106, 23);
            this.btnLoadTestImage.TabIndex = 5;
            this.btnLoadTestImage.Text = "Load Test Image";
            this.btnLoadTestImage.UseVisualStyleBackColor = true;
            this.btnLoadTestImage.Click += new System.EventHandler(this.btnLoadTestImage_Click);
            // 
            // dlgLoadTestImage
            // 
            this.dlgLoadTestImage.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94\\";
            // 
            // btnDisplayLikelihood
            // 
            this.btnDisplayLikelihood.Location = new System.Drawing.Point(23, 156);
            this.btnDisplayLikelihood.Name = "btnDisplayLikelihood";
            this.btnDisplayLikelihood.Size = new System.Drawing.Size(105, 30);
            this.btnDisplayLikelihood.TabIndex = 5;
            this.btnDisplayLikelihood.Text = "Test Likelihood";
            this.btnDisplayLikelihood.UseVisualStyleBackColor = true;
            this.btnDisplayLikelihood.Click += new System.EventHandler(this.btnDisplayLikelihood_Click);
            // 
            // pnlThresholdingDemo
            // 
            this.pnlThresholdingDemo.Controls.Add(this.btnRunThresh);
            this.pnlThresholdingDemo.Controls.Add(this.btnSetTreshold);
            this.pnlThresholdingDemo.Controls.Add(this.txtTreshBound);
            this.pnlThresholdingDemo.Controls.Add(this.lblTreshBound);
            this.pnlThresholdingDemo.Location = new System.Drawing.Point(683, 268);
            this.pnlThresholdingDemo.Name = "pnlThresholdingDemo";
            this.pnlThresholdingDemo.Size = new System.Drawing.Size(170, 106);
            this.pnlThresholdingDemo.TabIndex = 6;
            // 
            // lblTreshBound
            // 
            this.lblTreshBound.AutoSize = true;
            this.lblTreshBound.Location = new System.Drawing.Point(3, 20);
            this.lblTreshBound.Name = "lblTreshBound";
            this.lblTreshBound.Size = new System.Drawing.Size(41, 13);
            this.lblTreshBound.TabIndex = 0;
            this.lblTreshBound.Text = "Bound:";
            // 
            // txtTreshBound
            // 
            this.txtTreshBound.Location = new System.Drawing.Point(82, 17);
            this.txtTreshBound.Name = "txtTreshBound";
            this.txtTreshBound.Size = new System.Drawing.Size(73, 20);
            this.txtTreshBound.TabIndex = 1;
            // 
            // btnSetTreshold
            // 
            this.btnSetTreshold.Location = new System.Drawing.Point(68, 43);
            this.btnSetTreshold.Name = "btnSetTreshold";
            this.btnSetTreshold.Size = new System.Drawing.Size(87, 23);
            this.btnSetTreshold.TabIndex = 4;
            this.btnSetTreshold.Text = "Set Threshold";
            this.btnSetTreshold.UseVisualStyleBackColor = true;
            this.btnSetTreshold.Click += new System.EventHandler(this.btnSetTreshold_Click);
            // 
            // btnRunThresh
            // 
            this.btnRunThresh.Location = new System.Drawing.Point(6, 72);
            this.btnRunThresh.Name = "btnRunThresh";
            this.btnRunThresh.Size = new System.Drawing.Size(149, 23);
            this.btnRunThresh.TabIndex = 5;
            this.btnRunThresh.Text = "Run Thresholding";
            this.btnRunThresh.UseVisualStyleBackColor = true;
            this.btnRunThresh.Click += new System.EventHandler(this.btnRunThresh_Click);
            // 
            // FaceColorLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 409);
            this.Controls.Add(this.pnlThresholdingDemo);
            this.Controls.Add(this.btnLoadTestImage);
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
            this.pnlThresholdingDemo.ResumeLayout(false);
            this.pnlThresholdingDemo.PerformLayout();
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
        private System.Windows.Forms.Label lblCov2;
        private System.Windows.Forms.Label lblCov1;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Button btnSaveColorModel;
        private System.Windows.Forms.SaveFileDialog dlgSaveColorModel;
        private System.Windows.Forms.Button btnLoadColorModel;
        private System.Windows.Forms.OpenFileDialog dlgLoadColorModel;
        private System.Windows.Forms.Button btnLoadTestImage;
        private System.Windows.Forms.OpenFileDialog dlgLoadTestImage;
        private System.Windows.Forms.Button btnDisplayLikelihood;
        private System.Windows.Forms.Panel pnlThresholdingDemo;
        private System.Windows.Forms.Button btnSetTreshold;
        private System.Windows.Forms.TextBox txtTreshBound;
        private System.Windows.Forms.Label lblTreshBound;
        private System.Windows.Forms.Button btnRunThresh;

    }
}

