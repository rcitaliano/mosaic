namespace Mosaic
{
    partial class Form1
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
            this.tabWizard = new System.Windows.Forms.TabControl();
            this.tpSelectPhotos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.tpShowPhotos = new System.Windows.Forms.TabPage();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tpSelectBaseImage = new System.Windows.Forms.TabPage();
            this.tlpBaseImage = new System.Windows.Forms.TableLayoutPanel();
            this.btnBaseImage = new System.Windows.Forms.Button();
            this.pbBaseImage = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpResultImage = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.pbResultImage = new System.Windows.Forms.PictureBox();
            this.pbResultImageBW = new System.Windows.Forms.PictureBox();
            this.tabWizard.SuspendLayout();
            this.tpSelectPhotos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpShowPhotos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpSelectBaseImage.SuspendLayout();
            this.tlpBaseImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseImage)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tlpResultImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImageBW)).BeginInit();
            this.SuspendLayout();
            // 
            // tabWizard
            // 
            this.tabWizard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.tabWizard, 2);
            this.tabWizard.Controls.Add(this.tpSelectPhotos);
            this.tabWizard.Controls.Add(this.tpShowPhotos);
            this.tabWizard.Controls.Add(this.tpSelectBaseImage);
            this.tabWizard.Controls.Add(this.tabPage1);
            this.tabWizard.Location = new System.Drawing.Point(3, 3);
            this.tabWizard.Name = "tabWizard";
            this.tabWizard.SelectedIndex = 0;
            this.tabWizard.Size = new System.Drawing.Size(469, 321);
            this.tabWizard.TabIndex = 0;
            this.tabWizard.SelectedIndexChanged += new System.EventHandler(this.tabWizard_SelectedIndexChanged);
            // 
            // tpSelectPhotos
            // 
            this.tpSelectPhotos.Controls.Add(this.tableLayoutPanel1);
            this.tpSelectPhotos.Location = new System.Drawing.Point(4, 22);
            this.tpSelectPhotos.Name = "tpSelectPhotos";
            this.tpSelectPhotos.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelectPhotos.Size = new System.Drawing.Size(461, 295);
            this.tpSelectPhotos.TabIndex = 0;
            this.tpSelectPhotos.Text = "tabPage1";
            this.tpSelectPhotos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFolder, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 282);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 141);
            this.label1.TabIndex = 0;
            this.label1.Text = "Where are the pictures?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtFolder, 2);
            this.txtFolder.Location = new System.Drawing.Point(3, 144);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(442, 20);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.Text = "Click here to select a folder";
            this.txtFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFolder_MouseClick);
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // tpShowPhotos
            // 
            this.tpShowPhotos.Controls.Add(this.listViewImages);
            this.tpShowPhotos.Location = new System.Drawing.Point(4, 22);
            this.tpShowPhotos.Name = "tpShowPhotos";
            this.tpShowPhotos.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowPhotos.Size = new System.Drawing.Size(461, 295);
            this.tpShowPhotos.TabIndex = 1;
            this.tpShowPhotos.Text = "tabPage2";
            this.tpShowPhotos.UseVisualStyleBackColor = true;
            // 
            // listViewImages
            // 
            this.listViewImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewImages.Location = new System.Drawing.Point(7, 7);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(448, 282);
            this.listViewImages.TabIndex = 0;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tabWizard, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNext, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPrevious, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.96989F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.03011F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 386);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(240, 330);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(232, 53);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(3, 330);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(231, 53);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Back";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tpSelectBaseImage
            // 
            this.tpSelectBaseImage.Controls.Add(this.tlpBaseImage);
            this.tpSelectBaseImage.Location = new System.Drawing.Point(4, 22);
            this.tpSelectBaseImage.Name = "tpSelectBaseImage";
            this.tpSelectBaseImage.Size = new System.Drawing.Size(461, 295);
            this.tpSelectBaseImage.TabIndex = 2;
            this.tpSelectBaseImage.Text = "tabPage1";
            this.tpSelectBaseImage.UseVisualStyleBackColor = true;
            // 
            // tlpBaseImage
            // 
            this.tlpBaseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBaseImage.ColumnCount = 1;
            this.tlpBaseImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBaseImage.Controls.Add(this.btnBaseImage, 0, 0);
            this.tlpBaseImage.Controls.Add(this.pbBaseImage, 0, 1);
            this.tlpBaseImage.Location = new System.Drawing.Point(4, 4);
            this.tlpBaseImage.Name = "tlpBaseImage";
            this.tlpBaseImage.RowCount = 2;
            this.tlpBaseImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tlpBaseImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlpBaseImage.Size = new System.Drawing.Size(454, 288);
            this.tlpBaseImage.TabIndex = 0;
            // 
            // btnBaseImage
            // 
            this.btnBaseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaseImage.Location = new System.Drawing.Point(3, 3);
            this.btnBaseImage.Name = "btnBaseImage";
            this.btnBaseImage.Size = new System.Drawing.Size(448, 76);
            this.btnBaseImage.TabIndex = 0;
            this.btnBaseImage.Text = "Click here to select a base image";
            this.btnBaseImage.UseVisualStyleBackColor = true;
            this.btnBaseImage.Click += new System.EventHandler(this.btnBaseImage_Click);
            // 
            // pbBaseImage
            // 
            this.pbBaseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBaseImage.Location = new System.Drawing.Point(3, 85);
            this.pbBaseImage.Name = "pbBaseImage";
            this.pbBaseImage.Size = new System.Drawing.Size(448, 200);
            this.pbBaseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBaseImage.TabIndex = 1;
            this.pbBaseImage.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpResultImage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(461, 295);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tpResult";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpResultImage
            // 
            this.tlpResultImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpResultImage.ColumnCount = 2;
            this.tlpResultImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultImage.Controls.Add(this.btnSaveImage, 0, 0);
            this.tlpResultImage.Controls.Add(this.pbResultImage, 0, 1);
            this.tlpResultImage.Controls.Add(this.pbResultImageBW, 1, 1);
            this.tlpResultImage.Location = new System.Drawing.Point(4, 4);
            this.tlpResultImage.Name = "tlpResultImage";
            this.tlpResultImage.RowCount = 2;
            this.tlpResultImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tlpResultImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlpResultImage.Size = new System.Drawing.Size(454, 288);
            this.tlpResultImage.TabIndex = 0;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpResultImage.SetColumnSpan(this.btnSaveImage, 2);
            this.btnSaveImage.Location = new System.Drawing.Point(3, 3);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(448, 76);
            this.btnSaveImage.TabIndex = 0;
            this.btnSaveImage.Text = "Save images";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // pbResultImage
            // 
            this.pbResultImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbResultImage.Location = new System.Drawing.Point(3, 85);
            this.pbResultImage.Name = "pbResultImage";
            this.pbResultImage.Size = new System.Drawing.Size(221, 200);
            this.pbResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResultImage.TabIndex = 1;
            this.pbResultImage.TabStop = false;
            // 
            // pbResultImageBW
            // 
            this.pbResultImageBW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbResultImageBW.Location = new System.Drawing.Point(230, 85);
            this.pbResultImageBW.Name = "pbResultImageBW";
            this.pbResultImageBW.Size = new System.Drawing.Size(221, 200);
            this.pbResultImageBW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResultImageBW.TabIndex = 2;
            this.pbResultImageBW.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 410);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabWizard.ResumeLayout(false);
            this.tpSelectPhotos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpShowPhotos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tpSelectBaseImage.ResumeLayout(false);
            this.tlpBaseImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseImage)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tlpResultImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImageBW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabWizard;
        private System.Windows.Forms.TabPage tpSelectPhotos;
        private System.Windows.Forms.TabPage tpShowPhotos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.TabPage tpSelectBaseImage;
        private System.Windows.Forms.TableLayoutPanel tlpBaseImage;
        private System.Windows.Forms.Button btnBaseImage;
        private System.Windows.Forms.PictureBox pbBaseImage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlpResultImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.PictureBox pbResultImage;
        private System.Windows.Forms.PictureBox pbResultImageBW;
    }
}

