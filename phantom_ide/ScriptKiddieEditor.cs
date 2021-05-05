using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Threading;

namespace scriptKiddieIDEditor
{
    public partial class scriptKiddieEditor : Form
    {
        public scriptKiddieEditor()
        {
            InitializeComponent();
        }

        private void scriptKiddieIDE(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFileDialog fledlg = new OpenFileDialog();
            if (fledlg.ShowDialog() == DialogResult.OK)
            {
                fledlg.Title = "open";
                fastColoredTextBox1.Text = File.ReadAllText(fledlg.FileName);
            }
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void expToCPP(object sender, EventArgs e)
        {
            string filename = Interaction.InputBox("", "Save File", "supercoolawesomecpp", 100, 100);
            try
            {
                string path = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cpp"), filename + ".ino");
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }

            catch (Exception)
            {

            }
        }


        private void exportToYASKC(object sender, EventArgs e)
        {
            string filename = Interaction.InputBox("", "Save File", "supercoolawesomescript", 100, 100);
            try
            {
                string path = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts"), filename + ".yaskc");
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }

            catch (Exception)
            {

            }
        }

        private void transpileToYASKC(object sender, EventArgs e)
        {

            try
            {
                using (Stream s = File.Open("temp.yaskc", FileMode.Open))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }

            catch (FileNotFoundException)
            {
                using (Stream s = File.Open("temp.yaskc", FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
            string path = Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(path+"\\"+"phantomTranspiler.exe");
            Thread.Sleep(2000);
            File.Delete(Path.Combine("temp.yaskc"));
        }

        private void darkModeToggle(object sender, EventArgs e)
        {
            MessageBox.Show("No dark mode for you", "Cope", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
