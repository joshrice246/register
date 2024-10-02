namespace register
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
            this.redacted1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.redacted2 = new System.Windows.Forms.Label();
            this.redacted3 = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.recipt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input9 = new System.Windows.Forms.TextBox();
            this.subtotallabel = new System.Windows.Forms.Label();
            this.taxlabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.changelabel = new System.Windows.Forms.Label();
            this.printt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // redacted1
            // 
            this.redacted1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redacted1.Location = new System.Drawing.Point(33, 126);
            this.redacted1.Name = "redacted1";
            this.redacted1.Size = new System.Drawing.Size(100, 23);
            this.redacted1.TabIndex = 0;
            this.redacted1.Text = "[redacted]";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(139, 123);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(133, 20);
            this.input1.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(139, 162);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(133, 20);
            this.input2.TabIndex = 4;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(139, 204);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(133, 20);
            this.input3.TabIndex = 5;
            // 
            // redacted2
            // 
            this.redacted2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redacted2.Location = new System.Drawing.Point(33, 162);
            this.redacted2.Name = "redacted2";
            this.redacted2.Size = new System.Drawing.Size(100, 23);
            this.redacted2.TabIndex = 12;
            this.redacted2.Text = "[redacted]";
            // 
            // redacted3
            // 
            this.redacted3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redacted3.Location = new System.Drawing.Point(33, 204);
            this.redacted3.Name = "redacted3";
            this.redacted3.Size = new System.Drawing.Size(100, 23);
            this.redacted3.TabIndex = 13;
            this.redacted3.Text = "[redacted]";
            // 
            // tax
            // 
            this.tax.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(33, 352);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(100, 23);
            this.tax.TabIndex = 14;
            this.tax.Text = "tax";
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(33, 547);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(100, 23);
            this.change.TabIndex = 15;
            this.change.Text = "change";
            this.change.Click += new System.EventHandler(this.label5_Click);
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(33, 397);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 23);
            this.total.TabIndex = 16;
            this.total.Text = "total";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(612, 98);
            this.label7.TabIndex = 17;
            this.label7.Text = "John Pork\'s Explosives Tm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // recipt
            // 
            this.recipt.BackColor = System.Drawing.Color.White;
            this.recipt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipt.Location = new System.Drawing.Point(348, 122);
            this.recipt.Name = "recipt";
            this.recipt.Size = new System.Drawing.Size(223, 431);
            this.recipt.TabIndex = 18;
            this.recipt.Click += new System.EventHandler(this.recipt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(284, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "very illegal";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(73, 264);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(223, 23);
            this.b.TabIndex = 21;
            this.b.Text = "Calculate";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(33, 314);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(100, 23);
            this.sub.TabIndex = 23;
            this.sub.Text = "subtotal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "tendered";
            // 
            // input9
            // 
            this.input9.Location = new System.Drawing.Point(139, 442);
            this.input9.Name = "input9";
            this.input9.Size = new System.Drawing.Size(133, 20);
            this.input9.TabIndex = 25;
            // 
            // subtotallabel
            // 
            this.subtotallabel.BackColor = System.Drawing.Color.White;
            this.subtotallabel.Location = new System.Drawing.Point(143, 317);
            this.subtotallabel.Name = "subtotallabel";
            this.subtotallabel.Size = new System.Drawing.Size(128, 19);
            this.subtotallabel.TabIndex = 27;
            // 
            // taxlabel
            // 
            this.taxlabel.BackColor = System.Drawing.Color.White;
            this.taxlabel.Location = new System.Drawing.Point(144, 356);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(128, 19);
            this.taxlabel.TabIndex = 28;
            // 
            // totallabel
            // 
            this.totallabel.BackColor = System.Drawing.Color.White;
            this.totallabel.Location = new System.Drawing.Point(143, 397);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(128, 19);
            this.totallabel.TabIndex = 29;
            // 
            // changelabel
            // 
            this.changelabel.BackColor = System.Drawing.Color.White;
            this.changelabel.Location = new System.Drawing.Point(143, 547);
            this.changelabel.Name = "changelabel";
            this.changelabel.Size = new System.Drawing.Size(128, 19);
            this.changelabel.TabIndex = 30;
            // 
            // printt
            // 
            this.printt.Location = new System.Drawing.Point(364, 573);
            this.printt.Name = "printt";
            this.printt.Size = new System.Drawing.Size(194, 23);
            this.printt.TabIndex = 31;
            this.printt.Text = "print";
            this.printt.UseVisualStyleBackColor = true;
            this.printt.Click += new System.EventHandler(this.printt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(613, 606);
            this.Controls.Add(this.printt);
            this.Controls.Add(this.changelabel);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.taxlabel);
            this.Controls.Add(this.subtotallabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.recipt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total);
            this.Controls.Add(this.change);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.redacted3);
            this.Controls.Add(this.redacted2);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.redacted1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label redacted1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Label redacted2;
        private System.Windows.Forms.Label redacted3;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label7;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label recipt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.Label subtotallabel;
        private System.Windows.Forms.Label changelabel;
        private System.Windows.Forms.Button printt;
    }
}

