namespace MES
{
    partial class OutputOkay
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
            this.OutputOk_grid = new System.Windows.Forms.DataGridView();
            this.inspect2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outdate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.step2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputOk_pn = new System.Windows.Forms.Panel();
            this.Output_date = new System.Windows.Forms.DateTimePicker();
            this.OutOkIn_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputRegister_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputLocation_txt = new System.Windows.Forms.TextBox();
            this.OutOkCl_bt = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutputOk_grid)).BeginInit();
            this.OutputOk_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputOk_grid
            // 
            this.OutputOk_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputOk_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inspect2,
            this.company2,
            this.code2,
            this.name2,
            this.num2,
            this.outdate2,
            this.step2});
            this.OutputOk_grid.Location = new System.Drawing.Point(22, 82);
            this.OutputOk_grid.Name = "OutputOk_grid";
            this.OutputOk_grid.RowHeadersWidth = 62;
            this.OutputOk_grid.RowTemplate.Height = 30;
            this.OutputOk_grid.Size = new System.Drawing.Size(1188, 332);
            this.OutputOk_grid.TabIndex = 13;
            this.OutputOk_grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OutputOk_grid_CellMouseClick);
            // 
            // inspect2
            // 
            this.inspect2.HeaderText = "검사결과";
            this.inspect2.MinimumWidth = 8;
            this.inspect2.Name = "inspect2";
            this.inspect2.Width = 150;
            // 
            // company2
            // 
            this.company2.HeaderText = "회사";
            this.company2.MinimumWidth = 8;
            this.company2.Name = "company2";
            this.company2.Width = 150;
            // 
            // code2
            // 
            this.code2.HeaderText = "품번";
            this.code2.MinimumWidth = 8;
            this.code2.Name = "code2";
            this.code2.Width = 150;
            // 
            // name2
            // 
            this.name2.HeaderText = "품명";
            this.name2.MinimumWidth = 8;
            this.name2.Name = "name2";
            this.name2.Width = 150;
            // 
            // num2
            // 
            this.num2.HeaderText = "수량";
            this.num2.MinimumWidth = 8;
            this.num2.Name = "num2";
            this.num2.Width = 150;
            // 
            // outdate2
            // 
            this.outdate2.HeaderText = "납기일";
            this.outdate2.MinimumWidth = 8;
            this.outdate2.Name = "outdate2";
            this.outdate2.Width = 150;
            // 
            // step2
            // 
            this.step2.HeaderText = "진행상태";
            this.step2.MinimumWidth = 8;
            this.step2.Name = "step2";
            this.step2.Width = 150;
            // 
            // OutputOk_pn
            // 
            this.OutputOk_pn.Controls.Add(this.Output_date);
            this.OutputOk_pn.Controls.Add(this.OutOkIn_bt);
            this.OutputOk_pn.Controls.Add(this.button1);
            this.OutputOk_pn.Controls.Add(this.OutputRegister_txt);
            this.OutputOk_pn.Controls.Add(this.label7);
            this.OutputOk_pn.Controls.Add(this.label3);
            this.OutputOk_pn.Controls.Add(this.label2);
            this.OutputOk_pn.Controls.Add(this.OutputLocation_txt);
            this.OutputOk_pn.Location = new System.Drawing.Point(22, 433);
            this.OutputOk_pn.Name = "OutputOk_pn";
            this.OutputOk_pn.Size = new System.Drawing.Size(1194, 149);
            this.OutputOk_pn.TabIndex = 12;
            // 
            // Output_date
            // 
            this.Output_date.CalendarFont = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Output_date.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Output_date.Location = new System.Drawing.Point(192, 92);
            this.Output_date.Name = "Output_date";
            this.Output_date.Size = new System.Drawing.Size(442, 44);
            this.Output_date.TabIndex = 4;
            // 
            // OutOkIn_bt
            // 
            this.OutOkIn_bt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutOkIn_bt.Location = new System.Drawing.Point(957, 20);
            this.OutOkIn_bt.Name = "OutOkIn_bt";
            this.OutOkIn_bt.Size = new System.Drawing.Size(121, 105);
            this.OutOkIn_bt.TabIndex = 0;
            this.OutOkIn_bt.Text = "등록";
            this.OutOkIn_bt.UseVisualStyleBackColor = true;
            this.OutOkIn_bt.Click += new System.EventHandler(this.OutOkIn_bt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(761, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OutputRegister_txt
            // 
            this.OutputRegister_txt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutputRegister_txt.Location = new System.Drawing.Point(169, 21);
            this.OutputRegister_txt.Name = "OutputRegister_txt";
            this.OutputRegister_txt.Size = new System.Drawing.Size(200, 44);
            this.OutputRegister_txt.TabIndex = 2;
            this.OutputRegister_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(15, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 49);
            this.label7.TabIndex = 1;
            this.label7.Text = "등록일";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "등록인";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(401, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "위치";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputLocation_txt
            // 
            this.OutputLocation_txt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutputLocation_txt.Location = new System.Drawing.Point(516, 21);
            this.OutputLocation_txt.Name = "OutputLocation_txt";
            this.OutputLocation_txt.Size = new System.Drawing.Size(200, 44);
            this.OutputLocation_txt.TabIndex = 2;
            this.OutputLocation_txt.Text = "구역";
            this.OutputLocation_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutOkCl_bt
            // 
            this.OutOkCl_bt.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutOkCl_bt.Location = new System.Drawing.Point(1035, 14);
            this.OutOkCl_bt.Name = "OutOkCl_bt";
            this.OutOkCl_bt.Size = new System.Drawing.Size(138, 44);
            this.OutOkCl_bt.TabIndex = 10;
            this.OutOkCl_bt.Text = "닫기";
            this.OutOkCl_bt.UseVisualStyleBackColor = true;
            this.OutOkCl_bt.Click += new System.EventHandler(this.OutOkCl_bt_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(891, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 44);
            this.button6.TabIndex = 11;
            this.button6.Text = "저장";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // OutputOkay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 594);
            this.Controls.Add(this.OutputOk_grid);
            this.Controls.Add(this.OutputOk_pn);
            this.Controls.Add(this.OutOkCl_bt);
            this.Controls.Add(this.button6);
            this.Name = "OutputOkay";
            this.Text = "출하검사완료";
            ((System.ComponentModel.ISupportInitialize)(this.OutputOk_grid)).EndInit();
            this.OutputOk_pn.ResumeLayout(false);
            this.OutputOk_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OutputOk_grid;
        private System.Windows.Forms.Panel OutputOk_pn;
        private System.Windows.Forms.DateTimePicker Output_date;
        private System.Windows.Forms.Button OutOkIn_bt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OutOkCl_bt;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputLocation_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputRegister_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspect2;
        private System.Windows.Forms.DataGridViewTextBoxColumn company2;
        private System.Windows.Forms.DataGridViewTextBoxColumn code2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn step2;
    }
}