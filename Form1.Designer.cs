namespace ImageResizerAndLogoAdder
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
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.IncludeSubDirsCheck = new System.Windows.Forms.CheckBox();
            this.Xaxis = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Yaxis = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TemplateChooser = new System.Windows.Forms.OpenFileDialog();
            this.ChooseMasterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.XaxisPos = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.yAxisPos = new System.Windows.Forms.NumericUpDown();
            this.WarningMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Xaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XaxisPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAxisPos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertBtn.Location = new System.Drawing.Point(478, 370);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(115, 42);
            this.ConvertBtn.TabIndex = 0;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This utility will allow you to place a folder of images over a template file and " +
    "save a new copy for each file in the folder.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Converting the files will save a copy of the files in the application directory. " +
    "It will not affect the original files.";
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(12, 167);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(155, 54);
            this.ChooseBtn.TabIndex = 3;
            this.ChooseBtn.Text = "Choose Input Images Folder";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // IncludeSubDirsCheck
            // 
            this.IncludeSubDirsCheck.AutoSize = true;
            this.IncludeSubDirsCheck.Location = new System.Drawing.Point(173, 204);
            this.IncludeSubDirsCheck.Name = "IncludeSubDirsCheck";
            this.IncludeSubDirsCheck.Size = new System.Drawing.Size(140, 17);
            this.IncludeSubDirsCheck.TabIndex = 6;
            this.IncludeSubDirsCheck.Text = "Include Sub-directories?";
            this.IncludeSubDirsCheck.UseVisualStyleBackColor = true;
            // 
            // Xaxis
            // 
            this.Xaxis.Location = new System.Drawing.Point(20, 64);
            this.Xaxis.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.Xaxis.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Xaxis.Name = "Xaxis";
            this.Xaxis.Size = new System.Drawing.Size(68, 20);
            this.Xaxis.TabIndex = 7;
            this.Xaxis.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X-axis size in pixels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y-axis size in pixels";
            // 
            // Yaxis
            // 
            this.Yaxis.Location = new System.Drawing.Point(134, 64);
            this.Yaxis.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.Yaxis.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Yaxis.Name = "Yaxis";
            this.Yaxis.Size = new System.Drawing.Size(68, 20);
            this.Yaxis.TabIndex = 9;
            this.Yaxis.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // TemplateChooser
            // 
            this.TemplateChooser.FileName = "openFileDialog1";
            // 
            // ChooseMasterBtn
            // 
            this.ChooseMasterBtn.Location = new System.Drawing.Point(12, 97);
            this.ChooseMasterBtn.Name = "ChooseMasterBtn";
            this.ChooseMasterBtn.Size = new System.Drawing.Size(155, 54);
            this.ChooseMasterBtn.TabIndex = 13;
            this.ChooseMasterBtn.Text = "Choose Master Image";
            this.ChooseMasterBtn.UseVisualStyleBackColor = true;
            this.ChooseMasterBtn.Click += new System.EventHandler(this.ChooseLogoBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "X-axis Start Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "X";
            // 
            // XaxisPos
            // 
            this.XaxisPos.Location = new System.Drawing.Point(20, 118);
            this.XaxisPos.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.XaxisPos.Name = "XaxisPos";
            this.XaxisPos.Size = new System.Drawing.Size(68, 20);
            this.XaxisPos.TabIndex = 20;
            this.XaxisPos.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Y-axis Start Position";
            // 
            // yAxisPos
            // 
            this.yAxisPos.Location = new System.Drawing.Point(134, 118);
            this.yAxisPos.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.yAxisPos.Name = "yAxisPos";
            this.yAxisPos.Size = new System.Drawing.Size(68, 20);
            this.yAxisPos.TabIndex = 22;
            this.yAxisPos.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // WarningMessage
            // 
            this.WarningMessage.AutoSize = true;
            this.WarningMessage.Location = new System.Drawing.Point(313, 118);
            this.WarningMessage.Name = "WarningMessage";
            this.WarningMessage.Size = new System.Drawing.Size(0, 13);
            this.WarningMessage.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Yaxis);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Xaxis);
            this.groupBox1.Controls.Add(this.XaxisPos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.yAxisPos);
            this.groupBox1.Location = new System.Drawing.Point(15, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 171);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Images Resize Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "These settings are for the images being placed on the template";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WarningMessage);
            this.Controls.Add(this.ChooseMasterBtn);
            this.Controls.Add(this.IncludeSubDirsCheck);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Add Images to Master Template";
            ((System.ComponentModel.ISupportInitialize)(this.Xaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XaxisPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAxisPos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog InputFolder;
        private System.Windows.Forms.Button ChooseBtn;
        private System.Windows.Forms.CheckBox IncludeSubDirsCheck;
        private System.Windows.Forms.NumericUpDown Xaxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Yaxis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog TemplateChooser;
        private System.Windows.Forms.Button ChooseMasterBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown XaxisPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown yAxisPos;
        private System.Windows.Forms.Label WarningMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
    }
}

