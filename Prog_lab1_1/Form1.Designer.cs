namespace Prog_lab1_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewGeneration = new System.Windows.Forms.DataGridView();
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.dataGridViewChange = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChange)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGeneration
            // 
            this.dataGridViewGeneration.AllowUserToDeleteRows = false;
            this.dataGridViewGeneration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneration.Location = new System.Drawing.Point(31, 42);
            this.dataGridViewGeneration.Name = "dataGridViewGeneration";
            this.dataGridViewGeneration.ReadOnly = true;
            this.dataGridViewGeneration.RowTemplate.Height = 25;
            this.dataGridViewGeneration.Size = new System.Drawing.Size(544, 124);
            this.dataGridViewGeneration.TabIndex = 0;
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.Location = new System.Drawing.Point(31, 13);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(133, 23);
            this.buttonGeneration.TabIndex = 1;
            this.buttonGeneration.Text = "Сгенерировать";
            this.buttonGeneration.UseVisualStyleBackColor = true;
            this.buttonGeneration.Click += new System.EventHandler(this.ButtonGeneration_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(31, 172);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(133, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Переставить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // dataGridViewChange
            // 
            this.dataGridViewChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChange.Location = new System.Drawing.Point(31, 201);
            this.dataGridViewChange.Name = "dataGridViewChange";
            this.dataGridViewChange.ReadOnly = true;
            this.dataGridViewChange.RowTemplate.Height = 25;
            this.dataGridViewChange.Size = new System.Drawing.Size(544, 124);
            this.dataGridViewChange.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 343);
            this.Controls.Add(this.dataGridViewChange);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonGeneration);
            this.Controls.Add(this.dataGridViewGeneration);
            this.Name = "Form1";
            this.Text = "lab1_1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewGeneration;
        private Button buttonGeneration;
        private Button buttonChange;
        private DataGridView dataGridViewChange;
    }
}