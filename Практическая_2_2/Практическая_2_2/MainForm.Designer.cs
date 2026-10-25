namespace Практическая_2_2
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnProcess);
            this.panelTop.Controls.Add(this.txtCount);
            this.panelTop.Controls.Add(this.labelCount);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(700, 60);
            this.panelTop.TabIndex = 0;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(20, 23);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(110, 13);
            this.labelCount.Text = "Кол-во покупок (n):";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(136, 20);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(50, 20);
            this.txtCount.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(200, 18);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(120, 25);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Обработать";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(20, 70);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(250, 13);
            this.labelInput.Text = "Введите строки (Покупатель Товар Кол-во):";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInput.Location = new System.Drawing.Point(20, 90);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(300, 300);
            this.txtInput.TabIndex = 3;
            // 
            // labelOutput
            // 
            this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(350, 70);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(62, 13);
            this.labelOutput.Text = "Результат:";
            // 
            // lstOutput
            // 
            this.lstOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(350, 90);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(330, 290);
            this.lstOutput.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "Практическая 2.2 - Словари";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}