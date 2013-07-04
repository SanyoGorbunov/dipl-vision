namespace SkinDetection
{
    partial class TestTrace
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
            this.pnlConfigTraceLines = new System.Windows.Forms.Panel();
            this.txtConfigTraceImgWidth = new System.Windows.Forms.TextBox();
            this.lblConfigTraceImgWidth = new System.Windows.Forms.Label();
            this.txtConfigTraceImgHeight = new System.Windows.Forms.TextBox();
            this.lblConfigTraceImgHeight = new System.Windows.Forms.Label();
            this.btnSaveTraceLines = new System.Windows.Forms.Button();
            this.btnLoadTraceLines = new System.Windows.Forms.Button();
            this.txtConfigTraceAngles = new System.Windows.Forms.TextBox();
            this.lblConfigTraceAngles = new System.Windows.Forms.Label();
            this.txtConfigTraceDist = new System.Windows.Forms.TextBox();
            this.btnConfigTraceLines = new System.Windows.Forms.Button();
            this.lblConfiTraceDist = new System.Windows.Forms.Label();
            this.lblConfigTraceLines = new System.Windows.Forms.Label();
            this.dlgLoadTraceLines = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveTraceLines = new System.Windows.Forms.SaveFileDialog();
            this.pnlTestImage = new System.Windows.Forms.Panel();
            this.chkTestImageIsMask = new System.Windows.Forms.CheckBox();
            this.btnLoadTestImage = new System.Windows.Forms.Button();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.lblLoadTestImage = new System.Windows.Forms.Label();
            this.dlgLoadTestImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlTransformImage = new System.Windows.Forms.Panel();
            this.pbTrasformImage = new System.Windows.Forms.PictureBox();
            this.btnTransformImage = new System.Windows.Forms.Button();
            this.pnlDatabaseSettings = new System.Windows.Forms.Panel();
            this.btnSaveTransforms = new System.Windows.Forms.Button();
            this.lbDatabaseFunctionals = new System.Windows.Forms.CheckedListBox();
            this.btnDatabaseLearn = new System.Windows.Forms.Button();
            this.txtDatabaseWeightThreshold = new System.Windows.Forms.TextBox();
            this.lblDatabaseWeightThreshold = new System.Windows.Forms.Label();
            this.txtDatabaseLearnImages = new System.Windows.Forms.TextBox();
            this.lblDatabaseLearnCount = new System.Windows.Forms.Label();
            this.btnOpenDatabaseDir = new System.Windows.Forms.Button();
            this.lblDatabaseSettings = new System.Windows.Forms.Label();
            this.dlgOpenDatabaseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgSaveTransformed = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveWeights = new System.Windows.Forms.Button();
            this.dlgSaveWeights = new System.Windows.Forms.SaveFileDialog();
            this.btnDatabaseCreate = new System.Windows.Forms.Button();
            this.btnLoadTransforms = new System.Windows.Forms.Button();
            this.dlgLoadTransforms = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadWeights = new System.Windows.Forms.Button();
            this.dlgLoadWeights = new System.Windows.Forms.OpenFileDialog();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.btnTestDb = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlConfigTraceLines.SuspendLayout();
            this.pnlTestImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.pnlTransformImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrasformImage)).BeginInit();
            this.pnlDatabaseSettings.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfigTraceLines
            // 
            this.pnlConfigTraceLines.Controls.Add(this.txtConfigTraceImgWidth);
            this.pnlConfigTraceLines.Controls.Add(this.lblConfigTraceImgWidth);
            this.pnlConfigTraceLines.Controls.Add(this.txtConfigTraceImgHeight);
            this.pnlConfigTraceLines.Controls.Add(this.lblConfigTraceImgHeight);
            this.pnlConfigTraceLines.Controls.Add(this.btnSaveTraceLines);
            this.pnlConfigTraceLines.Controls.Add(this.btnLoadTraceLines);
            this.pnlConfigTraceLines.Controls.Add(this.txtConfigTraceAngles);
            this.pnlConfigTraceLines.Controls.Add(this.lblConfigTraceAngles);
            this.pnlConfigTraceLines.Controls.Add(this.txtConfigTraceDist);
            this.pnlConfigTraceLines.Controls.Add(this.btnConfigTraceLines);
            this.pnlConfigTraceLines.Controls.Add(this.lblConfiTraceDist);
            this.pnlConfigTraceLines.Controls.Add(this.lblConfigTraceLines);
            this.pnlConfigTraceLines.Location = new System.Drawing.Point(12, 10);
            this.pnlConfigTraceLines.Name = "pnlConfigTraceLines";
            this.pnlConfigTraceLines.Size = new System.Drawing.Size(240, 149);
            this.pnlConfigTraceLines.TabIndex = 0;
            // 
            // txtConfigTraceImgWidth
            // 
            this.txtConfigTraceImgWidth.Location = new System.Drawing.Point(190, 91);
            this.txtConfigTraceImgWidth.Name = "txtConfigTraceImgWidth";
            this.txtConfigTraceImgWidth.Size = new System.Drawing.Size(47, 20);
            this.txtConfigTraceImgWidth.TabIndex = 12;
            // 
            // lblConfigTraceImgWidth
            // 
            this.lblConfigTraceImgWidth.AutoSize = true;
            this.lblConfigTraceImgWidth.Location = new System.Drawing.Point(3, 94);
            this.lblConfigTraceImgWidth.Name = "lblConfigTraceImgWidth";
            this.lblConfigTraceImgWidth.Size = new System.Drawing.Size(114, 13);
            this.lblConfigTraceImgWidth.TabIndex = 11;
            this.lblConfigTraceImgWidth.Text = "Ширина зображення:";
            // 
            // txtConfigTraceImgHeight
            // 
            this.txtConfigTraceImgHeight.Location = new System.Drawing.Point(190, 69);
            this.txtConfigTraceImgHeight.Name = "txtConfigTraceImgHeight";
            this.txtConfigTraceImgHeight.Size = new System.Drawing.Size(47, 20);
            this.txtConfigTraceImgHeight.TabIndex = 10;
            // 
            // lblConfigTraceImgHeight
            // 
            this.lblConfigTraceImgHeight.AutoSize = true;
            this.lblConfigTraceImgHeight.Location = new System.Drawing.Point(3, 72);
            this.lblConfigTraceImgHeight.Name = "lblConfigTraceImgHeight";
            this.lblConfigTraceImgHeight.Size = new System.Drawing.Size(111, 13);
            this.lblConfigTraceImgHeight.TabIndex = 9;
            this.lblConfigTraceImgHeight.Text = "Висота зображення:";
            // 
            // btnSaveTraceLines
            // 
            this.btnSaveTraceLines.Location = new System.Drawing.Point(162, 123);
            this.btnSaveTraceLines.Name = "btnSaveTraceLines";
            this.btnSaveTraceLines.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTraceLines.TabIndex = 8;
            this.btnSaveTraceLines.Text = "Зберегти";
            this.btnSaveTraceLines.UseVisualStyleBackColor = true;
            this.btnSaveTraceLines.Click += new System.EventHandler(this.btnSaveTraceLines_Click);
            // 
            // btnLoadTraceLines
            // 
            this.btnLoadTraceLines.Location = new System.Drawing.Point(6, 123);
            this.btnLoadTraceLines.Name = "btnLoadTraceLines";
            this.btnLoadTraceLines.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTraceLines.TabIndex = 7;
            this.btnLoadTraceLines.Text = "Завантажити";
            this.btnLoadTraceLines.UseVisualStyleBackColor = true;
            this.btnLoadTraceLines.Click += new System.EventHandler(this.btnLoadTraceLines_Click);
            // 
            // txtConfigTraceAngles
            // 
            this.txtConfigTraceAngles.Location = new System.Drawing.Point(190, 46);
            this.txtConfigTraceAngles.Name = "txtConfigTraceAngles";
            this.txtConfigTraceAngles.Size = new System.Drawing.Size(47, 20);
            this.txtConfigTraceAngles.TabIndex = 5;
            // 
            // lblConfigTraceAngles
            // 
            this.lblConfigTraceAngles.AutoSize = true;
            this.lblConfigTraceAngles.Location = new System.Drawing.Point(3, 49);
            this.lblConfigTraceAngles.Name = "lblConfigTraceAngles";
            this.lblConfigTraceAngles.Size = new System.Drawing.Size(83, 13);
            this.lblConfigTraceAngles.TabIndex = 4;
            this.lblConfigTraceAngles.Text = "Кількість кутів:";
            // 
            // txtConfigTraceDist
            // 
            this.txtConfigTraceDist.Location = new System.Drawing.Point(190, 24);
            this.txtConfigTraceDist.Name = "txtConfigTraceDist";
            this.txtConfigTraceDist.Size = new System.Drawing.Size(47, 20);
            this.txtConfigTraceDist.TabIndex = 3;
            // 
            // btnConfigTraceLines
            // 
            this.btnConfigTraceLines.Location = new System.Drawing.Point(87, 123);
            this.btnConfigTraceLines.Name = "btnConfigTraceLines";
            this.btnConfigTraceLines.Size = new System.Drawing.Size(69, 23);
            this.btnConfigTraceLines.TabIndex = 2;
            this.btnConfigTraceLines.Text = "Обчислити";
            this.btnConfigTraceLines.UseVisualStyleBackColor = true;
            this.btnConfigTraceLines.Click += new System.EventHandler(this.btnConfigTraceLines_Click);
            // 
            // lblConfiTraceDist
            // 
            this.lblConfiTraceDist.AutoSize = true;
            this.lblConfiTraceDist.Location = new System.Drawing.Point(3, 27);
            this.lblConfiTraceDist.Name = "lblConfiTraceDist";
            this.lblConfiTraceDist.Size = new System.Drawing.Size(181, 13);
            this.lblConfiTraceDist.TabIndex = 1;
            this.lblConfiTraceDist.Text = "Максимальна відстань від центру:";
            // 
            // lblConfigTraceLines
            // 
            this.lblConfigTraceLines.AutoSize = true;
            this.lblConfigTraceLines.Location = new System.Drawing.Point(3, 9);
            this.lblConfigTraceLines.Name = "lblConfigTraceLines";
            this.lblConfigTraceLines.Size = new System.Drawing.Size(95, 13);
            this.lblConfigTraceLines.TabIndex = 0;
            this.lblConfigTraceLines.Text = "Отримання слідів";
            // 
            // dlgLoadTraceLines
            // 
            this.dlgLoadTraceLines.FileName = "openFileDialog1";
            this.dlgLoadTraceLines.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\Trace" +
                "Transform";
            // 
            // pnlTestImage
            // 
            this.pnlTestImage.Controls.Add(this.chkTestImageIsMask);
            this.pnlTestImage.Controls.Add(this.btnLoadTestImage);
            this.pnlTestImage.Controls.Add(this.pbTestImage);
            this.pnlTestImage.Controls.Add(this.lblLoadTestImage);
            this.pnlTestImage.Location = new System.Drawing.Point(258, 10);
            this.pnlTestImage.Name = "pnlTestImage";
            this.pnlTestImage.Size = new System.Drawing.Size(231, 272);
            this.pnlTestImage.TabIndex = 1;
            // 
            // chkTestImageIsMask
            // 
            this.chkTestImageIsMask.AutoSize = true;
            this.chkTestImageIsMask.Location = new System.Drawing.Point(16, 252);
            this.chkTestImageIsMask.Name = "chkTestImageIsMask";
            this.chkTestImageIsMask.Size = new System.Drawing.Size(63, 17);
            this.chkTestImageIsMask.TabIndex = 3;
            this.chkTestImageIsMask.Text = "Is Mask";
            this.chkTestImageIsMask.UseVisualStyleBackColor = true;
            // 
            // btnLoadTestImage
            // 
            this.btnLoadTestImage.Location = new System.Drawing.Point(144, 9);
            this.btnLoadTestImage.Name = "btnLoadTestImage";
            this.btnLoadTestImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTestImage.TabIndex = 2;
            this.btnLoadTestImage.Text = "Load";
            this.btnLoadTestImage.UseVisualStyleBackColor = true;
            this.btnLoadTestImage.Click += new System.EventHandler(this.btnLoadTestImage_Click);
            // 
            // pbTestImage
            // 
            this.pbTestImage.Location = new System.Drawing.Point(29, 42);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(180, 200);
            this.pbTestImage.TabIndex = 1;
            this.pbTestImage.TabStop = false;
            // 
            // lblLoadTestImage
            // 
            this.lblLoadTestImage.AutoSize = true;
            this.lblLoadTestImage.Location = new System.Drawing.Point(13, 14);
            this.lblLoadTestImage.Name = "lblLoadTestImage";
            this.lblLoadTestImage.Size = new System.Drawing.Size(116, 13);
            this.lblLoadTestImage.TabIndex = 0;
            this.lblLoadTestImage.Text = "Please load test image:";
            // 
            // dlgLoadTestImage
            // 
            this.dlgLoadTestImage.FileName = "openFileDialog1";
            this.dlgLoadTestImage.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94";
            // 
            // pnlTransformImage
            // 
            this.pnlTransformImage.Controls.Add(this.pbTrasformImage);
            this.pnlTransformImage.Controls.Add(this.btnTransformImage);
            this.pnlTransformImage.Location = new System.Drawing.Point(495, 10);
            this.pnlTransformImage.Name = "pnlTransformImage";
            this.pnlTransformImage.Size = new System.Drawing.Size(496, 263);
            this.pnlTransformImage.TabIndex = 2;
            // 
            // pbTrasformImage
            // 
            this.pbTrasformImage.Location = new System.Drawing.Point(3, 42);
            this.pbTrasformImage.Name = "pbTrasformImage";
            this.pbTrasformImage.Size = new System.Drawing.Size(490, 200);
            this.pbTrasformImage.TabIndex = 1;
            this.pbTrasformImage.TabStop = false;
            // 
            // btnTransformImage
            // 
            this.btnTransformImage.Location = new System.Drawing.Point(3, 9);
            this.btnTransformImage.Name = "btnTransformImage";
            this.btnTransformImage.Size = new System.Drawing.Size(75, 23);
            this.btnTransformImage.TabIndex = 0;
            this.btnTransformImage.Text = "Transform";
            this.btnTransformImage.UseVisualStyleBackColor = true;
            this.btnTransformImage.Click += new System.EventHandler(this.btnTransformImage_Click);
            // 
            // pnlDatabaseSettings
            // 
            this.pnlDatabaseSettings.Controls.Add(this.button1);
            this.pnlDatabaseSettings.Controls.Add(this.btnLoadWeights);
            this.pnlDatabaseSettings.Controls.Add(this.btnLoadTransforms);
            this.pnlDatabaseSettings.Controls.Add(this.btnDatabaseCreate);
            this.pnlDatabaseSettings.Controls.Add(this.btnSaveWeights);
            this.pnlDatabaseSettings.Controls.Add(this.btnSaveTransforms);
            this.pnlDatabaseSettings.Controls.Add(this.lbDatabaseFunctionals);
            this.pnlDatabaseSettings.Controls.Add(this.btnDatabaseLearn);
            this.pnlDatabaseSettings.Controls.Add(this.txtDatabaseWeightThreshold);
            this.pnlDatabaseSettings.Controls.Add(this.lblDatabaseWeightThreshold);
            this.pnlDatabaseSettings.Controls.Add(this.txtDatabaseLearnImages);
            this.pnlDatabaseSettings.Controls.Add(this.lblDatabaseLearnCount);
            this.pnlDatabaseSettings.Controls.Add(this.btnOpenDatabaseDir);
            this.pnlDatabaseSettings.Controls.Add(this.lblDatabaseSettings);
            this.pnlDatabaseSettings.Location = new System.Drawing.Point(12, 166);
            this.pnlDatabaseSettings.Name = "pnlDatabaseSettings";
            this.pnlDatabaseSettings.Size = new System.Drawing.Size(240, 338);
            this.pnlDatabaseSettings.TabIndex = 3;
            // 
            // btnSaveTransforms
            // 
            this.btnSaveTransforms.Location = new System.Drawing.Point(6, 218);
            this.btnSaveTransforms.Name = "btnSaveTransforms";
            this.btnSaveTransforms.Size = new System.Drawing.Size(227, 23);
            this.btnSaveTransforms.TabIndex = 9;
            this.btnSaveTransforms.Text = "Зберегти матриці перетворень";
            this.btnSaveTransforms.UseVisualStyleBackColor = true;
            this.btnSaveTransforms.Click += new System.EventHandler(this.btnSaveTransforms_Click);
            // 
            // lbDatabaseFunctionals
            // 
            this.lbDatabaseFunctionals.FormattingEnabled = true;
            this.lbDatabaseFunctionals.Items.AddRange(new object[] {
            "Сума",
            "Корінь",
            "Різниці",
            "Медіана"});
            this.lbDatabaseFunctionals.Location = new System.Drawing.Point(6, 89);
            this.lbDatabaseFunctionals.Name = "lbDatabaseFunctionals";
            this.lbDatabaseFunctionals.Size = new System.Drawing.Size(227, 64);
            this.lbDatabaseFunctionals.TabIndex = 8;
            // 
            // btnDatabaseLearn
            // 
            this.btnDatabaseLearn.Location = new System.Drawing.Point(146, 160);
            this.btnDatabaseLearn.Name = "btnDatabaseLearn";
            this.btnDatabaseLearn.Size = new System.Drawing.Size(87, 23);
            this.btnDatabaseLearn.TabIndex = 7;
            this.btnDatabaseLearn.Text = "Навчити";
            this.btnDatabaseLearn.UseVisualStyleBackColor = true;
            this.btnDatabaseLearn.Click += new System.EventHandler(this.btnDatabaseLearn_Click);
            // 
            // txtDatabaseWeightThreshold
            // 
            this.txtDatabaseWeightThreshold.Location = new System.Drawing.Point(190, 55);
            this.txtDatabaseWeightThreshold.Name = "txtDatabaseWeightThreshold";
            this.txtDatabaseWeightThreshold.Size = new System.Drawing.Size(43, 20);
            this.txtDatabaseWeightThreshold.TabIndex = 5;
            // 
            // lblDatabaseWeightThreshold
            // 
            this.lblDatabaseWeightThreshold.AutoSize = true;
            this.lblDatabaseWeightThreshold.Location = new System.Drawing.Point(90, 58);
            this.lblDatabaseWeightThreshold.Name = "lblDatabaseWeightThreshold";
            this.lblDatabaseWeightThreshold.Size = new System.Drawing.Size(80, 13);
            this.lblDatabaseWeightThreshold.TabIndex = 4;
            this.lblDatabaseWeightThreshold.Text = "Ваговий поріг:";
            // 
            // txtDatabaseLearnImages
            // 
            this.txtDatabaseLearnImages.Location = new System.Drawing.Point(190, 29);
            this.txtDatabaseLearnImages.Name = "txtDatabaseLearnImages";
            this.txtDatabaseLearnImages.Size = new System.Drawing.Size(43, 20);
            this.txtDatabaseLearnImages.TabIndex = 3;
            // 
            // lblDatabaseLearnCount
            // 
            this.lblDatabaseLearnCount.AutoSize = true;
            this.lblDatabaseLearnCount.Location = new System.Drawing.Point(110, 32);
            this.lblDatabaseLearnCount.Name = "lblDatabaseLearnCount";
            this.lblDatabaseLearnCount.Size = new System.Drawing.Size(56, 13);
            this.lblDatabaseLearnCount.TabIndex = 2;
            this.lblDatabaseLearnCount.Text = "Кількість:";
            // 
            // btnOpenDatabaseDir
            // 
            this.btnOpenDatabaseDir.Location = new System.Drawing.Point(6, 26);
            this.btnOpenDatabaseDir.Name = "btnOpenDatabaseDir";
            this.btnOpenDatabaseDir.Size = new System.Drawing.Size(91, 23);
            this.btnOpenDatabaseDir.TabIndex = 1;
            this.btnOpenDatabaseDir.Text = "Відкрити";
            this.btnOpenDatabaseDir.UseVisualStyleBackColor = true;
            this.btnOpenDatabaseDir.Click += new System.EventHandler(this.btnOpenDatabaseDir_Click);
            // 
            // lblDatabaseSettings
            // 
            this.lblDatabaseSettings.AutoSize = true;
            this.lblDatabaseSettings.Location = new System.Drawing.Point(3, 10);
            this.lblDatabaseSettings.Name = "lblDatabaseSettings";
            this.lblDatabaseSettings.Size = new System.Drawing.Size(91, 13);
            this.lblDatabaseSettings.TabIndex = 0;
            this.lblDatabaseSettings.Text = "База зображень";
            // 
            // dlgOpenDatabaseDir
            // 
            this.dlgOpenDatabaseDir.SelectedPath = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94\\male\\ellipse";
            // 
            // btnSaveWeights
            // 
            this.btnSaveWeights.Location = new System.Drawing.Point(7, 286);
            this.btnSaveWeights.Name = "btnSaveWeights";
            this.btnSaveWeights.Size = new System.Drawing.Size(223, 23);
            this.btnSaveWeights.TabIndex = 10;
            this.btnSaveWeights.Text = "Зберегти матриці вагів";
            this.btnSaveWeights.UseVisualStyleBackColor = true;
            this.btnSaveWeights.Click += new System.EventHandler(this.btnSaveWeights_Click);
            // 
            // btnDatabaseCreate
            // 
            this.btnDatabaseCreate.Location = new System.Drawing.Point(6, 160);
            this.btnDatabaseCreate.Name = "btnDatabaseCreate";
            this.btnDatabaseCreate.Size = new System.Drawing.Size(87, 23);
            this.btnDatabaseCreate.TabIndex = 11;
            this.btnDatabaseCreate.Text = "Створити";
            this.btnDatabaseCreate.UseVisualStyleBackColor = true;
            this.btnDatabaseCreate.Click += new System.EventHandler(this.btnDatabaseCreate_Click);
            // 
            // btnLoadTransforms
            // 
            this.btnLoadTransforms.Location = new System.Drawing.Point(6, 189);
            this.btnLoadTransforms.Name = "btnLoadTransforms";
            this.btnLoadTransforms.Size = new System.Drawing.Size(227, 23);
            this.btnLoadTransforms.TabIndex = 12;
            this.btnLoadTransforms.Text = "Завантажити матриці перетворень";
            this.btnLoadTransforms.UseVisualStyleBackColor = true;
            this.btnLoadTransforms.Click += new System.EventHandler(this.btnLoadTransforms_Click);
            // 
            // dlgLoadTransforms
            // 
            this.dlgLoadTransforms.FileName = "openFileDialog1";
            this.dlgLoadTransforms.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94";
            // 
            // btnLoadWeights
            // 
            this.btnLoadWeights.Location = new System.Drawing.Point(6, 257);
            this.btnLoadWeights.Name = "btnLoadWeights";
            this.btnLoadWeights.Size = new System.Drawing.Size(224, 23);
            this.btnLoadWeights.TabIndex = 13;
            this.btnLoadWeights.Text = "Завантажити матриці вагів";
            this.btnLoadWeights.UseVisualStyleBackColor = true;
            this.btnLoadWeights.Click += new System.EventHandler(this.btnLoadWeights_Click);
            // 
            // dlgLoadWeights
            // 
            this.dlgLoadWeights.FileName = "openFileDialog1";
            this.dlgLoadWeights.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\db\\fa" +
                "ces94";
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.lblRate);
            this.pnlResults.Controls.Add(this.btnTestDb);
            this.pnlResults.Location = new System.Drawing.Point(258, 288);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(231, 216);
            this.pnlResults.TabIndex = 4;
            // 
            // btnTestDb
            // 
            this.btnTestDb.Location = new System.Drawing.Point(79, 8);
            this.btnTestDb.Name = "btnTestDb";
            this.btnTestDb.Size = new System.Drawing.Size(75, 23);
            this.btnTestDb.TabIndex = 0;
            this.btnTestDb.Text = "Test";
            this.btnTestDb.UseVisualStyleBackColor = true;
            this.btnTestDb.Click += new System.EventHandler(this.btnTestDb_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(94, 67);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(35, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Тестувати";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 516);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlDatabaseSettings);
            this.Controls.Add(this.pnlTransformImage);
            this.Controls.Add(this.pnlTestImage);
            this.Controls.Add(this.pnlConfigTraceLines);
            this.Name = "TestTrace";
            this.Text = "Метод на основі перетворення сліду";
            this.pnlConfigTraceLines.ResumeLayout(false);
            this.pnlConfigTraceLines.PerformLayout();
            this.pnlTestImage.ResumeLayout(false);
            this.pnlTestImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.pnlTransformImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrasformImage)).EndInit();
            this.pnlDatabaseSettings.ResumeLayout(false);
            this.pnlDatabaseSettings.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfigTraceLines;
        private System.Windows.Forms.Button btnSaveTraceLines;
        private System.Windows.Forms.Button btnLoadTraceLines;
        private System.Windows.Forms.TextBox txtConfigTraceAngles;
        private System.Windows.Forms.Label lblConfigTraceAngles;
        private System.Windows.Forms.TextBox txtConfigTraceDist;
        private System.Windows.Forms.Button btnConfigTraceLines;
        private System.Windows.Forms.Label lblConfiTraceDist;
        private System.Windows.Forms.Label lblConfigTraceLines;
        private System.Windows.Forms.OpenFileDialog dlgLoadTraceLines;
        private System.Windows.Forms.SaveFileDialog dlgSaveTraceLines;
        private System.Windows.Forms.TextBox txtConfigTraceImgWidth;
        private System.Windows.Forms.Label lblConfigTraceImgWidth;
        private System.Windows.Forms.TextBox txtConfigTraceImgHeight;
        private System.Windows.Forms.Label lblConfigTraceImgHeight;
        private System.Windows.Forms.Panel pnlTestImage;
        private System.Windows.Forms.Button btnLoadTestImage;
        private System.Windows.Forms.PictureBox pbTestImage;
        private System.Windows.Forms.Label lblLoadTestImage;
        private System.Windows.Forms.OpenFileDialog dlgLoadTestImage;
        private System.Windows.Forms.Panel pnlTransformImage;
        private System.Windows.Forms.PictureBox pbTrasformImage;
        private System.Windows.Forms.Button btnTransformImage;
        private System.Windows.Forms.CheckBox chkTestImageIsMask;
        private System.Windows.Forms.Panel pnlDatabaseSettings;
        private System.Windows.Forms.Button btnOpenDatabaseDir;
        private System.Windows.Forms.Label lblDatabaseSettings;
        private System.Windows.Forms.TextBox txtDatabaseLearnImages;
        private System.Windows.Forms.Label lblDatabaseLearnCount;
        private System.Windows.Forms.TextBox txtDatabaseWeightThreshold;
        private System.Windows.Forms.Label lblDatabaseWeightThreshold;
        private System.Windows.Forms.Button btnDatabaseLearn;
        private System.Windows.Forms.CheckedListBox lbDatabaseFunctionals;
        private System.Windows.Forms.FolderBrowserDialog dlgOpenDatabaseDir;
        private System.Windows.Forms.Button btnSaveTransforms;
        private System.Windows.Forms.SaveFileDialog dlgSaveTransformed;
        private System.Windows.Forms.Button btnSaveWeights;
        private System.Windows.Forms.SaveFileDialog dlgSaveWeights;
        private System.Windows.Forms.Button btnDatabaseCreate;
        private System.Windows.Forms.Button btnLoadTransforms;
        private System.Windows.Forms.OpenFileDialog dlgLoadTransforms;
        private System.Windows.Forms.Button btnLoadWeights;
        private System.Windows.Forms.OpenFileDialog dlgLoadWeights;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnTestDb;
        private System.Windows.Forms.Button button1;
    }
}