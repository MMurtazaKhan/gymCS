namespace gymCS
{
    partial class equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipment));
            this.equiptxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxequipName = new System.Windows.Forms.TextBox();
            this.equipCost = new System.Windows.Forms.TextBox();
            this.equipDate = new System.Windows.Forms.DateTimePicker();
            this.equipDescrip = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // equiptxt
            // 
            this.equiptxt.BackColor = System.Drawing.Color.Transparent;
            this.equiptxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equiptxt.Image = ((System.Drawing.Image)(resources.GetObject("equiptxt.Image")));
            this.equiptxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equiptxt.Location = new System.Drawing.Point(201, 41);
            this.equiptxt.Name = "equiptxt";
            this.equiptxt.Size = new System.Drawing.Size(128, 30);
            this.equiptxt.TabIndex = 10;
            this.equiptxt.Text = "Equipment";
            this.equiptxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.equiptxt.Click += new System.EventHandler(this.equiptxt_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(201, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(201, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date of Delivery";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(201, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cost";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 31);
            this.button3.TabIndex = 24;
            this.button3.Text = "Show Equipments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxequipName
            // 
            this.textBoxequipName.Location = new System.Drawing.Point(411, 50);
            this.textBoxequipName.Name = "textBoxequipName";
            this.textBoxequipName.Size = new System.Drawing.Size(172, 20);
            this.textBoxequipName.TabIndex = 25;
            // 
            // equipCost
            // 
            this.equipCost.Location = new System.Drawing.Point(411, 217);
            this.equipCost.Name = "equipCost";
            this.equipCost.Size = new System.Drawing.Size(172, 20);
            this.equipCost.TabIndex = 26;
            // 
            // equipDate
            // 
            this.equipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.equipDate.Location = new System.Drawing.Point(411, 285);
            this.equipDate.Name = "equipDate";
            this.equipDate.Size = new System.Drawing.Size(172, 20);
            this.equipDate.TabIndex = 27;
            // 
            // equipDescrip
            // 
            this.equipDescrip.Location = new System.Drawing.Point(411, 103);
            this.equipDescrip.Name = "equipDescrip";
            this.equipDescrip.Size = new System.Drawing.Size(172, 96);
            this.equipDescrip.TabIndex = 28;
            this.equipDescrip.Text = "";
            // 
            // equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equipDescrip);
            this.Controls.Add(this.equipDate);
            this.Controls.Add(this.equipCost);
            this.Controls.Add(this.textBoxequipName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equiptxt);
            this.Name = "equipment";
            this.Text = "equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label equiptxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxequipName;
        private System.Windows.Forms.TextBox equipCost;
        private System.Windows.Forms.DateTimePicker equipDate;
        private System.Windows.Forms.RichTextBox equipDescrip;
    }
}