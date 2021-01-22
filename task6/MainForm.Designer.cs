
namespace Task6_15
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colourBox = new System.Windows.Forms.TextBox();
            this.qualityBox = new System.Windows.Forms.TextBox();
            this.coverColourBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orientationBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hasExamplesGrp = new System.Windows.Forms.GroupBox();
            this.noChoice = new System.Windows.Forms.RadioButton();
            this.yesChoice = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.notebooks = new System.Windows.Forms.DataGridView();
            this.hasExamplesGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notebooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CoverColour";
            // 
            // colourBox
            // 
            this.colourBox.Location = new System.Drawing.Point(110, 13);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(761, 22);
            this.colourBox.TabIndex = 3;
            // 
            // qualityBox
            // 
            this.qualityBox.Location = new System.Drawing.Point(110, 43);
            this.qualityBox.Name = "qualityBox";
            this.qualityBox.Size = new System.Drawing.Size(761, 22);
            this.qualityBox.TabIndex = 4;
            // 
            // coverColourBox
            // 
            this.coverColourBox.Location = new System.Drawing.Point(110, 73);
            this.coverColourBox.Name = "coverColourBox";
            this.coverColourBox.Size = new System.Drawing.Size(761, 22);
            this.coverColourBox.TabIndex = 5;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(110, 101);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(761, 22);
            this.typeBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // orientationBox
            // 
            this.orientationBox.Location = new System.Drawing.Point(110, 129);
            this.orientationBox.Name = "orientationBox";
            this.orientationBox.Size = new System.Drawing.Size(761, 22);
            this.orientationBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Orientation";
            // 
            // hasExamplesGrp
            // 
            this.hasExamplesGrp.Controls.Add(this.noChoice);
            this.hasExamplesGrp.Controls.Add(this.yesChoice);
            this.hasExamplesGrp.Location = new System.Drawing.Point(110, 158);
            this.hasExamplesGrp.Name = "hasExamplesGrp";
            this.hasExamplesGrp.Size = new System.Drawing.Size(122, 55);
            this.hasExamplesGrp.TabIndex = 11;
            this.hasExamplesGrp.TabStop = false;
            // 
            // noChoice
            // 
            this.noChoice.AutoSize = true;
            this.noChoice.Checked = true;
            this.noChoice.Location = new System.Drawing.Point(65, 19);
            this.noChoice.Name = "noChoice";
            this.noChoice.Size = new System.Drawing.Size(47, 21);
            this.noChoice.TabIndex = 13;
            this.noChoice.TabStop = true;
            this.noChoice.Text = "No";
            this.noChoice.UseVisualStyleBackColor = true;
            // 
            // yesChoice
            // 
            this.yesChoice.AutoSize = true;
            this.yesChoice.Location = new System.Drawing.Point(6, 19);
            this.yesChoice.Name = "yesChoice";
            this.yesChoice.Size = new System.Drawing.Size(53, 21);
            this.yesChoice.TabIndex = 12;
            this.yesChoice.Text = "Yes";
            this.yesChoice.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "HasExamples";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(796, 179);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // notebooks
            // 
            this.notebooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notebooks.Location = new System.Drawing.Point(15, 204);
            this.notebooks.Name = "notebooks";
            this.notebooks.RowHeadersWidth = 51;
            this.notebooks.RowTemplate.Height = 24;
            this.notebooks.Size = new System.Drawing.Size(856, 320);
            this.notebooks.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.notebooks);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hasExamplesGrp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orientationBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.coverColourBox);
            this.Controls.Add(this.qualityBox);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.hasExamplesGrp.ResumeLayout(false);
            this.hasExamplesGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notebooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox colourBox;
        private System.Windows.Forms.TextBox qualityBox;
        private System.Windows.Forms.TextBox coverColourBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orientationBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox hasExamplesGrp;
        private System.Windows.Forms.RadioButton noChoice;
        private System.Windows.Forms.RadioButton yesChoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView notebooks;
    }
}