namespace SkinDetection
{
    partial class TestForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlChooseAlg = new System.Windows.Forms.Panel();
            this.cbAlg = new System.Windows.Forms.ComboBox();
            this.lblAlg = new System.Windows.Forms.Label();
            this.pnlSkinOptions = new System.Windows.Forms.Panel();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.txtSkinRegionMaxRatio = new System.Windows.Forms.TextBox();
            this.txtSkinRegionCrsCrltn = new System.Windows.Forms.TextBox();
            this.lblSkinRegionCrsCrltn = new System.Windows.Forms.Label();
            this.txtSkinRegionMinRatio = new System.Windows.Forms.TextBox();
            this.lblSkinRegionRation = new System.Windows.Forms.Label();
            this.txtSkinRegionMinHoles = new System.Windows.Forms.TextBox();
            this.lblSkinRegionMinHoles = new System.Windows.Forms.Label();
            this.txtAdaptiveThresholdStep = new System.Windows.Forms.TextBox();
            this.lblAdaptiveThresholdStep = new System.Windows.Forms.Label();
            this.txtAdaptiveThresholdLower = new System.Windows.Forms.TextBox();
            this.lblAdaptiveThresholdLower = new System.Windows.Forms.Label();
            this.txtAdaptiveThresholdUpper = new System.Windows.Forms.TextBox();
            this.lblAdaptiveThresholdUpper = new System.Windows.Forms.Label();
            this.btnLoadFaceTemplate = new System.Windows.Forms.Button();
            this.pnlGeoOptions = new System.Windows.Forms.Panel();
            this.txtCannyLinkThreshold = new System.Windows.Forms.TextBox();
            this.txtCannyThreshold = new System.Windows.Forms.TextBox();
            this.lblCannyThresholds = new System.Windows.Forms.Label();
            this.txtEraseChainsA = new System.Windows.Forms.TextBox();
            this.lblEraseChainsA = new System.Windows.Forms.Label();
            this.txtMedianSmoothSize = new System.Windows.Forms.TextBox();
            this.lblMedianSmoothSize = new System.Windows.Forms.Label();
            this.txtTemplateThresholdRate = new System.Windows.Forms.TextBox();
            this.txtTemplateThresholdPoints = new System.Windows.Forms.TextBox();
            this.lblTemplateThresholds = new System.Windows.Forms.Label();
            this.txtTestTemplateBStep = new System.Windows.Forms.TextBox();
            this.txtTestTemplateBEnd = new System.Windows.Forms.TextBox();
            this.txtTestTemplateBStart = new System.Windows.Forms.TextBox();
            this.txtTestTemplateAStep = new System.Windows.Forms.TextBox();
            this.txtTestTemplateAEnd = new System.Windows.Forms.TextBox();
            this.txtTestTemplateAStart = new System.Windows.Forms.TextBox();
            this.txtTestTemplateY0Step = new System.Windows.Forms.TextBox();
            this.txtTestTemplateY0End = new System.Windows.Forms.TextBox();
            this.txtTestTemplateY0Start = new System.Windows.Forms.TextBox();
            this.txtTestTemplateX0Step = new System.Windows.Forms.TextBox();
            this.txtTestTemplateX0End = new System.Windows.Forms.TextBox();
            this.txtTestTemplateX0Start = new System.Windows.Forms.TextBox();
            this.lblTestTemplateB = new System.Windows.Forms.Label();
            this.lblTestTemplateA = new System.Windows.Forms.Label();
            this.lblTestTemplateY0 = new System.Windows.Forms.Label();
            this.lblTestTemplateX0 = new System.Windows.Forms.Label();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnInExact = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.pbImgTest = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dlgSelectDir = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgLoadFaceTemplate = new System.Windows.Forms.OpenFileDialog();
            this.dlgLoadModel = new System.Windows.Forms.OpenFileDialog();
            this.lblAdaptiveTitle = new System.Windows.Forms.Label();
            this.pnlChooseAlg.SuspendLayout();
            this.pnlSkinOptions.SuspendLayout();
            this.pnlGeoOptions.SuspendLayout();
            this.pnlImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgTest)).BeginInit();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChooseAlg
            // 
            this.pnlChooseAlg.Controls.Add(this.cbAlg);
            this.pnlChooseAlg.Controls.Add(this.lblAlg);
            this.pnlChooseAlg.Location = new System.Drawing.Point(12, 12);
            this.pnlChooseAlg.Name = "pnlChooseAlg";
            this.pnlChooseAlg.Size = new System.Drawing.Size(200, 40);
            this.pnlChooseAlg.TabIndex = 0;
            // 
            // cbAlg
            // 
            this.cbAlg.FormattingEnabled = true;
            this.cbAlg.Items.AddRange(new object[] {
            "Кольор шкіри",
            "Контури зображення"});
            this.cbAlg.Location = new System.Drawing.Point(67, 7);
            this.cbAlg.Name = "cbAlg";
            this.cbAlg.Size = new System.Drawing.Size(121, 21);
            this.cbAlg.TabIndex = 1;
            this.cbAlg.SelectedIndexChanged += new System.EventHandler(this.cbAlg_SelectedIndexChanged);
            // 
            // lblAlg
            // 
            this.lblAlg.AutoSize = true;
            this.lblAlg.Location = new System.Drawing.Point(3, 10);
            this.lblAlg.Name = "lblAlg";
            this.lblAlg.Size = new System.Drawing.Size(59, 13);
            this.lblAlg.TabIndex = 0;
            this.lblAlg.Text = "Алгоритм:";
            // 
            // pnlSkinOptions
            // 
            this.pnlSkinOptions.Controls.Add(this.lblAdaptiveTitle);
            this.pnlSkinOptions.Controls.Add(this.btnLoadModel);
            this.pnlSkinOptions.Controls.Add(this.txtSkinRegionMaxRatio);
            this.pnlSkinOptions.Controls.Add(this.txtSkinRegionCrsCrltn);
            this.pnlSkinOptions.Controls.Add(this.lblSkinRegionCrsCrltn);
            this.pnlSkinOptions.Controls.Add(this.txtSkinRegionMinRatio);
            this.pnlSkinOptions.Controls.Add(this.lblSkinRegionRation);
            this.pnlSkinOptions.Controls.Add(this.txtSkinRegionMinHoles);
            this.pnlSkinOptions.Controls.Add(this.lblSkinRegionMinHoles);
            this.pnlSkinOptions.Controls.Add(this.txtAdaptiveThresholdStep);
            this.pnlSkinOptions.Controls.Add(this.lblAdaptiveThresholdStep);
            this.pnlSkinOptions.Controls.Add(this.txtAdaptiveThresholdLower);
            this.pnlSkinOptions.Controls.Add(this.lblAdaptiveThresholdLower);
            this.pnlSkinOptions.Controls.Add(this.txtAdaptiveThresholdUpper);
            this.pnlSkinOptions.Controls.Add(this.lblAdaptiveThresholdUpper);
            this.pnlSkinOptions.Controls.Add(this.btnLoadFaceTemplate);
            this.pnlSkinOptions.Location = new System.Drawing.Point(12, 58);
            this.pnlSkinOptions.Name = "pnlSkinOptions";
            this.pnlSkinOptions.Size = new System.Drawing.Size(200, 202);
            this.pnlSkinOptions.TabIndex = 1;
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Location = new System.Drawing.Point(6, 3);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(75, 23);
            this.btnLoadModel.TabIndex = 14;
            this.btnLoadModel.Text = "Модель";
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // txtSkinRegionMaxRatio
            // 
            this.txtSkinRegionMaxRatio.Location = new System.Drawing.Point(156, 132);
            this.txtSkinRegionMaxRatio.Name = "txtSkinRegionMaxRatio";
            this.txtSkinRegionMaxRatio.Size = new System.Drawing.Size(32, 20);
            this.txtSkinRegionMaxRatio.TabIndex = 13;
            // 
            // txtSkinRegionCrsCrltn
            // 
            this.txtSkinRegionCrsCrltn.Location = new System.Drawing.Point(137, 158);
            this.txtSkinRegionCrsCrltn.Name = "txtSkinRegionCrsCrltn";
            this.txtSkinRegionCrsCrltn.Size = new System.Drawing.Size(51, 20);
            this.txtSkinRegionCrsCrltn.TabIndex = 12;
            // 
            // lblSkinRegionCrsCrltn
            // 
            this.lblSkinRegionCrsCrltn.AutoSize = true;
            this.lblSkinRegionCrsCrltn.Location = new System.Drawing.Point(3, 161);
            this.lblSkinRegionCrsCrltn.Name = "lblSkinRegionCrsCrltn";
            this.lblSkinRegionCrsCrltn.Size = new System.Drawing.Size(128, 13);
            this.lblSkinRegionCrsCrltn.TabIndex = 11;
            this.lblSkinRegionCrsCrltn.Text = "Мін показник кореляції:";
            // 
            // txtSkinRegionMinRatio
            // 
            this.txtSkinRegionMinRatio.Location = new System.Drawing.Point(118, 132);
            this.txtSkinRegionMinRatio.Name = "txtSkinRegionMinRatio";
            this.txtSkinRegionMinRatio.Size = new System.Drawing.Size(32, 20);
            this.txtSkinRegionMinRatio.TabIndex = 10;
            // 
            // lblSkinRegionRation
            // 
            this.lblSkinRegionRation.AutoSize = true;
            this.lblSkinRegionRation.Location = new System.Drawing.Point(3, 135);
            this.lblSkinRegionRation.Name = "lblSkinRegionRation";
            this.lblSkinRegionRation.Size = new System.Drawing.Size(85, 13);
            this.lblSkinRegionRation.TabIndex = 9;
            this.lblSkinRegionRation.Text = "Межі пропорції:";
            // 
            // txtSkinRegionMinHoles
            // 
            this.txtSkinRegionMinHoles.Location = new System.Drawing.Point(148, 106);
            this.txtSkinRegionMinHoles.Name = "txtSkinRegionMinHoles";
            this.txtSkinRegionMinHoles.Size = new System.Drawing.Size(40, 20);
            this.txtSkinRegionMinHoles.TabIndex = 8;
            // 
            // lblSkinRegionMinHoles
            // 
            this.lblSkinRegionMinHoles.AutoSize = true;
            this.lblSkinRegionMinHoles.Location = new System.Drawing.Point(3, 109);
            this.lblSkinRegionMinHoles.Name = "lblSkinRegionMinHoles";
            this.lblSkinRegionMinHoles.Size = new System.Drawing.Size(144, 13);
            this.lblSkinRegionMinHoles.TabIndex = 7;
            this.lblSkinRegionMinHoles.Text = "Мінімальна кількість дірок:";
            // 
            // txtAdaptiveThresholdStep
            // 
            this.txtAdaptiveThresholdStep.Location = new System.Drawing.Point(143, 76);
            this.txtAdaptiveThresholdStep.Name = "txtAdaptiveThresholdStep";
            this.txtAdaptiveThresholdStep.Size = new System.Drawing.Size(45, 20);
            this.txtAdaptiveThresholdStep.TabIndex = 6;
            // 
            // lblAdaptiveThresholdStep
            // 
            this.lblAdaptiveThresholdStep.AutoSize = true;
            this.lblAdaptiveThresholdStep.Location = new System.Drawing.Point(145, 56);
            this.lblAdaptiveThresholdStep.Name = "lblAdaptiveThresholdStep";
            this.lblAdaptiveThresholdStep.Size = new System.Drawing.Size(35, 13);
            this.lblAdaptiveThresholdStep.TabIndex = 5;
            this.lblAdaptiveThresholdStep.Text = "Крок:";
            // 
            // txtAdaptiveThresholdLower
            // 
            this.txtAdaptiveThresholdLower.Location = new System.Drawing.Point(87, 76);
            this.txtAdaptiveThresholdLower.Name = "txtAdaptiveThresholdLower";
            this.txtAdaptiveThresholdLower.Size = new System.Drawing.Size(50, 20);
            this.txtAdaptiveThresholdLower.TabIndex = 4;
            // 
            // lblAdaptiveThresholdLower
            // 
            this.lblAdaptiveThresholdLower.AutoSize = true;
            this.lblAdaptiveThresholdLower.Location = new System.Drawing.Point(3, 79);
            this.lblAdaptiveThresholdLower.Name = "lblAdaptiveThresholdLower";
            this.lblAdaptiveThresholdLower.Size = new System.Drawing.Size(74, 13);
            this.lblAdaptiveThresholdLower.TabIndex = 3;
            this.lblAdaptiveThresholdLower.Text = "Нижній поріг:";
            // 
            // txtAdaptiveThresholdUpper
            // 
            this.txtAdaptiveThresholdUpper.Location = new System.Drawing.Point(87, 53);
            this.txtAdaptiveThresholdUpper.Name = "txtAdaptiveThresholdUpper";
            this.txtAdaptiveThresholdUpper.Size = new System.Drawing.Size(50, 20);
            this.txtAdaptiveThresholdUpper.TabIndex = 2;
            // 
            // lblAdaptiveThresholdUpper
            // 
            this.lblAdaptiveThresholdUpper.AutoSize = true;
            this.lblAdaptiveThresholdUpper.Location = new System.Drawing.Point(5, 56);
            this.lblAdaptiveThresholdUpper.Name = "lblAdaptiveThresholdUpper";
            this.lblAdaptiveThresholdUpper.Size = new System.Drawing.Size(76, 13);
            this.lblAdaptiveThresholdUpper.TabIndex = 1;
            this.lblAdaptiveThresholdUpper.Text = "Верхній поріг:";
            // 
            // btnLoadFaceTemplate
            // 
            this.btnLoadFaceTemplate.Location = new System.Drawing.Point(87, 3);
            this.btnLoadFaceTemplate.Name = "btnLoadFaceTemplate";
            this.btnLoadFaceTemplate.Size = new System.Drawing.Size(101, 23);
            this.btnLoadFaceTemplate.TabIndex = 0;
            this.btnLoadFaceTemplate.Text = "Зразок";
            this.btnLoadFaceTemplate.UseVisualStyleBackColor = true;
            this.btnLoadFaceTemplate.Click += new System.EventHandler(this.btnLoadFaceTemplate_Click);
            // 
            // pnlGeoOptions
            // 
            this.pnlGeoOptions.Controls.Add(this.txtCannyLinkThreshold);
            this.pnlGeoOptions.Controls.Add(this.txtCannyThreshold);
            this.pnlGeoOptions.Controls.Add(this.lblCannyThresholds);
            this.pnlGeoOptions.Controls.Add(this.txtEraseChainsA);
            this.pnlGeoOptions.Controls.Add(this.lblEraseChainsA);
            this.pnlGeoOptions.Controls.Add(this.txtMedianSmoothSize);
            this.pnlGeoOptions.Controls.Add(this.lblMedianSmoothSize);
            this.pnlGeoOptions.Controls.Add(this.txtTemplateThresholdRate);
            this.pnlGeoOptions.Controls.Add(this.txtTemplateThresholdPoints);
            this.pnlGeoOptions.Controls.Add(this.lblTemplateThresholds);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateBStep);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateBEnd);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateBStart);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateAStep);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateAEnd);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateAStart);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateY0Step);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateY0End);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateY0Start);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateX0Step);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateX0End);
            this.pnlGeoOptions.Controls.Add(this.txtTestTemplateX0Start);
            this.pnlGeoOptions.Controls.Add(this.lblTestTemplateB);
            this.pnlGeoOptions.Controls.Add(this.lblTestTemplateA);
            this.pnlGeoOptions.Controls.Add(this.lblTestTemplateY0);
            this.pnlGeoOptions.Controls.Add(this.lblTestTemplateX0);
            this.pnlGeoOptions.Location = new System.Drawing.Point(12, 266);
            this.pnlGeoOptions.Name = "pnlGeoOptions";
            this.pnlGeoOptions.Size = new System.Drawing.Size(200, 218);
            this.pnlGeoOptions.TabIndex = 2;
            // 
            // txtCannyLinkThreshold
            // 
            this.txtCannyLinkThreshold.Location = new System.Drawing.Point(156, 35);
            this.txtCannyLinkThreshold.Name = "txtCannyLinkThreshold";
            this.txtCannyLinkThreshold.Size = new System.Drawing.Size(32, 20);
            this.txtCannyLinkThreshold.TabIndex = 62;
            // 
            // txtCannyThreshold
            // 
            this.txtCannyThreshold.Location = new System.Drawing.Point(118, 35);
            this.txtCannyThreshold.Name = "txtCannyThreshold";
            this.txtCannyThreshold.Size = new System.Drawing.Size(32, 20);
            this.txtCannyThreshold.TabIndex = 61;
            // 
            // lblCannyThresholds
            // 
            this.lblCannyThresholds.AutoSize = true;
            this.lblCannyThresholds.Location = new System.Drawing.Point(3, 38);
            this.lblCannyThresholds.Name = "lblCannyThresholds";
            this.lblCannyThresholds.Size = new System.Drawing.Size(77, 13);
            this.lblCannyThresholds.TabIndex = 60;
            this.lblCannyThresholds.Text = "Пороги Кенні:";
            // 
            // txtEraseChainsA
            // 
            this.txtEraseChainsA.Location = new System.Drawing.Point(129, 64);
            this.txtEraseChainsA.Name = "txtEraseChainsA";
            this.txtEraseChainsA.Size = new System.Drawing.Size(59, 20);
            this.txtEraseChainsA.TabIndex = 59;
            // 
            // lblEraseChainsA
            // 
            this.lblEraseChainsA.AutoSize = true;
            this.lblEraseChainsA.Location = new System.Drawing.Point(3, 67);
            this.lblEraseChainsA.Name = "lblEraseChainsA";
            this.lblEraseChainsA.Size = new System.Drawing.Size(120, 13);
            this.lblEraseChainsA.TabIndex = 58;
            this.lblEraseChainsA.Text = "Мін довжина ланцюга:";
            // 
            // txtMedianSmoothSize
            // 
            this.txtMedianSmoothSize.Location = new System.Drawing.Point(142, 9);
            this.txtMedianSmoothSize.Name = "txtMedianSmoothSize";
            this.txtMedianSmoothSize.Size = new System.Drawing.Size(46, 20);
            this.txtMedianSmoothSize.TabIndex = 57;
            // 
            // lblMedianSmoothSize
            // 
            this.lblMedianSmoothSize.AutoSize = true;
            this.lblMedianSmoothSize.Location = new System.Drawing.Point(3, 12);
            this.lblMedianSmoothSize.Name = "lblMedianSmoothSize";
            this.lblMedianSmoothSize.Size = new System.Drawing.Size(138, 13);
            this.lblMedianSmoothSize.TabIndex = 56;
            this.lblMedianSmoothSize.Text = "Вікно медіанного фільтру:";
            // 
            // txtTemplateThresholdRate
            // 
            this.txtTemplateThresholdRate.Location = new System.Drawing.Point(156, 90);
            this.txtTemplateThresholdRate.Name = "txtTemplateThresholdRate";
            this.txtTemplateThresholdRate.Size = new System.Drawing.Size(32, 20);
            this.txtTemplateThresholdRate.TabIndex = 55;
            // 
            // txtTemplateThresholdPoints
            // 
            this.txtTemplateThresholdPoints.Location = new System.Drawing.Point(118, 90);
            this.txtTemplateThresholdPoints.Name = "txtTemplateThresholdPoints";
            this.txtTemplateThresholdPoints.Size = new System.Drawing.Size(32, 20);
            this.txtTemplateThresholdPoints.TabIndex = 54;
            // 
            // lblTemplateThresholds
            // 
            this.lblTemplateThresholds.AutoSize = true;
            this.lblTemplateThresholds.Location = new System.Drawing.Point(3, 93);
            this.lblTemplateThresholds.Name = "lblTemplateThresholds";
            this.lblTemplateThresholds.Size = new System.Drawing.Size(103, 13);
            this.lblTemplateThresholds.TabIndex = 53;
            this.lblTemplateThresholds.Text = "Пороги алгоритму:";
            // 
            // txtTestTemplateBStep
            // 
            this.txtTestTemplateBStep.Location = new System.Drawing.Point(142, 193);
            this.txtTestTemplateBStep.Name = "txtTestTemplateBStep";
            this.txtTestTemplateBStep.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateBStep.TabIndex = 52;
            this.txtTestTemplateBStep.Text = "5";
            // 
            // txtTestTemplateBEnd
            // 
            this.txtTestTemplateBEnd.Location = new System.Drawing.Point(94, 193);
            this.txtTestTemplateBEnd.Name = "txtTestTemplateBEnd";
            this.txtTestTemplateBEnd.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateBEnd.TabIndex = 51;
            this.txtTestTemplateBEnd.Text = "80";
            // 
            // txtTestTemplateBStart
            // 
            this.txtTestTemplateBStart.Location = new System.Drawing.Point(46, 193);
            this.txtTestTemplateBStart.Name = "txtTestTemplateBStart";
            this.txtTestTemplateBStart.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateBStart.TabIndex = 50;
            this.txtTestTemplateBStart.Text = "30";
            // 
            // txtTestTemplateAStep
            // 
            this.txtTestTemplateAStep.Location = new System.Drawing.Point(142, 167);
            this.txtTestTemplateAStep.Name = "txtTestTemplateAStep";
            this.txtTestTemplateAStep.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateAStep.TabIndex = 49;
            this.txtTestTemplateAStep.Text = "5";
            // 
            // txtTestTemplateAEnd
            // 
            this.txtTestTemplateAEnd.Location = new System.Drawing.Point(94, 167);
            this.txtTestTemplateAEnd.Name = "txtTestTemplateAEnd";
            this.txtTestTemplateAEnd.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateAEnd.TabIndex = 48;
            this.txtTestTemplateAEnd.Text = "80";
            // 
            // txtTestTemplateAStart
            // 
            this.txtTestTemplateAStart.Location = new System.Drawing.Point(46, 167);
            this.txtTestTemplateAStart.Name = "txtTestTemplateAStart";
            this.txtTestTemplateAStart.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateAStart.TabIndex = 47;
            this.txtTestTemplateAStart.Text = "50";
            // 
            // txtTestTemplateY0Step
            // 
            this.txtTestTemplateY0Step.Location = new System.Drawing.Point(142, 141);
            this.txtTestTemplateY0Step.Name = "txtTestTemplateY0Step";
            this.txtTestTemplateY0Step.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateY0Step.TabIndex = 46;
            this.txtTestTemplateY0Step.Text = "10";
            // 
            // txtTestTemplateY0End
            // 
            this.txtTestTemplateY0End.Location = new System.Drawing.Point(94, 141);
            this.txtTestTemplateY0End.Name = "txtTestTemplateY0End";
            this.txtTestTemplateY0End.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateY0End.TabIndex = 45;
            this.txtTestTemplateY0End.Text = "160";
            // 
            // txtTestTemplateY0Start
            // 
            this.txtTestTemplateY0Start.Location = new System.Drawing.Point(46, 141);
            this.txtTestTemplateY0Start.Name = "txtTestTemplateY0Start";
            this.txtTestTemplateY0Start.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateY0Start.TabIndex = 44;
            this.txtTestTemplateY0Start.Text = "40";
            // 
            // txtTestTemplateX0Step
            // 
            this.txtTestTemplateX0Step.Location = new System.Drawing.Point(142, 118);
            this.txtTestTemplateX0Step.Name = "txtTestTemplateX0Step";
            this.txtTestTemplateX0Step.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateX0Step.TabIndex = 43;
            this.txtTestTemplateX0Step.Text = "10";
            // 
            // txtTestTemplateX0End
            // 
            this.txtTestTemplateX0End.Location = new System.Drawing.Point(94, 118);
            this.txtTestTemplateX0End.Name = "txtTestTemplateX0End";
            this.txtTestTemplateX0End.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateX0End.TabIndex = 42;
            this.txtTestTemplateX0End.Text = "140";
            // 
            // txtTestTemplateX0Start
            // 
            this.txtTestTemplateX0Start.Location = new System.Drawing.Point(46, 118);
            this.txtTestTemplateX0Start.Name = "txtTestTemplateX0Start";
            this.txtTestTemplateX0Start.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateX0Start.TabIndex = 41;
            this.txtTestTemplateX0Start.Text = "40";
            // 
            // lblTestTemplateB
            // 
            this.lblTestTemplateB.AutoSize = true;
            this.lblTestTemplateB.Location = new System.Drawing.Point(17, 196);
            this.lblTestTemplateB.Name = "lblTestTemplateB";
            this.lblTestTemplateB.Size = new System.Drawing.Size(16, 13);
            this.lblTestTemplateB.TabIndex = 40;
            this.lblTestTemplateB.Text = "b:";
            // 
            // lblTestTemplateA
            // 
            this.lblTestTemplateA.AutoSize = true;
            this.lblTestTemplateA.Location = new System.Drawing.Point(17, 170);
            this.lblTestTemplateA.Name = "lblTestTemplateA";
            this.lblTestTemplateA.Size = new System.Drawing.Size(16, 13);
            this.lblTestTemplateA.TabIndex = 39;
            this.lblTestTemplateA.Text = "a:";
            // 
            // lblTestTemplateY0
            // 
            this.lblTestTemplateY0.AutoSize = true;
            this.lblTestTemplateY0.Location = new System.Drawing.Point(17, 144);
            this.lblTestTemplateY0.Name = "lblTestTemplateY0";
            this.lblTestTemplateY0.Size = new System.Drawing.Size(23, 13);
            this.lblTestTemplateY0.TabIndex = 38;
            this.lblTestTemplateY0.Text = "Y0:";
            // 
            // lblTestTemplateX0
            // 
            this.lblTestTemplateX0.AutoSize = true;
            this.lblTestTemplateX0.Location = new System.Drawing.Point(17, 121);
            this.lblTestTemplateX0.Name = "lblTestTemplateX0";
            this.lblTestTemplateX0.Size = new System.Drawing.Size(23, 13);
            this.lblTestTemplateX0.TabIndex = 37;
            this.lblTestTemplateX0.Text = "X0:";
            // 
            // pnlImg
            // 
            this.pnlImg.Controls.Add(this.lblStats);
            this.pnlImg.Controls.Add(this.btnStop);
            this.pnlImg.Controls.Add(this.btnFalse);
            this.pnlImg.Controls.Add(this.btnInExact);
            this.pnlImg.Controls.Add(this.btnTrue);
            this.pnlImg.Controls.Add(this.pbImgTest);
            this.pnlImg.Controls.Add(this.btnLoad);
            this.pnlImg.Location = new System.Drawing.Point(218, 12);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(328, 248);
            this.pnlImg.TabIndex = 3;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(126, 10);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 13);
            this.lblStats.TabIndex = 6;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(247, 222);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Закінчити";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(247, 92);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(75, 23);
            this.btnFalse.TabIndex = 4;
            this.btnFalse.Text = "Не вірно";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnInExact
            // 
            this.btnInExact.Location = new System.Drawing.Point(247, 63);
            this.btnInExact.Name = "btnInExact";
            this.btnInExact.Size = new System.Drawing.Size(75, 23);
            this.btnInExact.TabIndex = 3;
            this.btnInExact.Text = "Not Exact";
            this.btnInExact.UseVisualStyleBackColor = true;
            this.btnInExact.Visible = false;
            this.btnInExact.Click += new System.EventHandler(this.btnInExact_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(247, 34);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(75, 23);
            this.btnTrue.TabIndex = 2;
            this.btnTrue.Text = "Вірно";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // pbImgTest
            // 
            this.pbImgTest.Location = new System.Drawing.Point(3, 34);
            this.pbImgTest.Name = "pbImgTest";
            this.pbImgTest.Size = new System.Drawing.Size(238, 211);
            this.pbImgTest.TabIndex = 1;
            this.pbImgTest.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Обрати директорію";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dlgSelectDir
            // 
            this.dlgSelectDir.SelectedPath = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94\\male";
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.chartResults);
            this.pnlResults.Location = new System.Drawing.Point(218, 266);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(328, 218);
            this.pnlResults.TabIndex = 4;
            // 
            // chartResults
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResults.Legends.Add(legend1);
            this.chartResults.Location = new System.Drawing.Point(3, 3);
            this.chartResults.Name = "chartResults";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SeriesTrue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SeriesNotExact";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "SeriesFalse";
            this.chartResults.Series.Add(series1);
            this.chartResults.Series.Add(series2);
            this.chartResults.Series.Add(series3);
            this.chartResults.Size = new System.Drawing.Size(319, 212);
            this.chartResults.TabIndex = 0;
            // 
            // lblAdaptiveTitle
            // 
            this.lblAdaptiveTitle.AutoSize = true;
            this.lblAdaptiveTitle.Location = new System.Drawing.Point(5, 37);
            this.lblAdaptiveTitle.Name = "lblAdaptiveTitle";
            this.lblAdaptiveTitle.Size = new System.Drawing.Size(147, 13);
            this.lblAdaptiveTitle.TabIndex = 15;
            this.lblAdaptiveTitle.Text = "Параметри підбору порогів:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 496);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlImg);
            this.Controls.Add(this.pnlGeoOptions);
            this.Controls.Add(this.pnlSkinOptions);
            this.Controls.Add(this.pnlChooseAlg);
            this.Name = "TestForm";
            this.Text = "Тестування";
            this.pnlChooseAlg.ResumeLayout(false);
            this.pnlChooseAlg.PerformLayout();
            this.pnlSkinOptions.ResumeLayout(false);
            this.pnlSkinOptions.PerformLayout();
            this.pnlGeoOptions.ResumeLayout(false);
            this.pnlGeoOptions.PerformLayout();
            this.pnlImg.ResumeLayout(false);
            this.pnlImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgTest)).EndInit();
            this.pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChooseAlg;
        private System.Windows.Forms.ComboBox cbAlg;
        private System.Windows.Forms.Label lblAlg;
        private System.Windows.Forms.Panel pnlSkinOptions;
        private System.Windows.Forms.Panel pnlGeoOptions;
        private System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnInExact;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.PictureBox pbImgTest;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectDir;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
        private System.Windows.Forms.Button btnLoadFaceTemplate;
        private System.Windows.Forms.OpenFileDialog dlgLoadFaceTemplate;
        private System.Windows.Forms.Label lblAdaptiveThresholdUpper;
        private System.Windows.Forms.TextBox txtAdaptiveThresholdStep;
        private System.Windows.Forms.Label lblAdaptiveThresholdStep;
        private System.Windows.Forms.TextBox txtAdaptiveThresholdLower;
        private System.Windows.Forms.Label lblAdaptiveThresholdLower;
        private System.Windows.Forms.TextBox txtAdaptiveThresholdUpper;
        private System.Windows.Forms.TextBox txtSkinRegionMinHoles;
        private System.Windows.Forms.Label lblSkinRegionMinHoles;
        private System.Windows.Forms.TextBox txtSkinRegionCrsCrltn;
        private System.Windows.Forms.Label lblSkinRegionCrsCrltn;
        private System.Windows.Forms.TextBox txtSkinRegionMinRatio;
        private System.Windows.Forms.Label lblSkinRegionRation;
        private System.Windows.Forms.TextBox txtSkinRegionMaxRatio;
        private System.Windows.Forms.Button btnLoadModel;
        private System.Windows.Forms.OpenFileDialog dlgLoadModel;
        private System.Windows.Forms.TextBox txtTestTemplateBStep;
        private System.Windows.Forms.TextBox txtTestTemplateBEnd;
        private System.Windows.Forms.TextBox txtTestTemplateBStart;
        private System.Windows.Forms.TextBox txtTestTemplateAStep;
        private System.Windows.Forms.TextBox txtTestTemplateAEnd;
        private System.Windows.Forms.TextBox txtTestTemplateAStart;
        private System.Windows.Forms.TextBox txtTestTemplateY0Step;
        private System.Windows.Forms.TextBox txtTestTemplateY0End;
        private System.Windows.Forms.TextBox txtTestTemplateY0Start;
        private System.Windows.Forms.TextBox txtTestTemplateX0Step;
        private System.Windows.Forms.TextBox txtTestTemplateX0End;
        private System.Windows.Forms.TextBox txtTestTemplateX0Start;
        private System.Windows.Forms.Label lblTestTemplateB;
        private System.Windows.Forms.Label lblTestTemplateA;
        private System.Windows.Forms.Label lblTestTemplateY0;
        private System.Windows.Forms.Label lblTestTemplateX0;
        private System.Windows.Forms.TextBox txtEraseChainsA;
        private System.Windows.Forms.Label lblEraseChainsA;
        private System.Windows.Forms.TextBox txtMedianSmoothSize;
        private System.Windows.Forms.Label lblMedianSmoothSize;
        private System.Windows.Forms.TextBox txtTemplateThresholdRate;
        private System.Windows.Forms.TextBox txtTemplateThresholdPoints;
        private System.Windows.Forms.Label lblTemplateThresholds;
        private System.Windows.Forms.TextBox txtCannyLinkThreshold;
        private System.Windows.Forms.TextBox txtCannyThreshold;
        private System.Windows.Forms.Label lblCannyThresholds;
        private System.Windows.Forms.Label lblAdaptiveTitle;
    }
}