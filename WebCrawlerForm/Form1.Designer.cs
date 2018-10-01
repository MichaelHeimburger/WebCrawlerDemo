namespace WebCrawlerForm
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
            this.BtnNBC = new System.Windows.Forms.Button();
            this.GrdAllArticles = new System.Windows.Forms.DataGridView();
            this.LblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAllArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNBC
            // 
            this.BtnNBC.Location = new System.Drawing.Point(12, 12);
            this.BtnNBC.Name = "BtnNBC";
            this.BtnNBC.Size = new System.Drawing.Size(168, 79);
            this.BtnNBC.TabIndex = 0;
            this.BtnNBC.Text = "News Get";
            this.BtnNBC.UseVisualStyleBackColor = true;
            this.BtnNBC.Click += new System.EventHandler(this.BtnNBC_Click);
            // 
            // GrdAllArticles
            // 
            this.GrdAllArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAllArticles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdAllArticles.Location = new System.Drawing.Point(186, 12);
            this.GrdAllArticles.Name = "GrdAllArticles";
            this.GrdAllArticles.RowTemplate.Height = 24;
            this.GrdAllArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdAllArticles.Size = new System.Drawing.Size(929, 150);
            this.GrdAllArticles.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Sitka Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 388);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(438, 55);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Lets Get This To Work";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.GrdAllArticles);
            this.Controls.Add(this.BtnNBC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GrdAllArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNBC;
        private System.Windows.Forms.DataGridView GrdAllArticles;
        private System.Windows.Forms.Label LblTitle;
    }
}

