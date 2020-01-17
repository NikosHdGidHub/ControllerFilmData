namespace FilmDataBaseForm
{
	partial class MainForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.sdsdsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MultiSerial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdsdsa,
            this.sdded,
            this.MultiSerial});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(512, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// sdsdsa
			// 
			this.sdsdsa.Frozen = true;
			this.sdsdsa.HeaderText = "Название фильма";
			this.sdsdsa.MinimumWidth = 6;
			this.sdsdsa.Name = "sdsdsa";
			this.sdsdsa.ReadOnly = true;
			this.sdsdsa.Width = 125;
			// 
			// sdded
			// 
			this.sdded.Frozen = true;
			this.sdded.HeaderText = "Рейтинг фильма";
			this.sdded.MinimumWidth = 6;
			this.sdded.Name = "sdded";
			this.sdded.ReadOnly = true;
			this.sdded.Width = 125;
			// 
			// MultiSerial
			// 
			this.MultiSerial.Frozen = true;
			this.MultiSerial.HeaderText = "Много серийный";
			this.MultiSerial.MinimumWidth = 6;
			this.MultiSerial.Name = "MultiSerial";
			this.MultiSerial.ReadOnly = true;
			this.MultiSerial.Width = 125;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 472);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn sdsdsa;
		private System.Windows.Forms.DataGridViewTextBoxColumn sdded;
		private System.Windows.Forms.DataGridViewCheckBoxColumn MultiSerial;
	}
}

