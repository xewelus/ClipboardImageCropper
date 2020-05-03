namespace ClipboardImageCropper
{
	partial class SettingsForm
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
			this.lvResolutions = new System.Windows.Forms.ListView();
			this.chResoultion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pnlTextBoxes = new System.Windows.Forms.Panel();
			this.tbHeight = new System.Windows.Forms.TextBox();
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnDel = new System.Windows.Forms.ToolStripButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.pnlTextBoxes.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvResolutions
			// 
			this.lvResolutions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chResoultion});
			this.lvResolutions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvResolutions.FullRowSelect = true;
			this.lvResolutions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvResolutions.HideSelection = false;
			this.lvResolutions.Location = new System.Drawing.Point(4, 42);
			this.lvResolutions.MultiSelect = false;
			this.lvResolutions.Name = "lvResolutions";
			this.lvResolutions.Size = new System.Drawing.Size(421, 313);
			this.lvResolutions.TabIndex = 0;
			this.lvResolutions.UseCompatibleStateImageBehavior = false;
			this.lvResolutions.View = System.Windows.Forms.View.Details;
			this.lvResolutions.SelectedIndexChanged += new System.EventHandler(this.lvResolutions_SelectedIndexChanged);
			// 
			// chResoultion
			// 
			this.chResoultion.Width = 250;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvResolutions);
			this.groupBox1.Controls.Add(this.pnlTextBoxes);
			this.groupBox1.Controls.Add(this.toolStrip1);
			this.groupBox1.Location = new System.Drawing.Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 10);
			this.groupBox1.Size = new System.Drawing.Size(603, 365);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Resolutions";
			// 
			// pnlTextBoxes
			// 
			this.pnlTextBoxes.Controls.Add(this.tbHeight);
			this.pnlTextBoxes.Controls.Add(this.tbWidth);
			this.pnlTextBoxes.Controls.Add(this.label2);
			this.pnlTextBoxes.Controls.Add(this.label1);
			this.pnlTextBoxes.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlTextBoxes.Enabled = false;
			this.pnlTextBoxes.Location = new System.Drawing.Point(425, 42);
			this.pnlTextBoxes.Name = "pnlTextBoxes";
			this.pnlTextBoxes.Size = new System.Drawing.Size(174, 313);
			this.pnlTextBoxes.TabIndex = 1;
			// 
			// tbHeight
			// 
			this.tbHeight.Location = new System.Drawing.Point(56, 29);
			this.tbHeight.Name = "tbHeight";
			this.tbHeight.Size = new System.Drawing.Size(100, 20);
			this.tbHeight.TabIndex = 3;
			this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
			// 
			// tbWidth
			// 
			this.tbWidth.Location = new System.Drawing.Point(56, 7);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(100, 20);
			this.tbWidth.TabIndex = 2;
			this.tbWidth.TextChanged += new System.EventHandler(this.tbWidth_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Height:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Width:";
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDel});
			this.toolStrip1.Location = new System.Drawing.Point(4, 17);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(595, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnAdd
			// 
			this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnAdd.Image = global::ClipboardImageCropper.Properties.Resources.add;
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(23, 22);
			this.btnAdd.Text = "toolStripButton1";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDel.Enabled = false;
			this.btnDel.Image = global::ClipboardImageCropper.Properties.Resources.del;
			this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(23, 22);
			this.btnDel.Text = "toolStripButton2";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Location = new System.Drawing.Point(5, 377);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(600, 4);
			this.panel2.TabIndex = 2;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Image = global::ClipboardImageCropper.Properties.Resources.ok;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new System.Drawing.Point(403, 387);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(99, 23);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(504, 387);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(99, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(610, 415);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "xewee\'s Image Auto Resizer";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.pnlTextBoxes.ResumeLayout(false);
			this.pnlTextBoxes.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvResolutions;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnlTextBoxes;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnDel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbHeight;
		private System.Windows.Forms.TextBox tbWidth;
		private System.Windows.Forms.ColumnHeader chResoultion;
	}
}

