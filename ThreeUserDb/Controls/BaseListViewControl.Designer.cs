namespace ThreeUserDb.Controls
{
    partial class BaseListViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkBoxLimit = new System.Windows.Forms.CheckBox();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(3, 32);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(621, 288);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellDoubleClick);
            // 
            // checkBoxLimit
            // 
            this.checkBoxLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxLimit.AutoSize = true;
            this.checkBoxLimit.Checked = true;
            this.checkBoxLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLimit.Location = new System.Drawing.Point(3, 327);
            this.checkBoxLimit.Name = "checkBoxLimit";
            this.checkBoxLimit.Size = new System.Drawing.Size(59, 17);
            this.checkBoxLimit.TabIndex = 2;
            this.checkBoxLimit.Text = "Лимит";
            this.checkBoxLimit.UseVisualStyleBackColor = true;
            this.checkBoxLimit.CheckedChanged += new System.EventHandler(this.checkBoxLimit_CheckedChanged);
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownLimit.Location = new System.Drawing.Point(68, 326);
            this.numericUpDownLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownLimit.TabIndex = 3;
            this.numericUpDownLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLimit.ValueChanged += new System.EventHandler(this.numericUpDownLimit_ValueChanged);
            // 
            // numericUpDownPage
            // 
            this.numericUpDownPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPage.Location = new System.Drawing.Point(215, 326);
            this.numericUpDownPage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPage.Name = "numericUpDownPage";
            this.numericUpDownPage.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownPage.TabIndex = 4;
            this.numericUpDownPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPage.ValueChanged += new System.EventHandler(this.numericUpDownPage_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Страница";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(549, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(84, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(468, 3);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 23);
            this.buttonReport.TabIndex = 8;
            this.buttonReport.Text = "Отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Visible = false;
            // 
            // BaseListViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownPage);
            this.Controls.Add(this.numericUpDownLimit);
            this.Controls.Add(this.checkBoxLimit);
            this.Controls.Add(this.dataGridView);
            this.Name = "BaseListViewControl";
            this.Size = new System.Drawing.Size(627, 349);
            this.Load += new System.EventHandler(this.BaseListViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownPage;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRefresh;
        protected System.Windows.Forms.Button buttonAdd;
        protected System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReport;
    }
}
