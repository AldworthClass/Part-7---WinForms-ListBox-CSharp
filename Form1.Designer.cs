namespace Part_7___WinForms_ListBox_CSharp
{
    partial class Form1
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
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(86, 100);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(212, 160);
            this.lstNumbers.TabIndex = 0;
            
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(343, 100);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(186, 160);
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
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(192, 279);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveAllNumbers.TabIndex = 4;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Location = new System.Drawing.Point(86, 71);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(120, 23);
            this.btnNewNumbers.TabIndex = 5;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            // 
            // btnClearHeroes
            // 
            this.btnClearHeroes.Location = new System.Drawing.Point(343, 71);
            this.btnClearHeroes.Name = "btnClearHeroes";
            this.btnClearHeroes.Size = new System.Drawing.Size(94, 23);
            this.btnClearHeroes.TabIndex = 6;
            this.btnClearHeroes.Text = "New List";
            this.btnClearHeroes.UseVisualStyleBackColor = true;
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(343, 281);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(100, 20);
            this.txtAddHero.TabIndex = 7;
            // 
            // lblAddHero
            // 
            this.lblAddHero.AutoSize = true;
            this.lblAddHero.Location = new System.Drawing.Point(340, 265);
            this.lblAddHero.Name = "lblAddHero";
            this.lblAddHero.Size = new System.Drawing.Size(130, 13);
            this.lblAddHero.TabIndex = 8;
            this.lblAddHero.Text = "Enter a hero name to add:";
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(454, 281);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(75, 21);
            this.btnAddHero.TabIndex = 9;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            // 
            // btnSortHero
            // 
            this.btnSortHero.Location = new System.Drawing.Point(443, 71);
            this.btnSortHero.Name = "btnSortHero";
            this.btnSortHero.Size = new System.Drawing.Size(86, 23);
            this.btnSortHero.TabIndex = 10;
            this.btnSortHero.Text = "Sort";
            this.btnSortHero.UseVisualStyleBackColor = true;
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Location = new System.Drawing.Point(86, 279);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveNumber.TabIndex = 11;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            // 
            // lblRemoveNumber
            // 
            this.lblRemoveNumber.AutoSize = true;
            this.lblRemoveNumber.Location = new System.Drawing.Point(83, 263);
            this.lblRemoveNumber.Name = "lblRemoveNumber";
            this.lblRemoveNumber.Size = new System.Drawing.Size(134, 13);
            this.lblRemoveNumber.TabIndex = 12;
            this.lblRemoveNumber.Text = "Select a number to remove";
            // 
            // lblStatusUpdate
            // 
            this.lblStatusUpdate.AutoSize = true;
            this.lblStatusUpdate.Location = new System.Drawing.Point(83, 409);
            this.lblStatusUpdate.Name = "lblStatusUpdate";
            this.lblStatusUpdate.Size = new System.Drawing.Size(40, 13);
            this.lblStatusUpdate.TabIndex = 13;
            this.lblStatusUpdate.Text = "Status:";
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(343, 336);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveHero.TabIndex = 14;
            // 
            // lblRemoveHero
            // 
            this.lblRemoveHero.AutoSize = true;
            this.lblRemoveHero.Location = new System.Drawing.Point(340, 320);
            this.lblRemoveHero.Name = "lblRemoveHero";
            this.lblRemoveHero.Size = new System.Drawing.Size(147, 13);
            this.lblRemoveHero.TabIndex = 15;
            this.lblRemoveHero.Text = "Enter a hero name to remove:";
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(454, 336);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHero.TabIndex = 16;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            // 
            // btnSortNumber
            // 
            this.btnSortNumber.Location = new System.Drawing.Point(212, 71);
            this.btnSortNumber.Name = "btnSortNumber";
            this.btnSortNumber.Size = new System.Drawing.Size(86, 23);
            this.btnSortNumber.TabIndex = 17;
            this.btnSortNumber.Text = "Sort";
            this.btnSortNumber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
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
            this.Name = "Form1";
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

