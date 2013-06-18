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
            this.lblConfigTraceLines = new System.Windows.Forms.Label();
            this.lblConfiTraceDist = new System.Windows.Forms.Label();
            this.btnConfigTraceLines = new System.Windows.Forms.Button();
            this.txtConfigTraceDist = new System.Windows.Forms.TextBox();
            this.txtConfigTraceAngles = new System.Windows.Forms.TextBox();
            this.lblConfigTraceAngles = new System.Windows.Forms.Label();
            this.btnLoadTraceLines = new System.Windows.Forms.Button();
            this.btnSaveTraceLines = new System.Windows.Forms.Button();
            this.dlgLoadTraceLines = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveTraceLines = new System.Windows.Forms.SaveFileDialog();
            this.txtConfigTraceImgWidth = new System.Windows.Forms.TextBox();
            this.lblConfigTraceImgWidth = new System.Windows.Forms.Label();
            this.txtConfigTraceImgHeight = new System.Windows.Forms.TextBox();
            this.lblConfigTraceImgHeight = new System.Windows.Forms.Label();
            this.pnlTestImage = new System.Windows.Forms.Panel();
            this.lblLoadTestImage = new System.Windows.Forms.Label();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.btnLoadTestImage = new System.Windows.Forms.Button();
            this.dlgLoadTestImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlTransformImage = new System.Windows.Forms.Panel();
            this.btnTransformImage = new System.Windows.Forms.Button();
            this.pbTrasformImage = new System.Windows.Forms.PictureBox();
            this.pnlConfigTraceLines.SuspendLayout();
            this.pnlTestImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.pnlTransformImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrasformImage)).BeginInit();
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
            // lblConfigTraceLines
            // 
            this.lblConfigTraceLines.AutoSize = true;
            this.lblConfigTraceLines.Location = new System.Drawing.Point(0, 0);
            this.lblConfigTraceLines.Name = "lblConfigTraceLines";
            this.lblConfigTraceLines.Size = new System.Drawing.Size(166, 13);
            this.lblConfigTraceLines.TabIndex = 0;
            this.lblConfigTraceLines.Text = "Налаштувати отримання слідів:";
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
            // btnConfigTraceLines
            // 
            this.btnConfigTraceLines.Location = new System.Drawing.Point(87, 123);
            this.btnConfigTraceLines.Name = "btnConfigTraceLines";
            this.btnConfigTraceLines.Size = new System.Drawing.Size(69, 23);
            this.btnConfigTraceLines.TabIndex = 2;
            this.btnConfigTraceLines.Text = "Process";
            this.btnConfigTraceLines.UseVisualStyleBackColor = true;
            this.btnConfigTraceLines.Click += new System.EventHandler(this.btnConfigTraceLines_Click);
            // 
            // txtConfigTraceDist
            // 
            this.txtConfigTraceDist.Location = new System.Drawing.Point(190, 24);
            this.txtConfigTraceDist.Name = "txtConfigTraceDist";
            this.txtConfigTraceDist.Size = new System.Drawing.Size(47, 20);
            this.txtConfigTraceDist.TabIndex = 3;
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
            this.lblConfigTraceAngles.Size = new System.Drawing.Size(93, 13);
            this.lblConfigTraceAngles.TabIndex = 4;
            this.lblConfigTraceAngles.Text = "Number of angles:";
            // 
            // btnLoadTraceLines
            // 
            this.btnLoadTraceLines.Location = new System.Drawing.Point(6, 123);
            this.btnLoadTraceLines.Name = "btnLoadTraceLines";
            this.btnLoadTraceLines.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTraceLines.TabIndex = 7;
            this.btnLoadTraceLines.Text = "Load";
            this.btnLoadTraceLines.UseVisualStyleBackColor = true;
            this.btnLoadTraceLines.Click += new System.EventHandler(this.btnLoadTraceLines_Click);
            // 
            // btnSaveTraceLines
            // 
            this.btnSaveTraceLines.Location = new System.Drawing.Point(162, 123);
            this.btnSaveTraceLines.Name = "btnSaveTraceLines";
            this.btnSaveTraceLines.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTraceLines.TabIndex = 8;
            this.btnSaveTraceLines.Text = "Save";
            this.btnSaveTraceLines.UseVisualStyleBackColor = true;
            this.btnSaveTraceLines.Click += new System.EventHandler(this.btnSaveTraceLines_Click);
            // 
            // dlgLoadTraceLines
            // 
            this.dlgLoadTraceLines.FileName = "openFileDialog1";
            this.dlgLoadTraceLines.InitialDirectory = "C:\\Users\\Sanyo\\Documents\\GitHub\\univer-projects\\MasterDiploma\\MasterDiploma\\Trace" +
                "Transform";
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
            this.lblConfigTraceImgWidth.Size = new System.Drawing.Size(90, 13);
            this.lblConfigTraceImgWidth.TabIndex = 11;
            this.lblConfigTraceImgWidth.Text = "Test image width:";
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
            this.lblConfigTraceImgHeight.Size = new System.Drawing.Size(94, 13);
            this.lblConfigTraceImgHeight.TabIndex = 9;
            this.lblConfigTraceImgHeight.Text = "Test image height:";
            // 
            // pnlTestImage
            // 
            this.pnlTestImage.Controls.Add(this.btnLoadTestImage);
            this.pnlTestImage.Controls.Add(this.pbTestImage);
            this.pnlTestImage.Controls.Add(this.lblLoadTestImage);
            this.pnlTestImage.Location = new System.Drawing.Point(258, 10);
            this.pnlTestImage.Name = "pnlTestImage";
            this.pnlTestImage.Size = new System.Drawing.Size(231, 263);
            this.pnlTestImage.TabIndex = 1;
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
            // pbTestImage
            // 
            this.pbTestImage.Location = new System.Drawing.Point(29, 42);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(180, 200);
            this.pbTestImage.TabIndex = 1;
            this.pbTestImage.TabStop = false;
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
            // pbTrasformImage
            // 
            this.pbTrasformImage.Location = new System.Drawing.Point(3, 42);
            this.pbTrasformImage.Name = "pbTrasformImage";
            this.pbTrasformImage.Size = new System.Drawing.Size(490, 200);
            this.pbTrasformImage.TabIndex = 1;
            this.pbTrasformImage.TabStop = false;
            // 
            // TestTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 377);
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
    }
}