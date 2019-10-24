namespace AffineTransformationsIn3D
{
    partial class FormChangeModel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePolyhedron = new System.Windows.Forms.TabPage();
            this.radioButtonCube = new System.Windows.Forms.RadioButton();
            this.radioButtonIcosahedron = new System.Windows.Forms.RadioButton();
            this.radioButtonTetrahedron = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePolyhedron.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 3);
            this.tabControl1.Controls.Add(this.tabPagePolyhedron);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePolyhedron
            // 
            this.tabPagePolyhedron.Controls.Add(this.radioButtonCube);
            this.tabPagePolyhedron.Controls.Add(this.radioButtonIcosahedron);
            this.tabPagePolyhedron.Controls.Add(this.radioButtonTetrahedron);
            this.tabPagePolyhedron.Location = new System.Drawing.Point(4, 22);
            this.tabPagePolyhedron.Name = "tabPagePolyhedron";
            this.tabPagePolyhedron.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePolyhedron.Size = new System.Drawing.Size(440, 309);
            this.tabPagePolyhedron.TabIndex = 0;
            this.tabPagePolyhedron.Text = "Многогранник";
            this.tabPagePolyhedron.UseVisualStyleBackColor = true;
            // 
            // radioButtonCube
            // 
            this.radioButtonCube.AutoSize = true;
            this.radioButtonCube.Location = new System.Drawing.Point(6, 53);
            this.radioButtonCube.Name = "radioButtonCube";
            this.radioButtonCube.Size = new System.Drawing.Size(43, 17);
            this.radioButtonCube.TabIndex = 2;
            this.radioButtonCube.TabStop = true;
            this.radioButtonCube.Text = "Куб";
            this.radioButtonCube.UseVisualStyleBackColor = true;
            // 
            // radioButtonIcosahedron
            // 
            this.radioButtonIcosahedron.AutoSize = true;
            this.radioButtonIcosahedron.Location = new System.Drawing.Point(6, 30);
            this.radioButtonIcosahedron.Name = "radioButtonIcosahedron";
            this.radioButtonIcosahedron.Size = new System.Drawing.Size(75, 17);
            this.radioButtonIcosahedron.TabIndex = 1;
            this.radioButtonIcosahedron.TabStop = true;
            this.radioButtonIcosahedron.Text = "Икосаэдр";
            this.radioButtonIcosahedron.UseVisualStyleBackColor = true;
            // 
            // radioButtonTetrahedron
            // 
            this.radioButtonTetrahedron.AutoSize = true;
            this.radioButtonTetrahedron.Checked = true;
            this.radioButtonTetrahedron.Location = new System.Drawing.Point(6, 6);
            this.radioButtonTetrahedron.Name = "radioButtonTetrahedron";
            this.radioButtonTetrahedron.Size = new System.Drawing.Size(73, 17);
            this.radioButtonTetrahedron.TabIndex = 0;
            this.radioButtonTetrahedron.TabStop = true;
            this.radioButtonTetrahedron.Text = "Тетраэдр";
            this.radioButtonTetrahedron.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(376, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(295, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ок";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Ok);
            // 
            // FormChangeModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(470, 300);
            this.Name = "FormChangeModel";
            this.Text = "Выберите объект";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePolyhedron.ResumeLayout(false);
            this.tabPagePolyhedron.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePolyhedron;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonIcosahedron;
        private System.Windows.Forms.RadioButton radioButtonTetrahedron;
        private System.Windows.Forms.RadioButton radioButtonCube;
    }
}