namespace WisejWebDesktopApplication2
{
	partial class Window1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.EmplCode = new Wisej.Web.DataGridViewTextBoxColumn();
            this.EmplName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.EmplGroup = new Wisej.Web.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.EmplCode,
            this.EmplName,
            this.EmplGroup});
            this.dataGridView1.Location = new System.Drawing.Point(104, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // EmlCode
            // 
            this.EmplCode.DataPropertyName = "EmplCode";
            this.EmplCode.HeaderText = "EmlCode";
            this.EmplCode.Name = "EmlCode";
            // 
            // EmplName
            // 
            this.EmplName.DataPropertyName = "EmplName";
            this.EmplName.HeaderText = "EmplName";
            this.EmplName.Name = "EmplName";
            // 
            // EmplGroup
            // 
            this.EmplGroup.DataPropertyName = "EmplGroup";
            this.EmplGroup.HeaderText = "EmplGroup";
            this.EmplGroup.Name = "EmplGroup";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 579);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Window1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Window1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn EmplCode;
        private Wisej.Web.DataGridViewTextBoxColumn EmplName;
        private Wisej.Web.DataGridViewTextBoxColumn EmplGroup;
    }
}

