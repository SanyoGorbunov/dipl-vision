namespace SkinDetection
{
    partial class ShapeInfoLib
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
            this.pnlTest = new System.Windows.Forms.Panel();
            this.btnSmoothMedian = new System.Windows.Forms.Button();
            this.btnEqualizeTestImage = new System.Windows.Forms.Button();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.btnLoadTestImage = new System.Windows.Forms.Button();
            this.dlgLoadTestImage = new System.Windows.Forms.OpenFileDialog();
            this.lblSmoothMedianSize = new System.Windows.Forms.Label();
            this.txtSmoothMedianSize = new System.Windows.Forms.TextBox();
            this.btnDetectEdges = new System.Windows.Forms.Button();
            this.txtCannyInitialThresh = new System.Windows.Forms.TextBox();
            this.lblCannyInitialThresh = new System.Windows.Forms.Label();
            this.txtCannyEdgeThresh = new System.Windows.Forms.TextBox();
            this.lblCannyEdgeThreshold = new System.Windows.Forms.Label();
            this.pnlContours = new System.Windows.Forms.Panel();
            this.lbContours = new System.Windows.Forms.ListBox();
            this.lblContourPoints = new System.Windows.Forms.Label();
            this.lblContourDistance = new System.Windows.Forms.Label();
            this.txtContourMinArc = new System.Windows.Forms.TextBox();
            this.lblContourMinArc = new System.Windows.Forms.Label();
            this.lblContourCount = new System.Windows.Forms.Label();
            this.btnShowContours = new System.Windows.Forms.Button();
            this.btnRemoveContoursByMinArc = new System.Windows.Forms.Button();
            this.btnDivideContours = new System.Windows.Forms.Button();
            this.pnlEllipticalTemplate = new System.Windows.Forms.Panel();
            this.txtTemplateX0 = new System.Windows.Forms.TextBox();
            this.lblTemplateX0 = new System.Windows.Forms.Label();
            this.txtTemplateY0 = new System.Windows.Forms.TextBox();
            this.lblTemplateY0 = new System.Windows.Forms.Label();
            this.txtTemplateA = new System.Windows.Forms.TextBox();
            this.lblTemplateA = new System.Windows.Forms.Label();
            this.txtTemplateB = new System.Windows.Forms.TextBox();
            this.lblTemplateB = new System.Windows.Forms.Label();
            this.lblTemplateG = new System.Windows.Forms.Label();
            this.lblTemplateN = new System.Windows.Forms.Label();
            this.lblTemplateRate = new System.Windows.Forms.Label();
            this.btnTemplateFind = new System.Windows.Forms.Button();
            this.btnTestTemplate = new System.Windows.Forms.Button();
            this.lblTestTemplateX0 = new System.Windows.Forms.Label();
            this.lblTestTemplateB = new System.Windows.Forms.Label();
            this.lblTestTemplateA = new System.Windows.Forms.Label();
            this.lblTestTemplateY0 = new System.Windows.Forms.Label();
            this.txtTestTemplateX0Start = new System.Windows.Forms.TextBox();
            this.txtTestTemplateX0End = new System.Windows.Forms.TextBox();
            this.txtTestTemplateX0Step = new System.Windows.Forms.TextBox();
            this.txtTestTemplateY0Step = new System.Windows.Forms.TextBox();
            this.txtTestTemplateY0End = new System.Windows.Forms.TextBox();
            this.txtTestTemplateY0Start = new System.Windows.Forms.TextBox();
            this.txtTestTemplateAStep = new System.Windows.Forms.TextBox();
            this.txtTestTemplateAEnd = new System.Windows.Forms.TextBox();
            this.txtTestTemplateAStart = new System.Windows.Forms.TextBox();
            this.txtTestTemplateBStep = new System.Windows.Forms.TextBox();
            this.txtTestTemplateBEnd = new System.Windows.Forms.TextBox();
            this.txtTestTemplateBStart = new System.Windows.Forms.TextBox();
            this.dlgSaveTestTemplate = new System.Windows.Forms.SaveFileDialog();
            this.btnTestTemplateToForm = new System.Windows.Forms.Button();
            this.lbTemplates = new System.Windows.Forms.ListBox();
            this.btnTemplateOrderByRate = new System.Windows.Forms.Button();
            this.btnTemplateOrderByCount = new System.Windows.Forms.Button();
            this.lblTemplateMinCount = new System.Windows.Forms.Label();
            this.txtTemplateMinCount = new System.Windows.Forms.TextBox();
            this.btnTemplateRemoveByMinCount = new System.Windows.Forms.Button();
            this.btnTemplateRemoveOutborders = new System.Windows.Forms.Button();
            this.pnlTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.pnlContours.SuspendLayout();
            this.pnlEllipticalTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTest
            // 
            this.pnlTest.Controls.Add(this.txtCannyEdgeThresh);
            this.pnlTest.Controls.Add(this.lblCannyEdgeThreshold);
            this.pnlTest.Controls.Add(this.txtCannyInitialThresh);
            this.pnlTest.Controls.Add(this.lblCannyInitialThresh);
            this.pnlTest.Controls.Add(this.btnDetectEdges);
            this.pnlTest.Controls.Add(this.txtSmoothMedianSize);
            this.pnlTest.Controls.Add(this.lblSmoothMedianSize);
            this.pnlTest.Controls.Add(this.btnSmoothMedian);
            this.pnlTest.Controls.Add(this.btnEqualizeTestImage);
            this.pnlTest.Controls.Add(this.pbTestImage);
            this.pnlTest.Controls.Add(this.btnLoadTestImage);
            this.pnlTest.Location = new System.Drawing.Point(12, 12);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(268, 325);
            this.pnlTest.TabIndex = 0;
            // 
            // btnSmoothMedian
            // 
            this.btnSmoothMedian.Location = new System.Drawing.Point(160, 259);
            this.btnSmoothMedian.Name = "btnSmoothMedian";
            this.btnSmoothMedian.Size = new System.Drawing.Size(105, 23);
            this.btnSmoothMedian.TabIndex = 3;
            this.btnSmoothMedian.Text = "Smooth Median";
            this.btnSmoothMedian.UseVisualStyleBackColor = true;
            this.btnSmoothMedian.Click += new System.EventHandler(this.btnSmoothMedian_Click);
            // 
            // btnEqualizeTestImage
            // 
            this.btnEqualizeTestImage.Location = new System.Drawing.Point(160, 230);
            this.btnEqualizeTestImage.Name = "btnEqualizeTestImage";
            this.btnEqualizeTestImage.Size = new System.Drawing.Size(105, 23);
            this.btnEqualizeTestImage.TabIndex = 2;
            this.btnEqualizeTestImage.Text = "Equalize";
            this.btnEqualizeTestImage.UseVisualStyleBackColor = true;
            this.btnEqualizeTestImage.Click += new System.EventHandler(this.btnEqualizeTestImage_Click);
            // 
            // pbTestImage
            // 
            this.pbTestImage.Location = new System.Drawing.Point(3, 3);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(262, 221);
            this.pbTestImage.TabIndex = 1;
            this.pbTestImage.TabStop = false;
            // 
            // btnLoadTestImage
            // 
            this.btnLoadTestImage.Location = new System.Drawing.Point(3, 230);
            this.btnLoadTestImage.Name = "btnLoadTestImage";
            this.btnLoadTestImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTestImage.TabIndex = 0;
            this.btnLoadTestImage.Text = "Load";
            this.btnLoadTestImage.UseVisualStyleBackColor = true;
            this.btnLoadTestImage.Click += new System.EventHandler(this.btnLoadTestImage_Click);
            // 
            // dlgLoadTestImage
            // 
            this.dlgLoadTestImage.FileName = "openFileDialog1";
            // 
            // lblSmoothMedianSize
            // 
            this.lblSmoothMedianSize.AutoSize = true;
            this.lblSmoothMedianSize.Location = new System.Drawing.Point(43, 264);
            this.lblSmoothMedianSize.Name = "lblSmoothMedianSize";
            this.lblSmoothMedianSize.Size = new System.Drawing.Size(30, 13);
            this.lblSmoothMedianSize.TabIndex = 4;
            this.lblSmoothMedianSize.Text = "Size:";
            // 
            // txtSmoothMedianSize
            // 
            this.txtSmoothMedianSize.Location = new System.Drawing.Point(79, 261);
            this.txtSmoothMedianSize.Name = "txtSmoothMedianSize";
            this.txtSmoothMedianSize.Size = new System.Drawing.Size(37, 20);
            this.txtSmoothMedianSize.TabIndex = 5;
            this.txtSmoothMedianSize.Text = "5";
            // 
            // btnDetectEdges
            // 
            this.btnDetectEdges.Location = new System.Drawing.Point(160, 288);
            this.btnDetectEdges.Name = "btnDetectEdges";
            this.btnDetectEdges.Size = new System.Drawing.Size(105, 23);
            this.btnDetectEdges.TabIndex = 6;
            this.btnDetectEdges.Text = "Detect Edges";
            this.btnDetectEdges.UseVisualStyleBackColor = true;
            this.btnDetectEdges.Click += new System.EventHandler(this.btnDetectEdges_Click);
            // 
            // txtCannyInitialThresh
            // 
            this.txtCannyInitialThresh.Location = new System.Drawing.Point(41, 290);
            this.txtCannyInitialThresh.Name = "txtCannyInitialThresh";
            this.txtCannyInitialThresh.Size = new System.Drawing.Size(37, 20);
            this.txtCannyInitialThresh.TabIndex = 8;
            this.txtCannyInitialThresh.Text = "50";
            // 
            // lblCannyInitialThresh
            // 
            this.lblCannyInitialThresh.AutoSize = true;
            this.lblCannyInitialThresh.Location = new System.Drawing.Point(5, 293);
            this.lblCannyInitialThresh.Name = "lblCannyInitialThresh";
            this.lblCannyInitialThresh.Size = new System.Drawing.Size(29, 13);
            this.lblCannyInitialThresh.TabIndex = 7;
            this.lblCannyInitialThresh.Text = "Th0:";
            // 
            // txtCannyEdgeThresh
            // 
            this.txtCannyEdgeThresh.Location = new System.Drawing.Point(117, 290);
            this.txtCannyEdgeThresh.Name = "txtCannyEdgeThresh";
            this.txtCannyEdgeThresh.Size = new System.Drawing.Size(37, 20);
            this.txtCannyEdgeThresh.TabIndex = 10;
            this.txtCannyEdgeThresh.Text = "200";
            // 
            // lblCannyEdgeThreshold
            // 
            this.lblCannyEdgeThreshold.AutoSize = true;
            this.lblCannyEdgeThreshold.Location = new System.Drawing.Point(81, 293);
            this.lblCannyEdgeThreshold.Name = "lblCannyEdgeThreshold";
            this.lblCannyEdgeThreshold.Size = new System.Drawing.Size(33, 13);
            this.lblCannyEdgeThreshold.TabIndex = 9;
            this.lblCannyEdgeThreshold.Text = "E.Th:";
            // 
            // pnlContours
            // 
            this.pnlContours.Controls.Add(this.btnDivideContours);
            this.pnlContours.Controls.Add(this.btnRemoveContoursByMinArc);
            this.pnlContours.Controls.Add(this.btnShowContours);
            this.pnlContours.Controls.Add(this.lblContourCount);
            this.pnlContours.Controls.Add(this.txtContourMinArc);
            this.pnlContours.Controls.Add(this.lblContourMinArc);
            this.pnlContours.Controls.Add(this.lblContourDistance);
            this.pnlContours.Controls.Add(this.lblContourPoints);
            this.pnlContours.Controls.Add(this.lbContours);
            this.pnlContours.Location = new System.Drawing.Point(283, 12);
            this.pnlContours.Name = "pnlContours";
            this.pnlContours.Size = new System.Drawing.Size(214, 325);
            this.pnlContours.TabIndex = 1;
            // 
            // lbContours
            // 
            this.lbContours.FormattingEnabled = true;
            this.lbContours.Location = new System.Drawing.Point(3, 29);
            this.lbContours.Name = "lbContours";
            this.lbContours.Size = new System.Drawing.Size(208, 160);
            this.lbContours.TabIndex = 0;
            this.lbContours.SelectedIndexChanged += new System.EventHandler(this.lbContours_SelectedIndexChanged);
            // 
            // lblContourPoints
            // 
            this.lblContourPoints.AutoSize = true;
            this.lblContourPoints.Location = new System.Drawing.Point(3, 192);
            this.lblContourPoints.Name = "lblContourPoints";
            this.lblContourPoints.Size = new System.Drawing.Size(35, 13);
            this.lblContourPoints.TabIndex = 1;
            this.lblContourPoints.Text = "label1";
            // 
            // lblContourDistance
            // 
            this.lblContourDistance.AutoSize = true;
            this.lblContourDistance.Location = new System.Drawing.Point(3, 214);
            this.lblContourDistance.Name = "lblContourDistance";
            this.lblContourDistance.Size = new System.Drawing.Size(35, 13);
            this.lblContourDistance.TabIndex = 2;
            this.lblContourDistance.Text = "label1";
            // 
            // txtContourMinArc
            // 
            this.txtContourMinArc.Location = new System.Drawing.Point(57, 230);
            this.txtContourMinArc.Name = "txtContourMinArc";
            this.txtContourMinArc.Size = new System.Drawing.Size(37, 20);
            this.txtContourMinArc.TabIndex = 7;
            this.txtContourMinArc.Text = "5";
            // 
            // lblContourMinArc
            // 
            this.lblContourMinArc.AutoSize = true;
            this.lblContourMinArc.Location = new System.Drawing.Point(5, 233);
            this.lblContourMinArc.Name = "lblContourMinArc";
            this.lblContourMinArc.Size = new System.Drawing.Size(46, 13);
            this.lblContourMinArc.TabIndex = 6;
            this.lblContourMinArc.Text = "Min Arc:";
            // 
            // lblContourCount
            // 
            this.lblContourCount.AutoSize = true;
            this.lblContourCount.Location = new System.Drawing.Point(3, 13);
            this.lblContourCount.Name = "lblContourCount";
            this.lblContourCount.Size = new System.Drawing.Size(35, 13);
            this.lblContourCount.TabIndex = 8;
            this.lblContourCount.Text = "label1";
            // 
            // btnShowContours
            // 
            this.btnShowContours.Location = new System.Drawing.Point(121, 3);
            this.btnShowContours.Name = "btnShowContours";
            this.btnShowContours.Size = new System.Drawing.Size(90, 23);
            this.btnShowContours.TabIndex = 9;
            this.btnShowContours.Text = "Show Contours";
            this.btnShowContours.UseVisualStyleBackColor = true;
            this.btnShowContours.Click += new System.EventHandler(this.btnShowContours_Click);
            // 
            // btnRemoveContoursByMinArc
            // 
            this.btnRemoveContoursByMinArc.Location = new System.Drawing.Point(100, 227);
            this.btnRemoveContoursByMinArc.Name = "btnRemoveContoursByMinArc";
            this.btnRemoveContoursByMinArc.Size = new System.Drawing.Size(111, 23);
            this.btnRemoveContoursByMinArc.TabIndex = 10;
            this.btnRemoveContoursByMinArc.Text = "Remove Contours";
            this.btnRemoveContoursByMinArc.UseVisualStyleBackColor = true;
            this.btnRemoveContoursByMinArc.Click += new System.EventHandler(this.btnRemoveContoursByMinArc_Click);
            // 
            // btnDivideContours
            // 
            this.btnDivideContours.Location = new System.Drawing.Point(100, 254);
            this.btnDivideContours.Name = "btnDivideContours";
            this.btnDivideContours.Size = new System.Drawing.Size(111, 23);
            this.btnDivideContours.TabIndex = 11;
            this.btnDivideContours.Text = "Divide Contours";
            this.btnDivideContours.UseVisualStyleBackColor = true;
            this.btnDivideContours.Click += new System.EventHandler(this.btnDivideContours_Click);
            // 
            // pnlEllipticalTemplate
            // 
            this.pnlEllipticalTemplate.Controls.Add(this.btnTemplateRemoveOutborders);
            this.pnlEllipticalTemplate.Controls.Add(this.btnTemplateRemoveByMinCount);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTemplateMinCount);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTemplateMinCount);
            this.pnlEllipticalTemplate.Controls.Add(this.btnTemplateOrderByCount);
            this.pnlEllipticalTemplate.Controls.Add(this.btnTemplateOrderByRate);
            this.pnlEllipticalTemplate.Controls.Add(this.lbTemplates);
            this.pnlEllipticalTemplate.Controls.Add(this.btnTestTemplateToForm);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateBStep);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateBEnd);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateBStart);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateAStep);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateAEnd);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateAStart);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateY0Step);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateY0End);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateY0Start);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateX0Step);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateX0End);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTestTemplateX0Start);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTestTemplateB);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTestTemplateA);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTestTemplateY0);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTestTemplateX0);
            this.pnlEllipticalTemplate.Controls.Add(this.btnTestTemplate);
            this.pnlEllipticalTemplate.Controls.Add(this.btnTemplateFind);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTemplateRate);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTemplateN);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTemplateG);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTemplateB);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTemplateB);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTemplateA);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTemplateA);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTemplateY0);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTemplateY0);
            this.pnlEllipticalTemplate.Controls.Add(this.txtTemplateX0);
            this.pnlEllipticalTemplate.Controls.Add(this.lblTemplateX0);
            this.pnlEllipticalTemplate.Location = new System.Drawing.Point(500, 12);
            this.pnlEllipticalTemplate.Name = "pnlEllipticalTemplate";
            this.pnlEllipticalTemplate.Size = new System.Drawing.Size(200, 353);
            this.pnlEllipticalTemplate.TabIndex = 2;
            // 
            // txtTemplateX0
            // 
            this.txtTemplateX0.Location = new System.Drawing.Point(65, 6);
            this.txtTemplateX0.Name = "txtTemplateX0";
            this.txtTemplateX0.Size = new System.Drawing.Size(37, 20);
            this.txtTemplateX0.TabIndex = 9;
            this.txtTemplateX0.Text = "5";
            // 
            // lblTemplateX0
            // 
            this.lblTemplateX0.AutoSize = true;
            this.lblTemplateX0.Location = new System.Drawing.Point(13, 9);
            this.lblTemplateX0.Name = "lblTemplateX0";
            this.lblTemplateX0.Size = new System.Drawing.Size(23, 13);
            this.lblTemplateX0.TabIndex = 8;
            this.lblTemplateX0.Text = "X0:";
            // 
            // txtTemplateY0
            // 
            this.txtTemplateY0.Location = new System.Drawing.Point(65, 29);
            this.txtTemplateY0.Name = "txtTemplateY0";
            this.txtTemplateY0.Size = new System.Drawing.Size(37, 20);
            this.txtTemplateY0.TabIndex = 11;
            this.txtTemplateY0.Text = "5";
            // 
            // lblTemplateY0
            // 
            this.lblTemplateY0.AutoSize = true;
            this.lblTemplateY0.Location = new System.Drawing.Point(13, 32);
            this.lblTemplateY0.Name = "lblTemplateY0";
            this.lblTemplateY0.Size = new System.Drawing.Size(23, 13);
            this.lblTemplateY0.TabIndex = 10;
            this.lblTemplateY0.Text = "Y0:";
            // 
            // txtTemplateA
            // 
            this.txtTemplateA.Location = new System.Drawing.Point(65, 55);
            this.txtTemplateA.Name = "txtTemplateA";
            this.txtTemplateA.Size = new System.Drawing.Size(37, 20);
            this.txtTemplateA.TabIndex = 13;
            this.txtTemplateA.Text = "5";
            // 
            // lblTemplateA
            // 
            this.lblTemplateA.AutoSize = true;
            this.lblTemplateA.Location = new System.Drawing.Point(13, 58);
            this.lblTemplateA.Name = "lblTemplateA";
            this.lblTemplateA.Size = new System.Drawing.Size(16, 13);
            this.lblTemplateA.TabIndex = 12;
            this.lblTemplateA.Text = "a:";
            // 
            // txtTemplateB
            // 
            this.txtTemplateB.Location = new System.Drawing.Point(65, 81);
            this.txtTemplateB.Name = "txtTemplateB";
            this.txtTemplateB.Size = new System.Drawing.Size(37, 20);
            this.txtTemplateB.TabIndex = 15;
            this.txtTemplateB.Text = "5";
            // 
            // lblTemplateB
            // 
            this.lblTemplateB.AutoSize = true;
            this.lblTemplateB.Location = new System.Drawing.Point(13, 84);
            this.lblTemplateB.Name = "lblTemplateB";
            this.lblTemplateB.Size = new System.Drawing.Size(16, 13);
            this.lblTemplateB.TabIndex = 14;
            this.lblTemplateB.Text = "b:";
            // 
            // lblTemplateG
            // 
            this.lblTemplateG.AutoSize = true;
            this.lblTemplateG.Location = new System.Drawing.Point(117, 9);
            this.lblTemplateG.Name = "lblTemplateG";
            this.lblTemplateG.Size = new System.Drawing.Size(35, 13);
            this.lblTemplateG.TabIndex = 16;
            this.lblTemplateG.Text = "label1";
            // 
            // lblTemplateN
            // 
            this.lblTemplateN.AutoSize = true;
            this.lblTemplateN.Location = new System.Drawing.Point(117, 32);
            this.lblTemplateN.Name = "lblTemplateN";
            this.lblTemplateN.Size = new System.Drawing.Size(35, 13);
            this.lblTemplateN.TabIndex = 17;
            this.lblTemplateN.Text = "label1";
            // 
            // lblTemplateRate
            // 
            this.lblTemplateRate.AutoSize = true;
            this.lblTemplateRate.Location = new System.Drawing.Point(117, 58);
            this.lblTemplateRate.Name = "lblTemplateRate";
            this.lblTemplateRate.Size = new System.Drawing.Size(35, 13);
            this.lblTemplateRate.TabIndex = 18;
            this.lblTemplateRate.Text = "label1";
            // 
            // btnTemplateFind
            // 
            this.btnTemplateFind.Location = new System.Drawing.Point(108, 79);
            this.btnTemplateFind.Name = "btnTemplateFind";
            this.btnTemplateFind.Size = new System.Drawing.Size(75, 23);
            this.btnTemplateFind.TabIndex = 19;
            this.btnTemplateFind.Text = "Find";
            this.btnTemplateFind.UseVisualStyleBackColor = true;
            this.btnTemplateFind.Click += new System.EventHandler(this.btnTemplateFind_Click);
            // 
            // btnTestTemplate
            // 
            this.btnTestTemplate.Location = new System.Drawing.Point(88, 209);
            this.btnTestTemplate.Name = "btnTestTemplate";
            this.btnTestTemplate.Size = new System.Drawing.Size(95, 23);
            this.btnTestTemplate.TabIndex = 20;
            this.btnTestTemplate.Text = "Save Test to File";
            this.btnTestTemplate.UseVisualStyleBackColor = true;
            this.btnTestTemplate.Click += new System.EventHandler(this.btnTestTemplate_Click);
            // 
            // lblTestTemplateX0
            // 
            this.lblTestTemplateX0.AutoSize = true;
            this.lblTestTemplateX0.Location = new System.Drawing.Point(11, 110);
            this.lblTestTemplateX0.Name = "lblTestTemplateX0";
            this.lblTestTemplateX0.Size = new System.Drawing.Size(23, 13);
            this.lblTestTemplateX0.TabIndex = 21;
            this.lblTestTemplateX0.Text = "X0:";
            // 
            // lblTestTemplateB
            // 
            this.lblTestTemplateB.AutoSize = true;
            this.lblTestTemplateB.Location = new System.Drawing.Point(11, 185);
            this.lblTestTemplateB.Name = "lblTestTemplateB";
            this.lblTestTemplateB.Size = new System.Drawing.Size(16, 13);
            this.lblTestTemplateB.TabIndex = 24;
            this.lblTestTemplateB.Text = "b:";
            // 
            // lblTestTemplateA
            // 
            this.lblTestTemplateA.AutoSize = true;
            this.lblTestTemplateA.Location = new System.Drawing.Point(11, 159);
            this.lblTestTemplateA.Name = "lblTestTemplateA";
            this.lblTestTemplateA.Size = new System.Drawing.Size(16, 13);
            this.lblTestTemplateA.TabIndex = 23;
            this.lblTestTemplateA.Text = "a:";
            // 
            // lblTestTemplateY0
            // 
            this.lblTestTemplateY0.AutoSize = true;
            this.lblTestTemplateY0.Location = new System.Drawing.Point(11, 133);
            this.lblTestTemplateY0.Name = "lblTestTemplateY0";
            this.lblTestTemplateY0.Size = new System.Drawing.Size(23, 13);
            this.lblTestTemplateY0.TabIndex = 22;
            this.lblTestTemplateY0.Text = "Y0:";
            // 
            // txtTestTemplateX0Start
            // 
            this.txtTestTemplateX0Start.Location = new System.Drawing.Point(40, 107);
            this.txtTestTemplateX0Start.Name = "txtTestTemplateX0Start";
            this.txtTestTemplateX0Start.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateX0Start.TabIndex = 25;
            this.txtTestTemplateX0Start.Text = "40";
            // 
            // txtTestTemplateX0End
            // 
            this.txtTestTemplateX0End.Location = new System.Drawing.Point(88, 107);
            this.txtTestTemplateX0End.Name = "txtTestTemplateX0End";
            this.txtTestTemplateX0End.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateX0End.TabIndex = 26;
            this.txtTestTemplateX0End.Text = "80";
            // 
            // txtTestTemplateX0Step
            // 
            this.txtTestTemplateX0Step.Location = new System.Drawing.Point(136, 107);
            this.txtTestTemplateX0Step.Name = "txtTestTemplateX0Step";
            this.txtTestTemplateX0Step.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateX0Step.TabIndex = 27;
            this.txtTestTemplateX0Step.Text = "5";
            // 
            // txtTestTemplateY0Step
            // 
            this.txtTestTemplateY0Step.Location = new System.Drawing.Point(136, 130);
            this.txtTestTemplateY0Step.Name = "txtTestTemplateY0Step";
            this.txtTestTemplateY0Step.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateY0Step.TabIndex = 30;
            this.txtTestTemplateY0Step.Text = "5";
            // 
            // txtTestTemplateY0End
            // 
            this.txtTestTemplateY0End.Location = new System.Drawing.Point(88, 130);
            this.txtTestTemplateY0End.Name = "txtTestTemplateY0End";
            this.txtTestTemplateY0End.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateY0End.TabIndex = 29;
            this.txtTestTemplateY0End.Text = "90";
            // 
            // txtTestTemplateY0Start
            // 
            this.txtTestTemplateY0Start.Location = new System.Drawing.Point(40, 130);
            this.txtTestTemplateY0Start.Name = "txtTestTemplateY0Start";
            this.txtTestTemplateY0Start.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateY0Start.TabIndex = 28;
            this.txtTestTemplateY0Start.Text = "40";
            // 
            // txtTestTemplateAStep
            // 
            this.txtTestTemplateAStep.Location = new System.Drawing.Point(136, 156);
            this.txtTestTemplateAStep.Name = "txtTestTemplateAStep";
            this.txtTestTemplateAStep.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateAStep.TabIndex = 33;
            this.txtTestTemplateAStep.Text = "3";
            // 
            // txtTestTemplateAEnd
            // 
            this.txtTestTemplateAEnd.Location = new System.Drawing.Point(88, 156);
            this.txtTestTemplateAEnd.Name = "txtTestTemplateAEnd";
            this.txtTestTemplateAEnd.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateAEnd.TabIndex = 32;
            this.txtTestTemplateAEnd.Text = "65";
            // 
            // txtTestTemplateAStart
            // 
            this.txtTestTemplateAStart.Location = new System.Drawing.Point(40, 156);
            this.txtTestTemplateAStart.Name = "txtTestTemplateAStart";
            this.txtTestTemplateAStart.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateAStart.TabIndex = 31;
            this.txtTestTemplateAStart.Text = "50";
            // 
            // txtTestTemplateBStep
            // 
            this.txtTestTemplateBStep.Location = new System.Drawing.Point(136, 182);
            this.txtTestTemplateBStep.Name = "txtTestTemplateBStep";
            this.txtTestTemplateBStep.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateBStep.TabIndex = 36;
            this.txtTestTemplateBStep.Text = "3";
            // 
            // txtTestTemplateBEnd
            // 
            this.txtTestTemplateBEnd.Location = new System.Drawing.Point(88, 182);
            this.txtTestTemplateBEnd.Name = "txtTestTemplateBEnd";
            this.txtTestTemplateBEnd.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateBEnd.TabIndex = 35;
            this.txtTestTemplateBEnd.Text = "60";
            // 
            // txtTestTemplateBStart
            // 
            this.txtTestTemplateBStart.Location = new System.Drawing.Point(40, 182);
            this.txtTestTemplateBStart.Name = "txtTestTemplateBStart";
            this.txtTestTemplateBStart.Size = new System.Drawing.Size(42, 20);
            this.txtTestTemplateBStart.TabIndex = 34;
            this.txtTestTemplateBStart.Text = "30";
            // 
            // btnTestTemplateToForm
            // 
            this.btnTestTemplateToForm.Location = new System.Drawing.Point(7, 209);
            this.btnTestTemplateToForm.Name = "btnTestTemplateToForm";
            this.btnTestTemplateToForm.Size = new System.Drawing.Size(75, 23);
            this.btnTestTemplateToForm.TabIndex = 37;
            this.btnTestTemplateToForm.Text = "Test";
            this.btnTestTemplateToForm.UseVisualStyleBackColor = true;
            this.btnTestTemplateToForm.Click += new System.EventHandler(this.btnTestTemplateToForm_Click);
            // 
            // lbTemplates
            // 
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.Location = new System.Drawing.Point(7, 233);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(176, 69);
            this.lbTemplates.TabIndex = 38;
            this.lbTemplates.SelectedIndexChanged += new System.EventHandler(this.lbTemplates_SelectedIndexChanged);
            // 
            // btnTemplateOrderByRate
            // 
            this.btnTemplateOrderByRate.Location = new System.Drawing.Point(7, 306);
            this.btnTemplateOrderByRate.Name = "btnTemplateOrderByRate";
            this.btnTemplateOrderByRate.Size = new System.Drawing.Size(55, 23);
            this.btnTemplateOrderByRate.TabIndex = 39;
            this.btnTemplateOrderByRate.Text = "By Rate";
            this.btnTemplateOrderByRate.UseVisualStyleBackColor = true;
            this.btnTemplateOrderByRate.Click += new System.EventHandler(this.btnTemplateOrderByRate_Click);
            // 
            // btnTemplateOrderByCount
            // 
            this.btnTemplateOrderByCount.Location = new System.Drawing.Point(65, 306);
            this.btnTemplateOrderByCount.Name = "btnTemplateOrderByCount";
            this.btnTemplateOrderByCount.Size = new System.Drawing.Size(65, 23);
            this.btnTemplateOrderByCount.TabIndex = 40;
            this.btnTemplateOrderByCount.Text = "By Count";
            this.btnTemplateOrderByCount.UseVisualStyleBackColor = true;
            this.btnTemplateOrderByCount.Click += new System.EventHandler(this.btnTemplateOrderByCount_Click);
            // 
            // lblTemplateMinCount
            // 
            this.lblTemplateMinCount.AutoSize = true;
            this.lblTemplateMinCount.Location = new System.Drawing.Point(12, 333);
            this.lblTemplateMinCount.Name = "lblTemplateMinCount";
            this.lblTemplateMinCount.Size = new System.Drawing.Size(58, 13);
            this.lblTemplateMinCount.TabIndex = 41;
            this.lblTemplateMinCount.Text = "Min Count:";
            // 
            // txtTemplateMinCount
            // 
            this.txtTemplateMinCount.Location = new System.Drawing.Point(68, 330);
            this.txtTemplateMinCount.Name = "txtTemplateMinCount";
            this.txtTemplateMinCount.Size = new System.Drawing.Size(62, 20);
            this.txtTemplateMinCount.TabIndex = 42;
            this.txtTemplateMinCount.Text = "300";
            // 
            // btnTemplateRemoveByMinCount
            // 
            this.btnTemplateRemoveByMinCount.Location = new System.Drawing.Point(136, 327);
            this.btnTemplateRemoveByMinCount.Name = "btnTemplateRemoveByMinCount";
            this.btnTemplateRemoveByMinCount.Size = new System.Drawing.Size(47, 23);
            this.btnTemplateRemoveByMinCount.TabIndex = 43;
            this.btnTemplateRemoveByMinCount.Text = "Cut";
            this.btnTemplateRemoveByMinCount.UseVisualStyleBackColor = true;
            this.btnTemplateRemoveByMinCount.Click += new System.EventHandler(this.btnTemplateRemoveByMinCount_Click);
            // 
            // btnTemplateRemoveOutborders
            // 
            this.btnTemplateRemoveOutborders.Location = new System.Drawing.Point(136, 306);
            this.btnTemplateRemoveOutborders.Name = "btnTemplateRemoveOutborders";
            this.btnTemplateRemoveOutborders.Size = new System.Drawing.Size(47, 23);
            this.btnTemplateRemoveOutborders.TabIndex = 44;
            this.btnTemplateRemoveOutborders.Text = "Out";
            this.btnTemplateRemoveOutborders.UseVisualStyleBackColor = true;
            this.btnTemplateRemoveOutborders.Click += new System.EventHandler(this.btnTemplateRemoveOutborders_Click);
            // 
            // ShapeInfoLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 377);
            this.Controls.Add(this.pnlEllipticalTemplate);
            this.Controls.Add(this.pnlContours);
            this.Controls.Add(this.pnlTest);
            this.Name = "ShapeInfoLib";
            this.Text = "ShapeInfoLib";
            this.pnlTest.ResumeLayout(false);
            this.pnlTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.pnlContours.ResumeLayout(false);
            this.pnlContours.PerformLayout();
            this.pnlEllipticalTemplate.ResumeLayout(false);
            this.pnlEllipticalTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.PictureBox pbTestImage;
        private System.Windows.Forms.Button btnLoadTestImage;
        private System.Windows.Forms.OpenFileDialog dlgLoadTestImage;
        private System.Windows.Forms.Button btnEqualizeTestImage;
        private System.Windows.Forms.Button btnSmoothMedian;
        private System.Windows.Forms.TextBox txtSmoothMedianSize;
        private System.Windows.Forms.Label lblSmoothMedianSize;
        private System.Windows.Forms.Button btnDetectEdges;
        private System.Windows.Forms.TextBox txtCannyEdgeThresh;
        private System.Windows.Forms.Label lblCannyEdgeThreshold;
        private System.Windows.Forms.TextBox txtCannyInitialThresh;
        private System.Windows.Forms.Label lblCannyInitialThresh;
        private System.Windows.Forms.Panel pnlContours;
        private System.Windows.Forms.ListBox lbContours;
        private System.Windows.Forms.Label lblContourDistance;
        private System.Windows.Forms.Label lblContourPoints;
        private System.Windows.Forms.Label lblContourCount;
        private System.Windows.Forms.TextBox txtContourMinArc;
        private System.Windows.Forms.Label lblContourMinArc;
        private System.Windows.Forms.Button btnShowContours;
        private System.Windows.Forms.Button btnRemoveContoursByMinArc;
        private System.Windows.Forms.Button btnDivideContours;
        private System.Windows.Forms.Panel pnlEllipticalTemplate;
        private System.Windows.Forms.TextBox txtTemplateX0;
        private System.Windows.Forms.Label lblTemplateX0;
        private System.Windows.Forms.TextBox txtTemplateY0;
        private System.Windows.Forms.Label lblTemplateY0;
        private System.Windows.Forms.Label lblTemplateN;
        private System.Windows.Forms.Label lblTemplateG;
        private System.Windows.Forms.TextBox txtTemplateB;
        private System.Windows.Forms.Label lblTemplateB;
        private System.Windows.Forms.TextBox txtTemplateA;
        private System.Windows.Forms.Label lblTemplateA;
        private System.Windows.Forms.Button btnTemplateFind;
        private System.Windows.Forms.Label lblTemplateRate;
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
        private System.Windows.Forms.Button btnTestTemplate;
        private System.Windows.Forms.SaveFileDialog dlgSaveTestTemplate;
        private System.Windows.Forms.ListBox lbTemplates;
        private System.Windows.Forms.Button btnTestTemplateToForm;
        private System.Windows.Forms.Button btnTemplateOrderByCount;
        private System.Windows.Forms.Button btnTemplateOrderByRate;
        private System.Windows.Forms.Button btnTemplateRemoveByMinCount;
        private System.Windows.Forms.TextBox txtTemplateMinCount;
        private System.Windows.Forms.Label lblTemplateMinCount;
        private System.Windows.Forms.Button btnTemplateRemoveOutborders;
    }
}