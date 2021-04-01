namespace TurboMapCalculator {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.propGrid = new System.Windows.Forms.PropertyGrid();
			this.btnRecalc = new System.Windows.Forms.Button();
			this.btnPasteImage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(287, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(574, 507);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// propGrid
			// 
			this.propGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.propGrid.Location = new System.Drawing.Point(12, 105);
			this.propGrid.Name = "propGrid";
			this.propGrid.Size = new System.Drawing.Size(269, 563);
			this.propGrid.TabIndex = 1;
			// 
			// btnRecalc
			// 
			this.btnRecalc.Location = new System.Drawing.Point(12, 12);
			this.btnRecalc.Name = "btnRecalc";
			this.btnRecalc.Size = new System.Drawing.Size(269, 23);
			this.btnRecalc.TabIndex = 2;
			this.btnRecalc.Text = "Recalculate";
			this.btnRecalc.UseVisualStyleBackColor = true;
			this.btnRecalc.Click += new System.EventHandler(this.btnRecalc_Click);
			// 
			// btnPasteImage
			// 
			this.btnPasteImage.Location = new System.Drawing.Point(12, 41);
			this.btnPasteImage.Name = "btnPasteImage";
			this.btnPasteImage.Size = new System.Drawing.Size(269, 23);
			this.btnPasteImage.TabIndex = 3;
			this.btnPasteImage.Text = "Paste Image";
			this.btnPasteImage.UseVisualStyleBackColor = true;
			this.btnPasteImage.Click += new System.EventHandler(this.btnPasteImage_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(971, 680);
			this.Controls.Add(this.btnPasteImage);
			this.Controls.Add(this.btnRecalc);
			this.Controls.Add(this.propGrid);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PropertyGrid propGrid;
		private System.Windows.Forms.Button btnRecalc;
		private System.Windows.Forms.Button btnPasteImage;
	}
}

