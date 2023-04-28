namespace _3_Sahibinden
{
    partial class FrmList
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
            this.components = new System.ComponentModel.Container();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.txtMaxYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinKm = new System.Windows.Forms.TextBox();
            this.txtMaxKm = new System.Windows.Forms.TextBox();
            this.checkListColor = new System.Windows.Forms.CheckedListBox();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarList
            // 
            this.dgvCarList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCarList.Location = new System.Drawing.Point(403, 18);
            this.dgvCarList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCarList.MultiSelect = false;
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.ReadOnly = true;
            this.dgvCarList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarList.Size = new System.Drawing.Size(547, 419);
            this.dgvCarList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.değiştirToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            this.değiştirToolStripMenuItem.Click += new System.EventHandler(this.değiştirToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ara";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(119, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(171, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(13, 90);
            this.txtMinPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(150, 26);
            this.txtMinPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(176, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(198, 90);
            this.txtMaxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(150, 26);
            this.txtMaxPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(171, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yıl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(171, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "-";
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(13, 146);
            this.txtMinYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(150, 26);
            this.txtMinYear.TabIndex = 2;
            // 
            // txtMaxYear
            // 
            this.txtMaxYear.Location = new System.Drawing.Point(198, 146);
            this.txtMaxYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxYear.Name = "txtMaxYear";
            this.txtMaxYear.Size = new System.Drawing.Size(150, 26);
            this.txtMaxYear.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(171, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(171, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "-";
            // 
            // txtMinKm
            // 
            this.txtMinKm.Location = new System.Drawing.Point(13, 208);
            this.txtMinKm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinKm.Name = "txtMinKm";
            this.txtMinKm.Size = new System.Drawing.Size(150, 26);
            this.txtMinKm.TabIndex = 2;
            // 
            // txtMaxKm
            // 
            this.txtMaxKm.Location = new System.Drawing.Point(198, 208);
            this.txtMaxKm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxKm.Name = "txtMaxKm";
            this.txtMaxKm.Size = new System.Drawing.Size(150, 26);
            this.txtMaxKm.TabIndex = 2;
            // 
            // checkListColor
            // 
            this.checkListColor.FormattingEnabled = true;
            this.checkListColor.Location = new System.Drawing.Point(13, 244);
            this.checkListColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkListColor.Name = "checkListColor";
            this.checkListColor.Size = new System.Drawing.Size(382, 193);
            this.checkListColor.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(133, 446);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(136, 28);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Ara";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 486);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.checkListColor);
            this.Controls.Add(this.txtMaxKm);
            this.Controls.Add(this.txtMinKm);
            this.Controls.Add(this.txtMaxYear);
            this.Controls.Add(this.txtMinYear);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCarList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmList";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.TextBox txtMaxYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinKm;
        private System.Windows.Forms.TextBox txtMaxKm;
        private System.Windows.Forms.CheckedListBox checkListColor;
        public System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnFilter;
    }
}

