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
            this.btnSaveLib = new System.Windows.Forms.Button();
            this.btnLoadLib = new System.Windows.Forms.Button();
            this.btnLibAdd = new System.Windows.Forms.Button();
            this.lbLib = new System.Windows.Forms.ListBox();
            this.dlgLibOpen = new System.Windows.Forms.OpenFileDialog();
            this.pnlSelectRegion = new System.Windows.Forms.Panel();
            this.btnApplyKernel = new System.Windows.Forms.Button();
            this.pbFace = new System.Windows.Forms.PictureBox();
            this.btnLoadTestImage = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.btnDisplayLikelihood = new System.Windows.Forms.Button();
            this.btnLoadColorModel = new System.Windows.Forms.Button();
            this.btnSaveColorModel = new System.Windows.Forms.Button();
            this.lblCov2 = new System.Windows.Forms.Label();
            this.lblCov1 = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.dlgSaveColorModel = new System.Windows.Forms.SaveFileDialog();
            this.dlgLoadColorModel = new System.Windows.Forms.OpenFileDialog();
            this.dlgLoadTestImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlThresholdingDemo = new System.Windows.Forms.Panel();
            this.btnRunThresh = new System.Windows.Forms.Button();
            this.btnSetTreshold = new System.Windows.Forms.Button();
            this.txtTreshBound = new System.Windows.Forms.TextBox();
            this.lblTreshBound = new System.Windows.Forms.Label();
            this.pnlSkinRegions = new System.Windows.Forms.Panel();
            this.btnFilterByTemplate = new System.Windows.Forms.Button();
            this.btnFilterByRatio = new System.Windows.Forms.Button();
            this.btnShowRegion = new System.Windows.Forms.Button();
            this.lblSkinRegionRatio = new System.Windows.Forms.Label();
            this.lblSkinRegionInclination = new System.Windows.Forms.Label();
            this.lblSkinRegionCentroid = new System.Windows.Forms.Label();
            this.btnFilterByHoles = new System.Windows.Forms.Button();
            this.lblSkinRegionHoles = new System.Windows.Forms.Label();
            this.lblSkinRegionHeight = new System.Windows.Forms.Label();
            this.lblSkinRegionTop = new System.Windows.Forms.Label();
            this.lblSkinRegionWidth = new System.Windows.Forms.Label();
            this.lblSkinRegionLeft = new System.Windows.Forms.Label();
            this.lblSkinRegionPixels = new System.Windows.Forms.Label();
            this.lbSkinRegions = new System.Windows.Forms.ListBox();
            this.btnFindSkinRegions = new System.Windows.Forms.Button();
            this.dlgLoadLib = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveLib = new System.Windows.Forms.SaveFileDialog();
            this.pnlFaceTemplate = new System.Windows.Forms.Panel();
            this.lblCrossCorellationValue = new System.Windows.Forms.Label();
            this.btnApplyTemplate = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.txtNewHeight = new System.Windows.Forms.TextBox();
            this.lblNewHeight = new System.Windows.Forms.Label();
            this.txtNewWidth = new System.Windows.Forms.TextBox();
            this.lblNewWidth = new System.Windows.Forms.Label();
            this.btnRotate = new System.Windows.Forms.Button();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.btnLoadFaceTemplate = new System.Windows.Forms.Button();
            this.pbFaceTemplate = new System.Windows.Forms.PictureBox();
            this.dlgLoadFaceTemplate = new System.Windows.Forms.OpenFileDialog();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnLibAddDir = new System.Windows.Forms.Button();
            this.dlgLibOpenDir = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlLib.SuspendLayout();
            this.pnlSelectRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).BeginInit();
            this.pnlResults.SuspendLayout();
            this.pnlThresholdingDemo.SuspendLayout();
            this.pnlSkinRegions.SuspendLayout();
            this.pnlFaceTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaceTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLib
            // 
            this.pnlLib.Controls.Add(this.btnLibAddDir);
            this.pnlLib.Controls.Add(this.btnSaveLib);
            this.pnlLib.Controls.Add(this.btnLoadLib);
            this.pnlLib.Controls.Add(this.btnLibAdd);
            this.pnlLib.Controls.Add(this.lbLib);
            this.pnlLib.Location = new System.Drawing.Point(12, 12);
            this.pnlLib.Name = "pnlLib";
            this.pnlLib.Size = new System.Drawing.Size(312, 362);
            this.pnlLib.TabIndex = 0;
            // 
            // btnSaveLib
            // 
            this.btnSaveLib.Location = new System.Drawing.Point(210, 328);
            this.btnSaveLib.Name = "btnSaveLib";
            this.btnSaveLib.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLib.TabIndex = 3;
            this.btnSaveLib.Text = "Save";
            this.btnSaveLib.UseVisualStyleBackColor = true;
            this.btnSaveLib.Click += new System.EventHandler(this.btnSaveLib_Click);
            // 
            // btnLoadLib
            // 
            this.btnLoadLib.Location = new System.Drawing.Point(210, 299);
            this.btnLoadLib.Name = "btnLoadLib";
            this.btnLoadLib.Size = new System.Drawing.Size(75, 23);
            this.btnLoadLib.TabIndex = 2;
            this.btnLoadLib.Text = "Load";
            this.btnLoadLib.UseVisualStyleBackColor = true;
            this.btnLoadLib.Click += new System.EventHandler(this.btnLoadLib_Click);
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
            this.lbLib.Size = new System.Drawing.Size(191, 342);
            this.lbLib.TabIndex = 0;
            this.lbLib.SelectedIndexChanged += new System.EventHandler(this.lbLib_SelectedIndexChanged);
            // 
            // dlgLibOpen
            // 
            this.dlgLibOpen.FileName = "openFileDialog1";
            this.dlgLibOpen.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94\\";
            // 
            // pnlSelectRegion
            // 
            this.pnlSelectRegion.Controls.Add(this.btnApplyKernel);
            this.pnlSelectRegion.Controls.Add(this.pbFace);
            this.pnlSelectRegion.Controls.Add(this.btnLoadTestImage);
            this.pnlSelectRegion.Location = new System.Drawing.Point(330, 12);
            this.pnlSelectRegion.Name = "pnlSelectRegion";
            this.pnlSelectRegion.Size = new System.Drawing.Size(289, 199);
            this.pnlSelectRegion.TabIndex = 2;
            // 
            // btnApplyKernel
            // 
            this.btnApplyKernel.Location = new System.Drawing.Point(176, 32);
            this.btnApplyKernel.Name = "btnApplyKernel";
            this.btnApplyKernel.Size = new System.Drawing.Size(106, 23);
            this.btnApplyKernel.TabIndex = 8;
            this.btnApplyKernel.Text = "Apply Kernel";
            this.btnApplyKernel.UseVisualStyleBackColor = true;
            this.btnApplyKernel.Click += new System.EventHandler(this.btnApplyKernel_Click);
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
            // btnLoadTestImage
            // 
            this.btnLoadTestImage.Location = new System.Drawing.Point(176, 3);
            this.btnLoadTestImage.Name = "btnLoadTestImage";
            this.btnLoadTestImage.Size = new System.Drawing.Size(106, 23);
            this.btnLoadTestImage.TabIndex = 5;
            this.btnLoadTestImage.Text = "Load Test Image";
            this.btnLoadTestImage.UseVisualStyleBackColor = true;
            this.btnLoadTestImage.Click += new System.EventHandler(this.btnLoadTestImage_Click);
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
            // lblCov2
            // 
            this.lblCov2.AutoSize = true;
            this.lblCov2.Location = new System.Drawing.Point(27, 74);
            this.lblCov2.Name = "lblCov2";
            this.lblCov2.Size = new System.Drawing.Size(35, 13);
            this.lblCov2.TabIndex = 2;
            this.lblCov2.Text = "label1";
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
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(27, 17);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(35, 13);
            this.lblMean.TabIndex = 0;
            this.lblMean.Text = "label1";
            // 
            // dlgSaveColorModel
            // 
            this.dlgSaveColorModel.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\SkinC" +
                "olorModels";
            // 
            // dlgLoadColorModel
            // 
            this.dlgLoadColorModel.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\SkinC" +
                "olorModels";
            // 
            // dlgLoadTestImage
            // 
            this.dlgLoadTestImage.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94\\";
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
            // txtTreshBound
            // 
            this.txtTreshBound.Location = new System.Drawing.Point(82, 17);
            this.txtTreshBound.Name = "txtTreshBound";
            this.txtTreshBound.Size = new System.Drawing.Size(73, 20);
            this.txtTreshBound.TabIndex = 1;
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
            // pnlSkinRegions
            // 
            this.pnlSkinRegions.Controls.Add(this.btnFilterByTemplate);
            this.pnlSkinRegions.Controls.Add(this.btnFilterByRatio);
            this.pnlSkinRegions.Controls.Add(this.btnShowRegion);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionRatio);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionInclination);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionCentroid);
            this.pnlSkinRegions.Controls.Add(this.btnFilterByHoles);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionHoles);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionHeight);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionTop);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionWidth);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionLeft);
            this.pnlSkinRegions.Controls.Add(this.lblSkinRegionPixels);
            this.pnlSkinRegions.Controls.Add(this.lbSkinRegions);
            this.pnlSkinRegions.Controls.Add(this.btnFindSkinRegions);
            this.pnlSkinRegions.Location = new System.Drawing.Point(859, 12);
            this.pnlSkinRegions.Name = "pnlSkinRegions";
            this.pnlSkinRegions.Size = new System.Drawing.Size(171, 381);
            this.pnlSkinRegions.TabIndex = 7;
            // 
            // btnFilterByTemplate
            // 
            this.btnFilterByTemplate.Location = new System.Drawing.Point(11, 344);
            this.btnFilterByTemplate.Name = "btnFilterByTemplate";
            this.btnFilterByTemplate.Size = new System.Drawing.Size(113, 23);
            this.btnFilterByTemplate.TabIndex = 14;
            this.btnFilterByTemplate.Text = "Filter by Template";
            this.btnFilterByTemplate.UseVisualStyleBackColor = true;
            this.btnFilterByTemplate.Click += new System.EventHandler(this.btnFilterByTemplate_Click);
            // 
            // btnFilterByRatio
            // 
            this.btnFilterByRatio.Location = new System.Drawing.Point(11, 315);
            this.btnFilterByRatio.Name = "btnFilterByRatio";
            this.btnFilterByRatio.Size = new System.Drawing.Size(113, 23);
            this.btnFilterByRatio.TabIndex = 13;
            this.btnFilterByRatio.Text = "Filter by Ratio";
            this.btnFilterByRatio.UseVisualStyleBackColor = true;
            this.btnFilterByRatio.Click += new System.EventHandler(this.btnFilterByRatio_Click);
            // 
            // btnShowRegion
            // 
            this.btnShowRegion.Location = new System.Drawing.Point(84, 7);
            this.btnShowRegion.Name = "btnShowRegion";
            this.btnShowRegion.Size = new System.Drawing.Size(84, 23);
            this.btnShowRegion.TabIndex = 12;
            this.btnShowRegion.Text = "Show Region";
            this.btnShowRegion.UseVisualStyleBackColor = true;
            this.btnShowRegion.Click += new System.EventHandler(this.btnShowRegion_Click);
            // 
            // lblSkinRegionRatio
            // 
            this.lblSkinRegionRatio.AutoSize = true;
            this.lblSkinRegionRatio.Location = new System.Drawing.Point(8, 256);
            this.lblSkinRegionRatio.Name = "lblSkinRegionRatio";
            this.lblSkinRegionRatio.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionRatio.TabIndex = 11;
            this.lblSkinRegionRatio.Text = "label1";
            // 
            // lblSkinRegionInclination
            // 
            this.lblSkinRegionInclination.AutoSize = true;
            this.lblSkinRegionInclination.Location = new System.Drawing.Point(8, 243);
            this.lblSkinRegionInclination.Name = "lblSkinRegionInclination";
            this.lblSkinRegionInclination.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionInclination.TabIndex = 10;
            this.lblSkinRegionInclination.Text = "label1";
            // 
            // lblSkinRegionCentroid
            // 
            this.lblSkinRegionCentroid.AutoSize = true;
            this.lblSkinRegionCentroid.Location = new System.Drawing.Point(8, 230);
            this.lblSkinRegionCentroid.Name = "lblSkinRegionCentroid";
            this.lblSkinRegionCentroid.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionCentroid.TabIndex = 9;
            this.lblSkinRegionCentroid.Text = "label1";
            // 
            // btnFilterByHoles
            // 
            this.btnFilterByHoles.Location = new System.Drawing.Point(11, 286);
            this.btnFilterByHoles.Name = "btnFilterByHoles";
            this.btnFilterByHoles.Size = new System.Drawing.Size(113, 23);
            this.btnFilterByHoles.TabIndex = 8;
            this.btnFilterByHoles.Text = "Filter by Holes";
            this.btnFilterByHoles.UseVisualStyleBackColor = true;
            this.btnFilterByHoles.Click += new System.EventHandler(this.btnFilterByHoles_Click);
            // 
            // lblSkinRegionHoles
            // 
            this.lblSkinRegionHoles.AutoSize = true;
            this.lblSkinRegionHoles.Location = new System.Drawing.Point(8, 216);
            this.lblSkinRegionHoles.Name = "lblSkinRegionHoles";
            this.lblSkinRegionHoles.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionHoles.TabIndex = 7;
            this.lblSkinRegionHoles.Text = "label1";
            // 
            // lblSkinRegionHeight
            // 
            this.lblSkinRegionHeight.AutoSize = true;
            this.lblSkinRegionHeight.Location = new System.Drawing.Point(8, 203);
            this.lblSkinRegionHeight.Name = "lblSkinRegionHeight";
            this.lblSkinRegionHeight.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionHeight.TabIndex = 6;
            this.lblSkinRegionHeight.Text = "label1";
            // 
            // lblSkinRegionTop
            // 
            this.lblSkinRegionTop.AutoSize = true;
            this.lblSkinRegionTop.Location = new System.Drawing.Point(8, 190);
            this.lblSkinRegionTop.Name = "lblSkinRegionTop";
            this.lblSkinRegionTop.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionTop.TabIndex = 5;
            this.lblSkinRegionTop.Text = "label1";
            // 
            // lblSkinRegionWidth
            // 
            this.lblSkinRegionWidth.AutoSize = true;
            this.lblSkinRegionWidth.Location = new System.Drawing.Point(8, 177);
            this.lblSkinRegionWidth.Name = "lblSkinRegionWidth";
            this.lblSkinRegionWidth.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionWidth.TabIndex = 4;
            this.lblSkinRegionWidth.Text = "label1";
            // 
            // lblSkinRegionLeft
            // 
            this.lblSkinRegionLeft.AutoSize = true;
            this.lblSkinRegionLeft.Location = new System.Drawing.Point(8, 164);
            this.lblSkinRegionLeft.Name = "lblSkinRegionLeft";
            this.lblSkinRegionLeft.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionLeft.TabIndex = 3;
            this.lblSkinRegionLeft.Text = "label1";
            // 
            // lblSkinRegionPixels
            // 
            this.lblSkinRegionPixels.AutoSize = true;
            this.lblSkinRegionPixels.Location = new System.Drawing.Point(8, 151);
            this.lblSkinRegionPixels.Name = "lblSkinRegionPixels";
            this.lblSkinRegionPixels.Size = new System.Drawing.Size(35, 13);
            this.lblSkinRegionPixels.TabIndex = 2;
            this.lblSkinRegionPixels.Text = "label1";
            // 
            // lbSkinRegions
            // 
            this.lbSkinRegions.FormattingEnabled = true;
            this.lbSkinRegions.Location = new System.Drawing.Point(3, 36);
            this.lbSkinRegions.Name = "lbSkinRegions";
            this.lbSkinRegions.Size = new System.Drawing.Size(165, 108);
            this.lbSkinRegions.TabIndex = 1;
            this.lbSkinRegions.SelectedIndexChanged += new System.EventHandler(this.lbSkinRegions_SelectedIndexChanged);
            // 
            // btnFindSkinRegions
            // 
            this.btnFindSkinRegions.Location = new System.Drawing.Point(3, 7);
            this.btnFindSkinRegions.Name = "btnFindSkinRegions";
            this.btnFindSkinRegions.Size = new System.Drawing.Size(75, 23);
            this.btnFindSkinRegions.TabIndex = 0;
            this.btnFindSkinRegions.Text = "Find";
            this.btnFindSkinRegions.UseVisualStyleBackColor = true;
            this.btnFindSkinRegions.Click += new System.EventHandler(this.btnFindSkinRegions_Click);
            // 
            // dlgLoadLib
            // 
            this.dlgLoadLib.FileName = "openFileDialog1";
            // 
            // pnlFaceTemplate
            // 
            this.pnlFaceTemplate.Controls.Add(this.lblCrossCorellationValue);
            this.pnlFaceTemplate.Controls.Add(this.btnApplyTemplate);
            this.pnlFaceTemplate.Controls.Add(this.btnResize);
            this.pnlFaceTemplate.Controls.Add(this.txtNewHeight);
            this.pnlFaceTemplate.Controls.Add(this.lblNewHeight);
            this.pnlFaceTemplate.Controls.Add(this.txtNewWidth);
            this.pnlFaceTemplate.Controls.Add(this.lblNewWidth);
            this.pnlFaceTemplate.Controls.Add(this.btnRotate);
            this.pnlFaceTemplate.Controls.Add(this.txtAngle);
            this.pnlFaceTemplate.Controls.Add(this.lblAngle);
            this.pnlFaceTemplate.Controls.Add(this.btnLoadFaceTemplate);
            this.pnlFaceTemplate.Controls.Add(this.pbFaceTemplate);
            this.pnlFaceTemplate.Location = new System.Drawing.Point(330, 215);
            this.pnlFaceTemplate.Name = "pnlFaceTemplate";
            this.pnlFaceTemplate.Size = new System.Drawing.Size(289, 178);
            this.pnlFaceTemplate.TabIndex = 8;
            // 
            // lblCrossCorellationValue
            // 
            this.lblCrossCorellationValue.AutoSize = true;
            this.lblCrossCorellationValue.Location = new System.Drawing.Point(131, 156);
            this.lblCrossCorellationValue.Name = "lblCrossCorellationValue";
            this.lblCrossCorellationValue.Size = new System.Drawing.Size(35, 13);
            this.lblCrossCorellationValue.TabIndex = 11;
            this.lblCrossCorellationValue.Text = "label1";
            // 
            // btnApplyTemplate
            // 
            this.btnApplyTemplate.Location = new System.Drawing.Point(3, 151);
            this.btnApplyTemplate.Name = "btnApplyTemplate";
            this.btnApplyTemplate.Size = new System.Drawing.Size(122, 23);
            this.btnApplyTemplate.TabIndex = 10;
            this.btnApplyTemplate.Text = "Apply Template";
            this.btnApplyTemplate.UseVisualStyleBackColor = true;
            this.btnApplyTemplate.Click += new System.EventHandler(this.btnApplyTemplate_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(176, 151);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(106, 23);
            this.btnResize.TabIndex = 9;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // txtNewHeight
            // 
            this.txtNewHeight.Location = new System.Drawing.Point(219, 125);
            this.txtNewHeight.Name = "txtNewHeight";
            this.txtNewHeight.Size = new System.Drawing.Size(63, 20);
            this.txtNewHeight.TabIndex = 8;
            // 
            // lblNewHeight
            // 
            this.lblNewHeight.AutoSize = true;
            this.lblNewHeight.Location = new System.Drawing.Point(176, 128);
            this.lblNewHeight.Name = "lblNewHeight";
            this.lblNewHeight.Size = new System.Drawing.Size(41, 13);
            this.lblNewHeight.TabIndex = 7;
            this.lblNewHeight.Text = "Height:";
            // 
            // txtNewWidth
            // 
            this.txtNewWidth.Location = new System.Drawing.Point(219, 101);
            this.txtNewWidth.Name = "txtNewWidth";
            this.txtNewWidth.Size = new System.Drawing.Size(63, 20);
            this.txtNewWidth.TabIndex = 6;
            // 
            // lblNewWidth
            // 
            this.lblNewWidth.AutoSize = true;
            this.lblNewWidth.Location = new System.Drawing.Point(176, 104);
            this.lblNewWidth.Name = "lblNewWidth";
            this.lblNewWidth.Size = new System.Drawing.Size(38, 13);
            this.lblNewWidth.TabIndex = 5;
            this.lblNewWidth.Text = "Width:";
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(176, 72);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(106, 23);
            this.btnRotate.TabIndex = 4;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(219, 46);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(63, 20);
            this.txtAngle.TabIndex = 3;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(176, 49);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(37, 13);
            this.lblAngle.TabIndex = 2;
            this.lblAngle.Text = "Angle:";
            // 
            // btnLoadFaceTemplate
            // 
            this.btnLoadFaceTemplate.Location = new System.Drawing.Point(176, 3);
            this.btnLoadFaceTemplate.Name = "btnLoadFaceTemplate";
            this.btnLoadFaceTemplate.Size = new System.Drawing.Size(106, 37);
            this.btnLoadFaceTemplate.TabIndex = 1;
            this.btnLoadFaceTemplate.Text = "Load Face Template";
            this.btnLoadFaceTemplate.UseVisualStyleBackColor = true;
            this.btnLoadFaceTemplate.Click += new System.EventHandler(this.btnLoadFaceTemplate_Click);
            // 
            // pbFaceTemplate
            // 
            this.pbFaceTemplate.Location = new System.Drawing.Point(3, 3);
            this.pbFaceTemplate.Name = "pbFaceTemplate";
            this.pbFaceTemplate.Size = new System.Drawing.Size(167, 145);
            this.pbFaceTemplate.TabIndex = 0;
            this.pbFaceTemplate.TabStop = false;
            // 
            // dlgLoadFaceTemplate
            // 
            this.dlgLoadFaceTemplate.FileName = "openFileDialog1";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(141, 381);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnLibAddDir
            // 
            this.btnLibAddDir.Location = new System.Drawing.Point(210, 45);
            this.btnLibAddDir.Name = "btnLibAddDir";
            this.btnLibAddDir.Size = new System.Drawing.Size(75, 23);
            this.btnLibAddDir.TabIndex = 4;
            this.btnLibAddDir.Text = "Add Dir";
            this.btnLibAddDir.UseVisualStyleBackColor = true;
            this.btnLibAddDir.Click += new System.EventHandler(this.btnLibAddDir_Click);
            // 
            // FaceColorLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 416);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pnlFaceTemplate);
            this.Controls.Add(this.pnlSkinRegions);
            this.Controls.Add(this.pnlThresholdingDemo);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlSelectRegion);
            this.Controls.Add(this.pnlLib);
            this.Name = "FaceColorLib";
            this.Text = "Face Color Library";
            this.pnlLib.ResumeLayout(false);
            this.pnlSelectRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).EndInit();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.pnlThresholdingDemo.ResumeLayout(false);
            this.pnlThresholdingDemo.PerformLayout();
            this.pnlSkinRegions.ResumeLayout(false);
            this.pnlSkinRegions.PerformLayout();
            this.pnlFaceTemplate.ResumeLayout(false);
            this.pnlFaceTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaceTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLib;
        private System.Windows.Forms.Button btnLibAdd;
        private System.Windows.Forms.ListBox lbLib;
        private System.Windows.Forms.OpenFileDialog dlgLibOpen;
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
        private System.Windows.Forms.Panel pnlSkinRegions;
        private System.Windows.Forms.ListBox lbSkinRegions;
        private System.Windows.Forms.Button btnFindSkinRegions;
        private System.Windows.Forms.Label lblSkinRegionPixels;
        private System.Windows.Forms.Label lblSkinRegionHeight;
        private System.Windows.Forms.Label lblSkinRegionTop;
        private System.Windows.Forms.Label lblSkinRegionWidth;
        private System.Windows.Forms.Label lblSkinRegionLeft;
        private System.Windows.Forms.Label lblSkinRegionHoles;
        private System.Windows.Forms.Button btnFilterByHoles;
        private System.Windows.Forms.Button btnApplyKernel;
        private System.Windows.Forms.Label lblSkinRegionInclination;
        private System.Windows.Forms.Label lblSkinRegionCentroid;
        private System.Windows.Forms.Label lblSkinRegionRatio;
        private System.Windows.Forms.Button btnSaveLib;
        private System.Windows.Forms.Button btnLoadLib;
        private System.Windows.Forms.OpenFileDialog dlgLoadLib;
        private System.Windows.Forms.SaveFileDialog dlgSaveLib;
        private System.Windows.Forms.Panel pnlFaceTemplate;
        private System.Windows.Forms.Button btnLoadFaceTemplate;
        private System.Windows.Forms.PictureBox pbFaceTemplate;
        private System.Windows.Forms.OpenFileDialog dlgLoadFaceTemplate;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TextBox txtNewWidth;
        private System.Windows.Forms.Label lblNewWidth;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.TextBox txtNewHeight;
        private System.Windows.Forms.Label lblNewHeight;
        private System.Windows.Forms.Button btnShowRegion;
        private System.Windows.Forms.Button btnApplyTemplate;
        private System.Windows.Forms.Label lblCrossCorellationValue;
        private System.Windows.Forms.Button btnFilterByTemplate;
        private System.Windows.Forms.Button btnFilterByRatio;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnLibAddDir;
        private System.Windows.Forms.FolderBrowserDialog dlgLibOpenDir;

    }
}

