namespace Практическая_4
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.labelCols = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnGenerate);
            this.panelTop.Controls.Add(this.txtMax);
            this.panelTop.Controls.Add(this.labelMax);
            this.panelTop.Controls.Add(this.txtMin);
            this.panelTop.Controls.Add(this.labelMin);
            this.panelTop.Controls.Add(this.txtCols);
            this.panelTop.Controls.Add(this.labelCols);
            this.panelTop.Controls.Add(this.txtRows);
            this.panelTop.Controls.Add(this.labelRows);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(650, 80);
            this.panelTop.TabIndex = 0;
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(15, 20);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(46, 13);
            this.labelRows.Text = "Строки:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(70, 17);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(40, 20);
            this.txtRows.TabIndex = 1;
            // 
            // labelCols
            // 
            this.labelCols.AutoSize = true;
            this.labelCols.Location = new System.Drawing.Point(120, 20);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(54, 13);
            this.labelCols.Text = "Столбцы:";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(180, 17);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(40, 20);
            this.txtCols.TabIndex = 2;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(15, 50);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(29, 13);
            this.labelMin.Text = "Мин:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(50, 47);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(60, 20);
            this.txtMin.TabIndex = 3;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(120, 50);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(35, 13);
            this.labelMax.Text = "Макс:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(160, 47);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(60, 20);
            this.txtMax.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(250, 25);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 30);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Создать матрицу";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(20, 90);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(62, 13);
            this.lblMatrix.Text = "Матрица:";
            // 
            // txtMatrix
            // 
            this.txtMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMatrix.Location = new System.Drawing.Point(20, 110);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix.Size = new System.Drawing.Size(250, 250);
            this.txtMatrix.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(290, 90);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 13);
            this.lblResult.Text = "Результат:";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(290, 110);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(340, 250);
            this.txtResult.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.lblMatrix);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "Практическая 4 - Матрицы";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label labelCols;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}