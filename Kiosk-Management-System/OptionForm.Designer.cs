namespace Kiosk_Management_System
{
    partial class OptionForm
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
            this.btn_drinkInsert = new System.Windows.Forms.Button();
            this.btn_drinkDelete = new System.Windows.Forms.Button();
            this.btn_cusSelect = new System.Windows.Forms.Button();
            this.btn_cusDelete = new System.Windows.Forms.Button();
            this.btn_drinkSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salesSelect = new System.Windows.Forms.Button();
            this.btn_drinkUpdate = new System.Windows.Forms.Button();
            this.list_option = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_drinkInsert
            // 
            this.btn_drinkInsert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_drinkInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_drinkInsert.Location = new System.Drawing.Point(310, 30);
            this.btn_drinkInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_drinkInsert.Name = "btn_drinkInsert";
            this.btn_drinkInsert.Size = new System.Drawing.Size(93, 38);
            this.btn_drinkInsert.TabIndex = 1;
            this.btn_drinkInsert.Text = "음료 추가";
            this.btn_drinkInsert.UseVisualStyleBackColor = false;
            this.btn_drinkInsert.Click += new System.EventHandler(this.btn_drinkInsert_Click);
            // 
            // btn_drinkDelete
            // 
            this.btn_drinkDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_drinkDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_drinkDelete.Location = new System.Drawing.Point(407, 30);
            this.btn_drinkDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_drinkDelete.Name = "btn_drinkDelete";
            this.btn_drinkDelete.Size = new System.Drawing.Size(93, 38);
            this.btn_drinkDelete.TabIndex = 1;
            this.btn_drinkDelete.Text = "음료 삭제";
            this.btn_drinkDelete.UseVisualStyleBackColor = false;
            this.btn_drinkDelete.Click += new System.EventHandler(this.btn_drinkDelete_Click);
            // 
            // btn_cusSelect
            // 
            this.btn_cusSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_cusSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cusSelect.Location = new System.Drawing.Point(116, 80);
            this.btn_cusSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cusSelect.Name = "btn_cusSelect";
            this.btn_cusSelect.Size = new System.Drawing.Size(93, 38);
            this.btn_cusSelect.TabIndex = 1;
            this.btn_cusSelect.Text = "회원 조회";
            this.btn_cusSelect.UseVisualStyleBackColor = false;
            this.btn_cusSelect.Click += new System.EventHandler(this.btn_cusSelect_Click);
            // 
            // btn_cusDelete
            // 
            this.btn_cusDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_cusDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cusDelete.Location = new System.Drawing.Point(212, 80);
            this.btn_cusDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cusDelete.Name = "btn_cusDelete";
            this.btn_cusDelete.Size = new System.Drawing.Size(93, 38);
            this.btn_cusDelete.TabIndex = 1;
            this.btn_cusDelete.Text = "회원 삭제";
            this.btn_cusDelete.UseVisualStyleBackColor = false;
            this.btn_cusDelete.Click += new System.EventHandler(this.btn_cusDelete_Click);
            // 
            // btn_drinkSelect
            // 
            this.btn_drinkSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_drinkSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_drinkSelect.Location = new System.Drawing.Point(116, 30);
            this.btn_drinkSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_drinkSelect.Name = "btn_drinkSelect";
            this.btn_drinkSelect.Size = new System.Drawing.Size(93, 38);
            this.btn_drinkSelect.TabIndex = 1;
            this.btn_drinkSelect.Text = "음료 조회";
            this.btn_drinkSelect.UseVisualStyleBackColor = false;
            this.btn_drinkSelect.Click += new System.EventHandler(this.btn_drinkSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "음료 관리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "회원 관리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(324, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "매출 관리";
            // 
            // btn_salesSelect
            // 
            this.btn_salesSelect.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_salesSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salesSelect.Location = new System.Drawing.Point(407, 80);
            this.btn_salesSelect.Name = "btn_salesSelect";
            this.btn_salesSelect.Size = new System.Drawing.Size(93, 38);
            this.btn_salesSelect.TabIndex = 3;
            this.btn_salesSelect.Text = "매출 조회";
            this.btn_salesSelect.UseVisualStyleBackColor = false;
            this.btn_salesSelect.Click += new System.EventHandler(this.btn_salesSelect_Click);
            // 
            // btn_drinkUpdate
            // 
            this.btn_drinkUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_drinkUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9999F, System.Drawing.FontStyle.Bold);
            this.btn_drinkUpdate.Location = new System.Drawing.Point(212, 30);
            this.btn_drinkUpdate.Name = "btn_drinkUpdate";
            this.btn_drinkUpdate.Size = new System.Drawing.Size(93, 38);
            this.btn_drinkUpdate.TabIndex = 4;
            this.btn_drinkUpdate.Text = "음료 변경";
            this.btn_drinkUpdate.UseVisualStyleBackColor = false;
            this.btn_drinkUpdate.Click += new System.EventHandler(this.btn_drinkUpdate_Click);
            // 
            // list_option
            // 
            this.list_option.HideSelection = false;
            this.list_option.Location = new System.Drawing.Point(19, 139);
            this.list_option.Margin = new System.Windows.Forms.Padding(2);
            this.list_option.Name = "list_option";
            this.list_option.Size = new System.Drawing.Size(503, 439);
            this.list_option.TabIndex = 0;
            this.list_option.UseCompatibleStateImageBehavior = false;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(542, 598);
            this.Controls.Add(this.btn_drinkUpdate);
            this.Controls.Add(this.btn_salesSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cusDelete);
            this.Controls.Add(this.btn_drinkDelete);
            this.Controls.Add(this.btn_cusSelect);
            this.Controls.Add(this.btn_drinkSelect);
            this.Controls.Add(this.btn_drinkInsert);
            this.Controls.Add(this.list_option);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OptionForm";
            this.Text = "설정";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionForm_FormClosed);
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_drinkInsert;
        private System.Windows.Forms.Button btn_drinkDelete;
        private System.Windows.Forms.Button btn_cusSelect;
        private System.Windows.Forms.Button btn_cusDelete;
        private System.Windows.Forms.Button btn_drinkSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salesSelect;
        private System.Windows.Forms.Button btn_drinkUpdate;
        private System.Windows.Forms.ListView list_option;
    }
}