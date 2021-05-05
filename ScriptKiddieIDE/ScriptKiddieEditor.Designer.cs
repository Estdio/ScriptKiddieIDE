
namespace scriptKiddieIDEditor
{
    partial class scriptKiddieEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scriptKiddieEditor));
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFle = new System.Windows.Forms.ToolStripButton();
            this.expCpp = new System.Windows.Forms.Button();
            this.expPhas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.darkModeToggle1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BookmarkColor = System.Drawing.Color.Red;
            this.fastColoredTextBox1.CaretColor = System.Drawing.Color.Red;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.SystemColors.ActiveBorder;
            this.fastColoredTextBox1.FoldingIndicatorColor = System.Drawing.Color.Red;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.Red;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.Red;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 28);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.Red;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(657, 421);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.TextAreaBorderColor = System.Drawing.Color.Red;
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // openFle
            // 
            this.openFle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFle.Image = ((System.Drawing.Image)(resources.GetObject("openFle.Image")));
            this.openFle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFle.Name = "openFle";
            this.openFle.Size = new System.Drawing.Size(23, 22);
            this.openFle.Text = "Open File";
            // 
            // expCpp
            // 
            this.expCpp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.expCpp.ForeColor = System.Drawing.Color.Red;
            this.expCpp.Location = new System.Drawing.Point(663, 41);
            this.expCpp.Name = "expCpp";
            this.expCpp.Size = new System.Drawing.Size(125, 46);
            this.expCpp.TabIndex = 2;
            this.expCpp.Text = "Export as Arduino C++";
            this.expCpp.UseVisualStyleBackColor = false;
            this.expCpp.Click += new System.EventHandler(this.expToCPP);
            // 
            // expPhas
            // 
            this.expPhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.expPhas.ForeColor = System.Drawing.Color.Red;
            this.expPhas.Location = new System.Drawing.Point(663, 106);
            this.expPhas.Name = "expPhas";
            this.expPhas.Size = new System.Drawing.Size(125, 46);
            this.expPhas.TabIndex = 3;
            this.expPhas.Text = "Export as YASKC Script";
            this.expPhas.UseVisualStyleBackColor = false;
            this.expPhas.Click += new System.EventHandler(this.exportToYASKC);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(663, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Transpile YASKC to C++";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.transpileToYASKC);
            // 
            // darkModeToggle1
            // 
            this.darkModeToggle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.darkModeToggle1.ForeColor = System.Drawing.Color.Red;
            this.darkModeToggle1.Location = new System.Drawing.Point(663, 376);
            this.darkModeToggle1.Name = "darkModeToggle1";
            this.darkModeToggle1.Size = new System.Drawing.Size(125, 46);
            this.darkModeToggle1.TabIndex = 5;
            this.darkModeToggle1.Text = "Dark Mode";
            this.darkModeToggle1.UseVisualStyleBackColor = false;
            this.darkModeToggle1.Click += new System.EventHandler(this.darkModeToggle);
            // 
            // phantomIDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.darkModeToggle1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expPhas);
            this.Controls.Add(this.expCpp);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "phantomIDE";
            this.Text = "Script Kiddie IDE";
            this.Load += new System.EventHandler(this.scriptKiddieIDE);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button expCpp;
        private System.Windows.Forms.Button expPhas;
        private System.Windows.Forms.ToolStripButton openFle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button darkModeToggle1;
    }
}

