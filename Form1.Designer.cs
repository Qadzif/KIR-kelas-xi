namespace howto_graph_conic_section
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.clientSize = new System.Windows.Forms.Timer(this.components);
            this.coor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.accur = new System.Windows.Forms.TextBox();
            this.cekCoor = new System.Windows.Forms.CheckBox();
            this.cekGrad = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tangent1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tangent2 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(35, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(159, 20);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(35, 38);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(159, 20);
            this.txtB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B:";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(35, 90);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(159, 20);
            this.txtD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "D:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(35, 64);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(159, 20);
            this.txtC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "C:";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(35, 142);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(159, 20);
            this.txtF.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "F:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(35, 116);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(159, 20);
            this.txtE.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "E:";
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(74, 168);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 12;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.Color.White;
            this.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraph.Location = new System.Drawing.Point(200, 12);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(368, 409);
            this.picGraph.TabIndex = 13;
            this.picGraph.TabStop = false;
            this.picGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clientDown);
            this.picGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clientUp);
            this.picGraph.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.clientScroll);
            // 
            // clientSize
            // 
            this.clientSize.Enabled = true;
            this.clientSize.Interval = 1;
            this.clientSize.Tick += new System.EventHandler(this.reSize);
            // 
            // coor
            // 
            this.coor.Location = new System.Drawing.Point(35, 197);
            this.coor.Name = "coor";
            this.coor.Size = new System.Drawing.Size(138, 20);
            this.coor.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "x,y";
            // 
            // grad
            // 
            this.grad.Location = new System.Drawing.Point(35, 223);
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(138, 20);
            this.grad.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "m";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Tangent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.findTangent);
            // 
            // accur
            // 
            this.accur.Location = new System.Drawing.Point(35, 384);
            this.accur.Name = "accur";
            this.accur.Size = new System.Drawing.Size(159, 20);
            this.accur.TabIndex = 25;
            this.accur.Text = "0.01";
            this.accur.TextChanged += new System.EventHandler(this.changeAcc);
            // 
            // cekCoor
            // 
            this.cekCoor.AutoSize = true;
            this.cekCoor.Checked = true;
            this.cekCoor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cekCoor.Location = new System.Drawing.Point(179, 200);
            this.cekCoor.Name = "cekCoor";
            this.cekCoor.Size = new System.Drawing.Size(15, 14);
            this.cekCoor.TabIndex = 19;
            this.cekCoor.UseVisualStyleBackColor = true;
            // 
            // cekGrad
            // 
            this.cekGrad.AutoSize = true;
            this.cekGrad.Checked = true;
            this.cekGrad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cekGrad.Location = new System.Drawing.Point(179, 226);
            this.cekGrad.Name = "cekGrad";
            this.cekGrad.Size = new System.Drawing.Size(15, 14);
            this.cekGrad.TabIndex = 22;
            this.cekGrad.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 278);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(159, 100);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tangent1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(151, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "(x,y) Tangent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tangent1
            // 
            this.tangent1.Location = new System.Drawing.Point(0, 0);
            this.tangent1.Name = "tangent1";
            this.tangent1.Size = new System.Drawing.Size(151, 74);
            this.tangent1.TabIndex = 27;
            this.tangent1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tangent2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(151, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "m Tangent";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tangent2
            // 
            this.tangent2.Location = new System.Drawing.Point(0, 0);
            this.tangent2.Name = "tangent2";
            this.tangent2.Size = new System.Drawing.Size(151, 74);
            this.tangent2.TabIndex = 28;
            this.tangent2.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Accuration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::howto_graph_conic_section.Properties.Resources.CodeCogsEqn;
            this.pictureBox1.Location = new System.Drawing.Point(200, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 17);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGraph;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cekGrad);
            this.Controls.Add(this.cekCoor);
            this.Controls.Add(this.accur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.coor);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(478, 303);
            this.Name = "Form1";
            this.Text = "Irisan Kerucut dan Garis Singgung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.Timer clientSize;
        private System.Windows.Forms.TextBox coor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox grad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox accur;
        private System.Windows.Forms.CheckBox cekCoor;
        private System.Windows.Forms.CheckBox cekGrad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox tangent1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox tangent2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

