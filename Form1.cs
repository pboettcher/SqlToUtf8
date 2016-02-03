using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SqlToUtf8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void log(string msg, Color? color = null)
        {
            logl(msg, color);
            LogBox.AppendText(System.Environment.NewLine);
        }

        private void logl(string msg, Color? color = null)
        {
            int start = LogBox.TextLength;
            LogBox.AppendText(msg);
            int end = LogBox.TextLength;
            LogBox.Select(start, end - start);
            LogBox.SelectionColor = color.GetValueOrDefault(Color.Black);
            LogBox.SelectionLength = 0;
        }

        enum BomType
        {
            Unknown,
            Unicode,
            UTF8
        }

        private BomType detectEncoding(string fname)
        {
            BomType res = BomType.Unknown;
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                byte[] bits = new byte[3];
                fs.Read(bits, 0, 3);
                fs.Close();
                // UTF8 byte order mark is: 0xEF,0xBB,0xBF
                if (bits[0] == 0xEF && bits[1] == 0xBB && bits[2] == 0xBF)
                    res = BomType.UTF8;
                // UTF8 byte order mark is: 0xEF,0xBB,0xBF
                if (bits[0] == 0xFF && bits[1] == 0xFE)
                    res = BomType.Unicode;
            }
            return res;
        }

        private void convertFile(string fname)
        {
            File.WriteAllText(fname, File.ReadAllText(fname, Encoding.Unicode), Encoding.UTF8);
        }

        private void processFile(string fname)
        {
            logl(Path.GetFileName(fname));
            BomType enc = detectEncoding(fname);
            switch (enc)
            {
                case BomType.Unknown:
                    log(" - Unknown BOM", Color.Red);
                    break;
                case BomType.Unicode:
                    convertFile(fname);
                    log(" - Converted", Color.Green);
                    break;
                case BomType.UTF8:
                    log(" - Already UTF-8", Color.Purple);
                    break;
                default:
                    log(" - Unknown BOM", Color.Red);
                    break;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            LogBox.Clear();
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            log(string.Format("Scanning {0}", dir));
            string[] files = Directory.GetFiles(dir, "*.sql");
            if (files.Length == 0)
                log("No *.sql files found.");
            else
            {
                log(string.Format("{0} files found.", files.Length));
                foreach (string fname in files)
                    processFile(fname);
            }
        }
    }
}
