namespace WinFormsElcoplus
{
    partial class Form1
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.loadXML = new System.Windows.Forms.Button();
            this.boxURLs = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(21, 80);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(478, 358);
            this.treeView.TabIndex = 0;
            // 
            // loadXML
            // 
            this.loadXML.Location = new System.Drawing.Point(403, 19);
            this.loadXML.Name = "loadXML";
            this.loadXML.Size = new System.Drawing.Size(75, 23);
            this.loadXML.TabIndex = 1;
            this.loadXML.Text = "Load XML";
            this.loadXML.UseVisualStyleBackColor = true;
            this.loadXML.Click += new System.EventHandler(this.loadXML_Click);
            // 
            // boxURLs
            // 
            this.boxURLs.FormattingEnabled = true;
            this.boxURLs.Location = new System.Drawing.Point(11, 19);
            this.boxURLs.Name = "boxURLs";
            this.boxURLs.Size = new System.Drawing.Size(376, 21);
            this.boxURLs.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxURLs);
            this.groupBox1.Controls.Add(this.loadXML);
            this.groupBox1.Location = new System.Drawing.Point(21, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button loadXML;
        private System.Windows.Forms.ComboBox boxURLs;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

