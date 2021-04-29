
namespace Final_Project___Ben_Kelley
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_GenFact = new System.Windows.Forms.Button();
            this.btn_Dlt = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_SaveID = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_Fact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.test1 = new System.Windows.Forms.Label();
            this.lbl_Num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(533, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(711, 436);
            this.listBox1.TabIndex = 0;
            // 
            // btn_GenFact
            // 
            this.btn_GenFact.Location = new System.Drawing.Point(55, 47);
            this.btn_GenFact.Name = "btn_GenFact";
            this.btn_GenFact.Size = new System.Drawing.Size(119, 50);
            this.btn_GenFact.TabIndex = 1;
            this.btn_GenFact.Text = "Generate New Fact";
            this.btn_GenFact.UseVisualStyleBackColor = true;
            this.btn_GenFact.Click += new System.EventHandler(this.btn_GenFact_Click);
            // 
            // btn_Dlt
            // 
            this.btn_Dlt.Location = new System.Drawing.Point(391, 47);
            this.btn_Dlt.Name = "btn_Dlt";
            this.btn_Dlt.Size = new System.Drawing.Size(119, 50);
            this.btn_Dlt.TabIndex = 2;
            this.btn_Dlt.Text = "Delete Fact";
            this.btn_Dlt.UseVisualStyleBackColor = true;
            this.btn_Dlt.Click += new System.EventHandler(this.btn_Dlt_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(55, 181);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(119, 50);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_SaveID
            // 
            this.btn_SaveID.Location = new System.Drawing.Point(229, 181);
            this.btn_SaveID.Name = "btn_SaveID";
            this.btn_SaveID.Size = new System.Drawing.Size(119, 50);
            this.btn_SaveID.TabIndex = 4;
            this.btn_SaveID.Text = "Show Saved ID\'s";
            this.btn_SaveID.UseVisualStyleBackColor = true;
            this.btn_SaveID.Click += new System.EventHandler(this.btn_SaveID_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(229, 75);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(119, 22);
            this.txt_ID.TabIndex = 5;
            // 
            // btn_Fact
            // 
            this.btn_Fact.Location = new System.Drawing.Point(391, 181);
            this.btn_Fact.Name = "btn_Fact";
            this.btn_Fact.Size = new System.Drawing.Size(119, 50);
            this.btn_Fact.TabIndex = 6;
            this.btn_Fact.Text = "Show Fact";
            this.btn_Fact.UseVisualStyleBackColor = true;
            this.btn_Fact.Click += new System.EventHandler(this.btn_Fact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 187);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.Location = new System.Drawing.Point(13, 4);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(62, 17);
            this.test1.TabIndex = 8;
            this.test1.Text = "Number:";
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.Location = new System.Drawing.Point(81, 4);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(0, 17);
            this.lbl_Num.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 489);
            this.Controls.Add(this.lbl_Num);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Fact);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_SaveID);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Dlt);
            this.Controls.Add(this.btn_GenFact);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_GenFact;
        private System.Windows.Forms.Button btn_Dlt;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_SaveID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_Fact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label test1;
        private System.Windows.Forms.Label lbl_Num;
    }
}

