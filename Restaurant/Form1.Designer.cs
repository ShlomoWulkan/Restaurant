namespace Restaurant
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDisheName = new System.Windows.Forms.ComboBox();
            this.cmbDisheType = new System.Windows.Forms.ComboBox();
            this.btnInsertToList = new System.Windows.Forms.Button();
            this.btnInsertToXml = new System.Windows.Forms.Button();
            this.lstFood = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(536, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 26);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "שם לקוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "סוג מנה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם מנה";
            // 
            // cmbDisheName
            // 
            this.cmbDisheName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisheName.FormattingEnabled = true;
            this.cmbDisheName.Location = new System.Drawing.Point(430, 223);
            this.cmbDisheName.Name = "cmbDisheName";
            this.cmbDisheName.Size = new System.Drawing.Size(121, 28);
            this.cmbDisheName.TabIndex = 5;
            // 
            // cmbDisheType
            // 
            this.cmbDisheType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisheType.FormattingEnabled = true;
            this.cmbDisheType.Items.AddRange(new object[] {
            "ראשונות",
            "עיקריות",
            "תוספות",
            "אחרונות"});
            this.cmbDisheType.Location = new System.Drawing.Point(607, 223);
            this.cmbDisheType.Name = "cmbDisheType";
            this.cmbDisheType.Size = new System.Drawing.Size(121, 28);
            this.cmbDisheType.TabIndex = 6;
            this.cmbDisheType.SelectedIndexChanged += new System.EventHandler(this.cmbDisheType_SelectedIndexChanged);
            // 
            // btnInsertToList
            // 
            this.btnInsertToList.Location = new System.Drawing.Point(520, 305);
            this.btnInsertToList.Name = "btnInsertToList";
            this.btnInsertToList.Size = new System.Drawing.Size(122, 50);
            this.btnInsertToList.TabIndex = 7;
            this.btnInsertToList.Text = "הוסף מנה";
            this.btnInsertToList.UseVisualStyleBackColor = true;
            this.btnInsertToList.Click += new System.EventHandler(this.btnInsertToList_Click);
            // 
            // btnInsertToXml
            // 
            this.btnInsertToXml.Location = new System.Drawing.Point(85, 348);
            this.btnInsertToXml.Name = "btnInsertToXml";
            this.btnInsertToXml.Size = new System.Drawing.Size(122, 50);
            this.btnInsertToXml.TabIndex = 8;
            this.btnInsertToXml.Text = "שמירה";
            this.btnInsertToXml.UseVisualStyleBackColor = true;
            this.btnInsertToXml.Click += new System.EventHandler(this.btnInsertToXml_Click);
            // 
            // lstFood
            // 
            this.lstFood.FormattingEnabled = true;
            this.lstFood.ItemHeight = 20;
            this.lstFood.Location = new System.Drawing.Point(-2, 1);
            this.lstFood.Name = "lstFood";
            this.lstFood.Size = new System.Drawing.Size(329, 324);
            this.lstFood.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFood);
            this.Controls.Add(this.btnInsertToXml);
            this.Controls.Add(this.btnInsertToList);
            this.Controls.Add(this.cmbDisheType);
            this.Controls.Add(this.cmbDisheName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDisheName;
        private System.Windows.Forms.ComboBox cmbDisheType;
        private System.Windows.Forms.Button btnInsertToList;
        private System.Windows.Forms.Button btnInsertToXml;
        private System.Windows.Forms.ListBox lstFood;
    }
}

