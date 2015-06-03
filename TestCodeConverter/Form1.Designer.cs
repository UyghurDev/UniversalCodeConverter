namespace CodeConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(13, 13);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(838, 165);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = resources.GetString("txtSource.Text");
            this.txtSource.MouseEnter += new System.EventHandler(this.txtSource_MouseEnter);
            this.txtSource.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSource_MouseMove);
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(13, 224);
            this.txtNew.Multiline = true;
            this.txtNew.Name = "txtNew";
            this.txtNew.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNew.Size = new System.Drawing.Size(838, 234);
            this.txtNew.TabIndex = 1;
            this.txtNew.MouseEnter += new System.EventHandler(this.txtNew_MouseEnter);
            this.txtNew.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtNew_MouseMove);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(198, 186);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 32);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cmbTables
            // 
            this.cmbTables.DisplayMember = "Author";
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(593, 189);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(219, 29);
            this.cmbTables.TabIndex = 3;
            this.cmbTables.ValueMember = "Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uyghur Software Developer Network";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "UyghurDev.net";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lab.UyghurDev.net";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(863, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtSource);
            this.Font = new System.Drawing.Font("Droid Naskh Shift Alt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Universal Code Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

