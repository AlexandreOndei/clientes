namespace Cliente.Utility
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
            this.tcPages = new System.Windows.Forms.TabControl();
            this.tbStatus = new System.Windows.Forms.TabPage();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.tbScript = new System.Windows.Forms.TabPage();
            this.txtScript = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.tcPages.SuspendLayout();
            this.tbStatus.SuspendLayout();
            this.tbScript.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPages
            // 
            this.tcPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPages.Controls.Add(this.tbStatus);
            this.tcPages.Controls.Add(this.tbScript);
            this.tcPages.Location = new System.Drawing.Point(3, 3);
            this.tcPages.Name = "tcPages";
            this.tcPages.SelectedIndex = 0;
            this.tcPages.Size = new System.Drawing.Size(794, 400);
            this.tcPages.TabIndex = 0;
            // 
            // tbStatus
            // 
            this.tbStatus.Controls.Add(this.lstStatus);
            this.tbStatus.Location = new System.Drawing.Point(4, 22);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tbStatus.Size = new System.Drawing.Size(786, 374);
            this.tbStatus.TabIndex = 0;
            this.tbStatus.Text = "Status";
            this.tbStatus.UseVisualStyleBackColor = true;
            // 
            // lstStatus
            // 
            this.lstStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(3, 3);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(780, 368);
            this.lstStatus.TabIndex = 0;
            // 
            // tbScript
            // 
            this.tbScript.Controls.Add(this.txtScript);
            this.tbScript.Location = new System.Drawing.Point(4, 22);
            this.tbScript.Name = "tbScript";
            this.tbScript.Padding = new System.Windows.Forms.Padding(3);
            this.tbScript.Size = new System.Drawing.Size(786, 374);
            this.tbScript.TabIndex = 1;
            this.tbScript.Text = "Script SQL";
            this.tbScript.UseVisualStyleBackColor = true;
            // 
            // txtScript
            // 
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScript.Location = new System.Drawing.Point(3, 3);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(780, 368);
            this.txtScript.TabIndex = 0;
            this.txtScript.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tcPages, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.555555F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 38);
            this.panel1.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(691, 0);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(100, 35);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "&Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Municípios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcPages.ResumeLayout(false);
            this.tbStatus.ResumeLayout(false);
            this.tbScript.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPages;
        private System.Windows.Forms.TabPage tbStatus;
        private System.Windows.Forms.TabPage tbScript;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.RichTextBox txtScript;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExecutar;
    }
}

