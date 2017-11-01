namespace LTSEDemo
{
    partial class processExcFiles
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
            this.btnProcessFiles = new System.Windows.Forms.Button();
            this.textTotalRecords = new System.Windows.Forms.TextBox();
            this.textAccepted = new System.Windows.Forms.TextBox();
            this.textRejected = new System.Windows.Forms.TextBox();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcessFiles
            // 
            this.btnProcessFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessFiles.Location = new System.Drawing.Point(286, 27);
            this.btnProcessFiles.Name = "btnProcessFiles";
            this.btnProcessFiles.Size = new System.Drawing.Size(291, 93);
            this.btnProcessFiles.TabIndex = 0;
            this.btnProcessFiles.Text = "Process Exchange Files";
            this.btnProcessFiles.UseVisualStyleBackColor = true;
            this.btnProcessFiles.Click += new System.EventHandler(this.btnProcessFiles_Click);
            // 
            // textTotalRecords
            // 
            this.textTotalRecords.BackColor = System.Drawing.SystemColors.Control;
            this.textTotalRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalRecords.Location = new System.Drawing.Point(236, 210);
            this.textTotalRecords.Name = "textTotalRecords";
            this.textTotalRecords.Size = new System.Drawing.Size(561, 22);
            this.textTotalRecords.TabIndex = 1;
            // 
            // textAccepted
            // 
            this.textAccepted.BackColor = System.Drawing.SystemColors.Control;
            this.textAccepted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAccepted.Location = new System.Drawing.Point(236, 248);
            this.textAccepted.Name = "textAccepted";
            this.textAccepted.Size = new System.Drawing.Size(561, 22);
            this.textAccepted.TabIndex = 2;
            // 
            // textRejected
            // 
            this.textRejected.BackColor = System.Drawing.SystemColors.Control;
            this.textRejected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRejected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRejected.Location = new System.Drawing.Point(236, 286);
            this.textRejected.Name = "textRejected";
            this.textRejected.Size = new System.Drawing.Size(561, 22);
            this.textRejected.TabIndex = 3;
            // 
            // textNotes
            // 
            this.textNotes.BackColor = System.Drawing.SystemColors.Control;
            this.textNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNotes.Location = new System.Drawing.Point(41, 324);
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(950, 53);
            this.textNotes.TabIndex = 4;
            // 
            // processExcFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 403);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.textRejected);
            this.Controls.Add(this.textAccepted);
            this.Controls.Add(this.textTotalRecords);
            this.Controls.Add(this.btnProcessFiles);
            this.Name = "processExcFiles";
            this.Text = "Process Exchange Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessFiles;
        private System.Windows.Forms.TextBox textTotalRecords;
        private System.Windows.Forms.TextBox textAccepted;
        private System.Windows.Forms.TextBox textRejected;
        private System.Windows.Forms.TextBox textNotes;
    }
}

