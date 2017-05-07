namespace WindowsFormsApp2
{
    partial class addproduct
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
            this.save = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.price = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(364, 227);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(129, 27);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(12, 65);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(169, 166);
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(270, 12);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(107, 20);
            this.price.TabIndex = 2;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(270, 38);
            this.title.Multiline = true;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(223, 63);
            this.title.TabIndex = 3;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(270, 107);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(223, 114);
            this.desc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descriprion";
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(12, 20);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(90, 23);
            this.choose.TabIndex = 8;
            this.choose.Text = "Choose image";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 266);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.title);
            this.Controls.Add(this.price);
            this.Controls.Add(this.image);
            this.Controls.Add(this.save);
            this.Name = "addproduct";
            this.Text = "addproduct";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}