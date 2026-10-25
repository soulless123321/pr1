namespace Практическая_2_1
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstOriginal = new System.Windows.Forms.ListBox();
            this.lstProcessed = new System.Windows.Forms.ListBox();
            this.labelOrig = new System.Windows.Forms.Label();
            this.labelProc = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop (Верхняя панель с настройками)
            // 
            this.panelTop.Controls.Add(this.btnGenerate);
            this.panelTop.Controls.Add(this.txtCount);
            this.panelTop.Controls.Add(this.labelCount);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(600, 60);
            this.panelTop.TabIndex = 0;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(20, 22);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(110, 13);
            this.labelCount.Text = "Кол-во элементов:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(140, 19);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(260, 17);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 25);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Сгенерировать список";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panelBottom (Нижняя панель с кнопкой удаления)
            // 
            this.panelBottom.Controls.Add(this.btnRemove);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 400);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(600, 50);
            this.panelBottom.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(200, 10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 30);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Удалить каждый второй";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // labelOrig
            // 
            this.labelOrig.AutoSize = true;
            this.labelOrig.Location = new System.Drawing.Point(20, 70);
            this.labelOrig.Name = "labelOrig";
            this.labelOrig.Size = new System.Drawing.Size(115, 13);
            this.labelOrig.Text = "Исходный список:";
            // 
            // lstOriginal
            // 
            this.lstOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstOriginal.FormattingEnabled = true;
            this.lstOriginal.Location = new System.Drawing.Point(20, 90);
            this.lstOriginal.Name = "lstOriginal";
            this.lstOriginal.Size = new System.Drawing.Size(260, 290);
            this.lstOriginal.TabIndex = 2;
            // 
            // labelProc
            // 
            this.labelProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProc.AutoSize = true;
            this.labelProc.Location = new System.Drawing.Point(320, 70);
            this.labelProc.Name = "labelProc";
            this.labelProc.Size = new System.Drawing.Size(132, 13);
            this.labelProc.Text = "Обработанный список:";
            // 
            // lstProcessed
            // 
            this.lstProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProcessed.FormattingEnabled = true;
            this.lstProcessed.Location = new System.Drawing.Point(320, 90);
            this.lstProcessed.Name = "lstProcessed";
            this.lstProcessed.Size = new System.Drawing.Size(260, 290);
            this.lstProcessed.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lstProcessed);
            this.Controls.Add(this.labelProc);
            this.Controls.Add(this.lstOriginal);
            this.Controls.Add(this.labelOrig);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "Практическая 2.1 - Списки";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstOriginal;
        private System.Windows.Forms.ListBox lstProcessed;
        private System.Windows.Forms.Label labelOrig;
        private System.Windows.Forms.Label labelProc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}