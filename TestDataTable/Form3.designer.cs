namespace TestDataTable
{
    partial class Form3
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.dgvPictures = new System.Windows.Forms.DataGridView();
            this.pbShowPictures = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(22, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load picture";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(115, 27);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 1;
            this.btnIndex.Text = "Show one";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(217, 30);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(100, 20);
            this.tbIndex.TabIndex = 2;
            this.tbIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIndex_KeyPress);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(338, 28);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "Show all";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dgvPictures
            // 
            this.dgvPictures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPictures.Location = new System.Drawing.Point(22, 78);
            this.dgvPictures.Name = "dgvPictures";
            this.dgvPictures.Size = new System.Drawing.Size(379, 441);
            this.dgvPictures.TabIndex = 4;
            // 
            // pbShowPictures
            // 
            this.pbShowPictures.Location = new System.Drawing.Point(407, 78);
            this.pbShowPictures.Name = "pbShowPictures";
            this.pbShowPictures.Size = new System.Drawing.Size(366, 441);
            this.pbShowPictures.TabIndex = 5;
            this.pbShowPictures.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.pbShowPictures);
            this.Controls.Add(this.dgvPictures);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView dgvPictures;
        private System.Windows.Forms.PictureBox pbShowPictures;
    }
}