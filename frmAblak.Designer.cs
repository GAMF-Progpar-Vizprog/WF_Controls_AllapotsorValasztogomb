
namespace AllapotsorValasztogomb
{
	partial class frmAblak
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
		//	this.components = new System.ComponentModel.Container();
			//this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			//this.ClientSize = new System.Drawing.Size(800, 450);
			//this.Text = "Form1";


      this.components = new System.ComponentModel.Container();
      this.ssÁllapotSor = new System.Windows.Forms.StatusStrip();
      this.tssElső = new System.Windows.Forms.ToolStripStatusLabel();
      this.tssMásodik = new System.Windows.Forms.ToolStripStatusLabel();
      this.tssHarmadik = new System.Windows.Forms.ToolStripStatusLabel();
      this.tssNegyedik = new System.Windows.Forms.ToolStripStatusLabel();
      this.label1 = new System.Windows.Forms.Label();
      this.gbPanelVálasztás = new System.Windows.Forms.GroupBox();
      this.rbNegyedik = new System.Windows.Forms.RadioButton();
      this.rbHarmadik = new System.Windows.Forms.RadioButton();
      this.rbMásodik = new System.Windows.Forms.RadioButton();
      this.tbSzöveg = new System.Windows.Forms.TextBox();
      this.btBeír = new System.Windows.Forms.Button();
      this.tIdőzítő = new System.Windows.Forms.Timer(this.components);
      this.ssÁllapotSor.SuspendLayout();
      this.gbPanelVálasztás.SuspendLayout();
      this.SuspendLayout();
      // 
      // ssÁllapotSor
      // 
      this.ssÁllapotSor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssElső,
            this.tssMásodik,
            this.tssHarmadik,
            this.tssNegyedik});
      this.ssÁllapotSor.Location = new System.Drawing.Point(0, 175);
      this.ssÁllapotSor.Name = "ssÁllapotSor";
      this.ssÁllapotSor.Size = new System.Drawing.Size(450, 22);
      this.ssÁllapotSor.TabIndex = 0;
      this.ssÁllapotSor.Text = "statusStrip1";
      // 
      // tssElső
      // 
      this.tssElső.AutoSize = false;
      this.tssElső.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.tssElső.Name = "tssElső";
      this.tssElső.Size = new System.Drawing.Size(100, 17);
      this.tssElső.Text = " ";
      // 
      // tssMásodik
      // 
      this.tssMásodik.AutoSize = false;
      this.tssMásodik.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.tssMásodik.Name = "tssMásodik";
      this.tssMásodik.Size = new System.Drawing.Size(100, 17);
      this.tssMásodik.Text = " ";
      // 
      // tssHarmadik
      // 
      this.tssHarmadik.AutoSize = false;
      this.tssHarmadik.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.tssHarmadik.Name = "tssHarmadik";
      this.tssHarmadik.Size = new System.Drawing.Size(100, 17);
      this.tssHarmadik.Text = " ";
      // 
      // tssNegyedik
      // 
      this.tssNegyedik.AutoSize = false;
      this.tssNegyedik.Name = "tssNegyedik";
      this.tssNegyedik.Size = new System.Drawing.Size(100, 17);
      this.tssNegyedik.Text = "  ";
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(377, 41);
      this.label1.TabIndex = 1;
      this.label1.Text = "Az gombon történő kattintás hatására a szövegmezőbe írt érték  az állapotsor kivá" +
          "lasztott paneljére kerül.";
      // 
      // gbPanelVálasztás
      // 
      this.gbPanelVálasztás.Controls.Add(this.rbNegyedik);
      this.gbPanelVálasztás.Controls.Add(this.rbHarmadik);
      this.gbPanelVálasztás.Controls.Add(this.rbMásodik);
      this.gbPanelVálasztás.Location = new System.Drawing.Point(12, 57);
      this.gbPanelVálasztás.Name = "gbPanelVálasztás";
      this.gbPanelVálasztás.Size = new System.Drawing.Size(99, 100);
      this.gbPanelVálasztás.TabIndex = 5;
      this.gbPanelVálasztás.TabStop = false;
      this.gbPanelVálasztás.Text = "Panelválasztás";
      // 
      // rbNegyedik
      // 
      this.rbNegyedik.AutoSize = true;
      this.rbNegyedik.Location = new System.Drawing.Point(6, 66);
      this.rbNegyedik.Name = "rbNegyedik";
      this.rbNegyedik.Size = new System.Drawing.Size(70, 17);
      this.rbNegyedik.TabIndex = 0;
      this.rbNegyedik.Text = "Negyedik";
      this.rbNegyedik.UseVisualStyleBackColor = true;
      this.rbNegyedik.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // rbHarmadik
      // 
      this.rbHarmadik.AutoSize = true;
      this.rbHarmadik.Location = new System.Drawing.Point(6, 43);
      this.rbHarmadik.Name = "rbHarmadik";
      this.rbHarmadik.Size = new System.Drawing.Size(70, 17);
      this.rbHarmadik.TabIndex = 0;
      this.rbHarmadik.Text = "Harmadik";
      this.rbHarmadik.UseVisualStyleBackColor = true;
      this.rbHarmadik.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // rbMásodik
      // 
      this.rbMásodik.AutoSize = true;
      this.rbMásodik.Checked = true;
      this.rbMásodik.Location = new System.Drawing.Point(6, 19);
      this.rbMásodik.Name = "rbMásodik";
      this.rbMásodik.Size = new System.Drawing.Size(65, 17);
      this.rbMásodik.TabIndex = 0;
      this.rbMásodik.TabStop = true;
      this.rbMásodik.Text = "Második";
      this.rbMásodik.UseVisualStyleBackColor = true;
      this.rbMásodik.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // tbSzöveg
      // 
      this.tbSzöveg.Location = new System.Drawing.Point(129, 75);
      this.tbSzöveg.Name = "tbSzöveg";
      this.tbSzöveg.Size = new System.Drawing.Size(129, 20);
      this.tbSzöveg.TabIndex = 7;
      // 
      // btBeír
      // 
      this.btBeír.Location = new System.Drawing.Point(154, 120);
      this.btBeír.Name = "btBeír";
      this.btBeír.Size = new System.Drawing.Size(75, 23);
      this.btBeír.TabIndex = 6;
      this.btBeír.Text = "&Beír";
      this.btBeír.Click += new System.EventHandler(this.btBeír_Click);
      // 
      // tIdőzítő
      // 
      this.tIdőzítő.Tick += new System.EventHandler(this.tIdőzítő_Tick);
      // 
      // frmAblak
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 197);
      this.Controls.Add(this.tbSzöveg);
      this.Controls.Add(this.btBeír);
      this.Controls.Add(this.gbPanelVálasztás);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ssÁllapotSor);
      this.Name = "frmAblak";
      this.Text = "Állapotsor használata";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAblak_FormClosing);
      this.ssÁllapotSor.ResumeLayout(false);
      this.ssÁllapotSor.PerformLayout();
      this.gbPanelVálasztás.ResumeLayout(false);
      this.gbPanelVálasztás.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();



    }

    #endregion

    private System.Windows.Forms.StatusStrip ssÁllapotSor;
    private System.Windows.Forms.ToolStripStatusLabel tssElső;
    private System.Windows.Forms.ToolStripStatusLabel tssMásodik;
    private System.Windows.Forms.ToolStripStatusLabel tssHarmadik;
    private System.Windows.Forms.ToolStripStatusLabel tssNegyedik;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox gbPanelVálasztás;
    private System.Windows.Forms.RadioButton rbNegyedik;
    private System.Windows.Forms.RadioButton rbHarmadik;
    private System.Windows.Forms.RadioButton rbMásodik;
    private System.Windows.Forms.TextBox tbSzöveg;
    private System.Windows.Forms.Button btBeír;
    private System.Windows.Forms.Timer tIdőzítő;

  }
}

