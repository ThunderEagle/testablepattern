namespace TestablePattern.Views
{
	partial class Foo
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
			if(disposing && (components != null))
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
			this.components = new System.ComponentModel.Container();
			this.btnLoadList = new System.Windows.Forms.Button();
			this.bsFoo = new System.Windows.Forms.BindingSource(this.components);
			this.btnShowMessage = new System.Windows.Forms.Button();
			this.chkAllowEntry = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBox = new System.Windows.Forms.TextBox();
			this.btnChange = new System.Windows.Forms.Button();
			this.txtLocked = new System.Windows.Forms.TextBox();
			this.chkAllowLoad = new System.Windows.Forms.CheckBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorizedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnAddToList = new System.Windows.Forms.Button();
			this.btnModifyItem = new System.Windows.Forms.Button();
			this.txtA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtC = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bsFoo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLoadList
			// 
			this.btnLoadList.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsFoo, "AllowLoad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.btnLoadList.Location = new System.Drawing.Point(41, 162);
			this.btnLoadList.Name = "btnLoadList";
			this.btnLoadList.Size = new System.Drawing.Size(120, 23);
			this.btnLoadList.TabIndex = 0;
			this.btnLoadList.Text = "Load Grid";
			this.btnLoadList.UseVisualStyleBackColor = true;
			// 
			// bsFoo
			// 
			this.bsFoo.DataSource = typeof(TestablePattern.Controller.FooViewModel);
			// 
			// btnShowMessage
			// 
			this.btnShowMessage.Location = new System.Drawing.Point(41, 191);
			this.btnShowMessage.Name = "btnShowMessage";
			this.btnShowMessage.Size = new System.Drawing.Size(120, 23);
			this.btnShowMessage.TabIndex = 1;
			this.btnShowMessage.Text = "Show MessageBox";
			this.btnShowMessage.UseVisualStyleBackColor = true;
			// 
			// chkAllowEntry
			// 
			this.chkAllowEntry.AutoSize = true;
			this.chkAllowEntry.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsFoo, "IsEditable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkAllowEntry.Location = new System.Drawing.Point(44, 53);
			this.chkAllowEntry.Name = "chkAllowEntry";
			this.chkAllowEntry.Size = new System.Drawing.Size(105, 17);
			this.chkAllowEntry.TabIndex = 2;
			this.chkAllowEntry.Text = "Enable text entry";
			this.chkAllowEntry.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFoo, "LabelText", true));
			this.label1.Location = new System.Drawing.Point(41, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// txtBox
			// 
			this.txtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFoo, "EnteredText", true));
			this.txtBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsFoo, "IsEditable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtBox.Location = new System.Drawing.Point(44, 76);
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new System.Drawing.Size(200, 20);
			this.txtBox.TabIndex = 5;
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(41, 220);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(120, 23);
			this.btnChange.TabIndex = 6;
			this.btnChange.Text = "Change Text";
			this.btnChange.UseVisualStyleBackColor = true;
			// 
			// txtLocked
			// 
			this.txtLocked.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFoo, "LinkedText", true));
			this.txtLocked.Location = new System.Drawing.Point(44, 102);
			this.txtLocked.Name = "txtLocked";
			this.txtLocked.ReadOnly = true;
			this.txtLocked.Size = new System.Drawing.Size(200, 20);
			this.txtLocked.TabIndex = 7;
			// 
			// chkAllowLoad
			// 
			this.chkAllowLoad.AutoSize = true;
			this.chkAllowLoad.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsFoo, "AllowLoad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkAllowLoad.Location = new System.Drawing.Point(41, 139);
			this.chkAllowLoad.Name = "chkAllowLoad";
			this.chkAllowLoad.Size = new System.Drawing.Size(120, 17);
			this.chkAllowLoad.TabIndex = 8;
			this.chkAllowLoad.Text = "Allow ListView Load";
			this.chkAllowLoad.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorizedDataGridViewCheckBoxColumn,
            this.amountDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.itemsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(293, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(583, 230);
			this.dataGridView1.TabIndex = 9;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// authorizedDataGridViewCheckBoxColumn
			// 
			this.authorizedDataGridViewCheckBoxColumn.DataPropertyName = "Authorized";
			this.authorizedDataGridViewCheckBoxColumn.HeaderText = "Authorized";
			this.authorizedDataGridViewCheckBoxColumn.Name = "authorizedDataGridViewCheckBoxColumn";
			this.authorizedDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			this.amountDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// itemsBindingSource
			// 
			this.itemsBindingSource.DataMember = "Items";
			this.itemsBindingSource.DataSource = this.bsFoo;
			// 
			// btnAddToList
			// 
			this.btnAddToList.Location = new System.Drawing.Point(167, 162);
			this.btnAddToList.Name = "btnAddToList";
			this.btnAddToList.Size = new System.Drawing.Size(120, 23);
			this.btnAddToList.TabIndex = 10;
			this.btnAddToList.Text = "Add Item";
			this.btnAddToList.UseVisualStyleBackColor = true;
			// 
			// btnModifyItem
			// 
			this.btnModifyItem.Location = new System.Drawing.Point(168, 190);
			this.btnModifyItem.Name = "btnModifyItem";
			this.btnModifyItem.Size = new System.Drawing.Size(119, 23);
			this.btnModifyItem.TabIndex = 11;
			this.btnModifyItem.Text = "Modify first Item";
			this.btnModifyItem.UseVisualStyleBackColor = true;
			// 
			// txtA
			// 
			this.txtA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFoo, "A", true));
			this.txtA.Location = new System.Drawing.Point(41, 279);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(47, 20);
			this.txtA.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(94, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "+";
			// 
			// txtB
			// 
			this.txtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFoo, "B", true));
			this.txtB.Location = new System.Drawing.Point(113, 279);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(48, 20);
			this.txtB.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(167, 282);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "=";
			// 
			// txtC
			// 
			this.txtC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFoo, "C", true));
			this.txtC.Location = new System.Drawing.Point(186, 279);
			this.txtC.Name = "txtC";
			this.txtC.ReadOnly = true;
			this.txtC.Size = new System.Drawing.Size(58, 20);
			this.txtC.TabIndex = 16;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(170, 220);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(117, 23);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Save File";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// Foo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 350);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.btnModifyItem);
			this.Controls.Add(this.btnAddToList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.chkAllowLoad);
			this.Controls.Add(this.txtLocked);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.txtBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkAllowEntry);
			this.Controls.Add(this.btnShowMessage);
			this.Controls.Add(this.btnLoadList);
			this.Name = "Foo";
			this.Text = "Foo";
			((System.ComponentModel.ISupportInitialize)(this.bsFoo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoadList;
		private System.Windows.Forms.Button btnShowMessage;
		private System.Windows.Forms.CheckBox chkAllowEntry;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.TextBox txtLocked;
		private System.Windows.Forms.CheckBox chkAllowLoad;
		private System.Windows.Forms.BindingSource bsFoo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn authorizedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource itemsBindingSource;
		private System.Windows.Forms.Button btnAddToList;
		private System.Windows.Forms.Button btnModifyItem;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.Button btnSave;
	}
}