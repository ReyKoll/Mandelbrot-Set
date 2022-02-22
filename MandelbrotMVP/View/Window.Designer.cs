
namespace MandelbrotMVP
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblYN = new System.Windows.Forms.Label();
            this.lblXN = new System.Windows.Forms.Label();
            this.lblY0 = new System.Windows.Forms.Label();
            this.lblX0 = new System.Windows.Forms.Label();
            this.txtYN = new System.Windows.Forms.TextBox();
            this.txtXN = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCanvas.Location = new System.Drawing.Point(-2, -1);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1200, 605);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btnDraw);
            this.gbSettings.Controls.Add(this.lblYN);
            this.gbSettings.Controls.Add(this.lblXN);
            this.gbSettings.Controls.Add(this.lblY0);
            this.gbSettings.Controls.Add(this.lblX0);
            this.gbSettings.Controls.Add(this.txtYN);
            this.gbSettings.Controls.Add(this.txtXN);
            this.gbSettings.Controls.Add(this.txtY0);
            this.gbSettings.Controls.Add(this.txtX0);
            this.gbSettings.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSettings.Location = new System.Drawing.Point(1037, 398);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(147, 189);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Границы фрактала";
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDraw.Location = new System.Drawing.Point(28, 151);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(93, 28);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Отобразить";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblYN
            // 
            this.lblYN.AutoSize = true;
            this.lblYN.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYN.Location = new System.Drawing.Point(88, 97);
            this.lblYN.Name = "lblYN";
            this.lblYN.Size = new System.Drawing.Size(24, 16);
            this.lblYN.TabIndex = 7;
            this.lblYN.Text = "YN";
            // 
            // lblXN
            // 
            this.lblXN.AutoSize = true;
            this.lblXN.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblXN.Location = new System.Drawing.Point(6, 97);
            this.lblXN.Name = "lblXN";
            this.lblXN.Size = new System.Drawing.Size(24, 16);
            this.lblXN.TabIndex = 6;
            this.lblXN.Text = "XN";
            // 
            // lblY0
            // 
            this.lblY0.AutoSize = true;
            this.lblY0.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY0.Location = new System.Drawing.Point(88, 48);
            this.lblY0.Name = "lblY0";
            this.lblY0.Size = new System.Drawing.Size(22, 16);
            this.lblY0.TabIndex = 5;
            this.lblY0.Text = "Y0";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX0.Location = new System.Drawing.Point(8, 45);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(22, 16);
            this.lblX0.TabIndex = 4;
            this.lblX0.Text = "X0";
            // 
            // txtYN
            // 
            this.txtYN.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtYN.Location = new System.Drawing.Point(91, 113);
            this.txtYN.Name = "txtYN";
            this.txtYN.Size = new System.Drawing.Size(50, 21);
            this.txtYN.TabIndex = 3;
            this.txtYN.Tag = "4.0";
            // 
            // txtXN
            // 
            this.txtXN.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXN.Location = new System.Drawing.Point(6, 113);
            this.txtXN.Name = "txtXN";
            this.txtXN.Size = new System.Drawing.Size(50, 21);
            this.txtXN.TabIndex = 2;
            this.txtXN.Tag = "2.0";
            // 
            // txtY0
            // 
            this.txtY0.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtY0.Location = new System.Drawing.Point(91, 64);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(50, 21);
            this.txtY0.TabIndex = 1;
            this.txtY0.Tag = "4.0";
            // 
            // txtX0
            // 
            this.txtX0.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX0.Location = new System.Drawing.Point(6, 64);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(50, 21);
            this.txtX0.TabIndex = 0;
            this.txtX0.Tag = "4.0";
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUndo.Location = new System.Drawing.Point(1102, 555);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(82, 32);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.Text = "Отменить";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1196, 599);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.pbCanvas);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фрактал Мандельброта";
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label lblYN;
        private System.Windows.Forms.Label lblXN;
        private System.Windows.Forms.Label lblY0;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.TextBox txtYN;
        private System.Windows.Forms.TextBox txtXN;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX0;
        public System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnUndo;
    }
}

