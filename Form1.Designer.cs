namespace Part_7___WinForms_ListBox_CSharp
{
    partial class frmListBoxes
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblNumbersTitle = new System.Windows.Forms.Label();
            this.lblHeroesTitle = new System.Windows.Forms.Label();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnClearHeroes = new System.Windows.Forms.Button();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.lblAddHero = new System.Windows.Forms.Label();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.btnSortHero = new System.Windows.Forms.Button();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.lblRemoveNumber = new System.Windows.Forms.Label();
            this.lblStatusUpdate = new System.Windows.Forms.Label();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.lblRemoveHero = new System.Windows.Forms.Label();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.btnSortNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 24;
            this.lstNumbers.Location = new System.Drawing.Point(86, 111);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(233, 148);
            this.lstNumbers.TabIndex = 0;
            this.lstNumbers.SelectedIndexChanged += new System.EventHandler(this.LstNumbers_SelectedIndexChanged);
            // 
            // lstHeroes
            // 
            this.lstHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.ItemHeight = 24;
            this.lstHeroes.Location = new System.Drawing.Point(344, 111);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(225, 148);
            this.lstHeroes.TabIndex = 1;
            // 
            // lblNumbersTitle
            // 
            this.lblNumbersTitle.AutoSize = true;
            this.lblNumbersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbersTitle.Location = new System.Drawing.Point(81, 36);
            this.lblNumbersTitle.Name = "lblNumbersTitle";
            this.lblNumbersTitle.Size = new System.Drawing.Size(105, 25);
            this.lblNumbersTitle.TabIndex = 2;
            this.lblNumbersTitle.Text = "Numbers";
            // 
            // lblHeroesTitle
            // 
            this.lblHeroesTitle.AutoSize = true;
            this.lblHeroesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroesTitle.Location = new System.Drawing.Point(338, 36);
            this.lblHeroesTitle.Name = "lblHeroesTitle";
            this.lblHeroesTitle.Size = new System.Drawing.Size(87, 25);
            this.lblHeroesTitle.TabIndex = 3;
            this.lblHeroesTitle.Text = "Heroes";
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(191, 320);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(128, 29);
            this.btnRemoveAllNumbers.TabIndex = 4;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.Location = new System.Drawing.Point(86, 71);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(120, 34);
            this.btnNewNumbers.TabIndex = 5;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            // 
            // btnClearHeroes
            // 
            this.btnClearHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHeroes.Location = new System.Drawing.Point(343, 71);
            this.btnClearHeroes.Name = "btnClearHeroes";
            this.btnClearHeroes.Size = new System.Drawing.Size(119, 34);
            this.btnClearHeroes.TabIndex = 6;
            this.btnClearHeroes.Text = "New List";
            this.btnClearHeroes.UseVisualStyleBackColor = true;
            // 
            // txtAddHero
            // 
            this.txtAddHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddHero.Location = new System.Drawing.Point(342, 320);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(146, 29);
            this.txtAddHero.TabIndex = 7;
            // 
            // lblAddHero
            // 
            this.lblAddHero.AutoSize = true;
            this.lblAddHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddHero.Location = new System.Drawing.Point(339, 276);
            this.lblAddHero.Name = "lblAddHero";
            this.lblAddHero.Size = new System.Drawing.Size(229, 24);
            this.lblAddHero.TabIndex = 8;
            this.lblAddHero.Text = "Enter a hero name to add:";
            // 
            // btnAddHero
            // 
            this.btnAddHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHero.Location = new System.Drawing.Point(494, 320);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(75, 29);
            this.btnAddHero.TabIndex = 9;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            // 
            // btnSortHero
            // 
            this.btnSortHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortHero.Location = new System.Drawing.Point(468, 71);
            this.btnSortHero.Name = "btnSortHero";
            this.btnSortHero.Size = new System.Drawing.Size(101, 34);
            this.btnSortHero.TabIndex = 10;
            this.btnSortHero.Text = "Sort";
            this.btnSortHero.UseVisualStyleBackColor = true;
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(86, 320);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(100, 29);
            this.btnRemoveNumber.TabIndex = 11;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            // 
            // lblRemoveNumber
            // 
            this.lblRemoveNumber.AutoSize = true;
            this.lblRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveNumber.Location = new System.Drawing.Point(82, 276);
            this.lblRemoveNumber.Name = "lblRemoveNumber";
            this.lblRemoveNumber.Size = new System.Drawing.Size(237, 24);
            this.lblRemoveNumber.TabIndex = 12;
            this.lblRemoveNumber.Text = "Select a number to remove";
            // 
            // lblStatusUpdate
            // 
            this.lblStatusUpdate.AutoSize = true;
            this.lblStatusUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusUpdate.Location = new System.Drawing.Point(12, 388);
            this.lblStatusUpdate.Name = "lblStatusUpdate";
            this.lblStatusUpdate.Size = new System.Drawing.Size(65, 24);
            this.lblStatusUpdate.TabIndex = 13;
            this.lblStatusUpdate.Text = "Status:";
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveHero.Location = new System.Drawing.Point(342, 388);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(119, 29);
            this.txtRemoveHero.TabIndex = 14;
            // 
            // lblRemoveHero
            // 
            this.lblRemoveHero.AutoSize = true;
            this.lblRemoveHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveHero.Location = new System.Drawing.Point(339, 361);
            this.lblRemoveHero.Name = "lblRemoveHero";
            this.lblRemoveHero.Size = new System.Drawing.Size(261, 24);
            this.lblRemoveHero.TabIndex = 15;
            this.lblRemoveHero.Text = "Enter a hero name to remove:";
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHero.Location = new System.Drawing.Point(468, 388);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(101, 29);
            this.btnRemoveHero.TabIndex = 16;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            // 
            // btnSortNumber
            // 
            this.btnSortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNumber.Location = new System.Drawing.Point(212, 71);
            this.btnSortNumber.Name = "btnSortNumber";
            this.btnSortNumber.Size = new System.Drawing.Size(107, 34);
            this.btnSortNumber.TabIndex = 17;
            this.btnSortNumber.Text = "Sort";
            this.btnSortNumber.UseVisualStyleBackColor = true;
            // 
            // frmListBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btnSortNumber);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.lblRemoveHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.lblStatusUpdate);
            this.Controls.Add(this.lblRemoveNumber);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.btnSortHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.lblAddHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.btnClearHeroes);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.lblHeroesTitle);
            this.Controls.Add(this.lblNumbersTitle);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Name = "frmListBoxes";
            this.Text = "Using Lists";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblNumbersTitle;
        private System.Windows.Forms.Label lblHeroesTitle;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnClearHeroes;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.Label lblAddHero;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnSortHero;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Label lblRemoveNumber;
        private System.Windows.Forms.Label lblStatusUpdate;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Label lblRemoveHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.Button btnSortNumber;
    }
}

