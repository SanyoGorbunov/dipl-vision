namespace SkinDetection
{
    partial class Start
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
            this.btnFaceColorLib = new System.Windows.Forms.Button();
            this.lblDetection = new System.Windows.Forms.Label();
            this.btnShapeInfo = new System.Windows.Forms.Button();
            this.lblUtils = new System.Windows.Forms.Label();
            this.btnDatabaseUtil = new System.Windows.Forms.Button();
            this.btnFaceColorModels = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnEllipseCutter = new System.Windows.Forms.Button();
            this.btnTestInclination = new System.Windows.Forms.Button();
            this.btnTestEdgeLinking = new System.Windows.Forms.Button();
            this.btnFloodFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFaceColorLib
            // 
            this.btnFaceColorLib.Location = new System.Drawing.Point(15, 51);
            this.btnFaceColorLib.Name = "btnFaceColorLib";
            this.btnFaceColorLib.Size = new System.Drawing.Size(109, 54);
            this.btnFaceColorLib.TabIndex = 0;
            this.btnFaceColorLib.Text = "Метод на основі кольору шкіри";
            this.btnFaceColorLib.UseVisualStyleBackColor = true;
            this.btnFaceColorLib.Click += new System.EventHandler(this.btnFaceColorLib_Click);
            // 
            // lblDetection
            // 
            this.lblDetection.AutoSize = true;
            this.lblDetection.Location = new System.Drawing.Point(34, 25);
            this.lblDetection.Name = "lblDetection";
            this.lblDetection.Size = new System.Drawing.Size(65, 13);
            this.lblDetection.TabIndex = 1;
            this.lblDetection.Text = "Алгоритми:";
            // 
            // btnShapeInfo
            // 
            this.btnShapeInfo.Location = new System.Drawing.Point(15, 110);
            this.btnShapeInfo.Name = "btnShapeInfo";
            this.btnShapeInfo.Size = new System.Drawing.Size(110, 54);
            this.btnShapeInfo.TabIndex = 2;
            this.btnShapeInfo.Text = "Метод на основі контурів зображення";
            this.btnShapeInfo.UseVisualStyleBackColor = true;
            this.btnShapeInfo.Click += new System.EventHandler(this.btnShapeInfo_Click);
            // 
            // lblUtils
            // 
            this.lblUtils.AutoSize = true;
            this.lblUtils.Location = new System.Drawing.Point(181, 25);
            this.lblUtils.Name = "lblUtils";
            this.lblUtils.Size = new System.Drawing.Size(99, 13);
            this.lblUtils.TabIndex = 3;
            this.lblUtils.Text = "Додаткові форми:";
            // 
            // btnDatabaseUtil
            // 
            this.btnDatabaseUtil.Location = new System.Drawing.Point(171, 51);
            this.btnDatabaseUtil.Name = "btnDatabaseUtil";
            this.btnDatabaseUtil.Size = new System.Drawing.Size(110, 52);
            this.btnDatabaseUtil.TabIndex = 4;
            this.btnDatabaseUtil.Text = "Створення тестових наборів";
            this.btnDatabaseUtil.UseVisualStyleBackColor = true;
            this.btnDatabaseUtil.Click += new System.EventHandler(this.btnDatabaseUtil_Click);
            // 
            // btnFaceColorModels
            // 
            this.btnFaceColorModels.Location = new System.Drawing.Point(171, 109);
            this.btnFaceColorModels.Name = "btnFaceColorModels";
            this.btnFaceColorModels.Size = new System.Drawing.Size(109, 54);
            this.btnFaceColorModels.TabIndex = 5;
            this.btnFaceColorModels.Text = "Перевірка кольорових моделей";
            this.btnFaceColorModels.UseVisualStyleBackColor = true;
            this.btnFaceColorModels.Click += new System.EventHandler(this.btnFaceColorModels_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(34, 210);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(69, 13);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "Тестування:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(16, 230);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(109, 54);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Тестування";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnEllipseCutter
            // 
            this.btnEllipseCutter.Location = new System.Drawing.Point(170, 169);
            this.btnEllipseCutter.Name = "btnEllipseCutter";
            this.btnEllipseCutter.Size = new System.Drawing.Size(110, 54);
            this.btnEllipseCutter.TabIndex = 8;
            this.btnEllipseCutter.Text = "Вирізання еліпсів";
            this.btnEllipseCutter.UseVisualStyleBackColor = true;
            this.btnEllipseCutter.Click += new System.EventHandler(this.btnEllipseCutter_Click);
            // 
            // btnTestInclination
            // 
            this.btnTestInclination.Location = new System.Drawing.Point(287, 51);
            this.btnTestInclination.Name = "btnTestInclination";
            this.btnTestInclination.Size = new System.Drawing.Size(110, 52);
            this.btnTestInclination.TabIndex = 9;
            this.btnTestInclination.Text = "Перевірка відхилення";
            this.btnTestInclination.UseVisualStyleBackColor = true;
            this.btnTestInclination.Click += new System.EventHandler(this.btnTestInclination_Click);
            // 
            // btnTestEdgeLinking
            // 
            this.btnTestEdgeLinking.Location = new System.Drawing.Point(171, 231);
            this.btnTestEdgeLinking.Name = "btnTestEdgeLinking";
            this.btnTestEdgeLinking.Size = new System.Drawing.Size(110, 52);
            this.btnTestEdgeLinking.TabIndex = 10;
            this.btnTestEdgeLinking.Text = "Перевірка з\'єднання границь";
            this.btnTestEdgeLinking.UseVisualStyleBackColor = true;
            this.btnTestEdgeLinking.Click += new System.EventHandler(this.btnTestEdgeLinking_Click);
            // 
            // btnFloodFill
            // 
            this.btnFloodFill.Location = new System.Drawing.Point(287, 111);
            this.btnFloodFill.Name = "btnFloodFill";
            this.btnFloodFill.Size = new System.Drawing.Size(110, 52);
            this.btnFloodFill.TabIndex = 11;
            this.btnFloodFill.Text = "Перевірка алгоритму заповнення";
            this.btnFloodFill.UseVisualStyleBackColor = true;
            this.btnFloodFill.Click += new System.EventHandler(this.btnFloodFill_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 301);
            this.Controls.Add(this.btnFloodFill);
            this.Controls.Add(this.btnTestEdgeLinking);
            this.Controls.Add(this.btnTestInclination);
            this.Controls.Add(this.btnEllipseCutter);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnFaceColorModels);
            this.Controls.Add(this.btnDatabaseUtil);
            this.Controls.Add(this.lblUtils);
            this.Controls.Add(this.btnShapeInfo);
            this.Controls.Add(this.lblDetection);
            this.Controls.Add(this.btnFaceColorLib);
            this.Name = "Start";
            this.Text = "Навігація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFaceColorLib;
        private System.Windows.Forms.Label lblDetection;
        private System.Windows.Forms.Button btnShapeInfo;
        private System.Windows.Forms.Label lblUtils;
        private System.Windows.Forms.Button btnDatabaseUtil;
        private System.Windows.Forms.Button btnFaceColorModels;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnEllipseCutter;
        private System.Windows.Forms.Button btnTestInclination;
        private System.Windows.Forms.Button btnTestEdgeLinking;
        private System.Windows.Forms.Button btnFloodFill;
    }
}