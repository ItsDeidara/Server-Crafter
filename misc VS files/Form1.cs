using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net;
using MetroFramework;
using System.Media;

namespace WindowsFormsApplication5
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();
            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                //List Client side mods to remove here
                string client1 = "optifine";
                string client2 = "journeymap";
                string client3 = "fastcraft";

                //search for clients in the selected folder
                string[] Files = Directory.GetFiles(fbd.SelectedPath);
                foreach (string file in Files)
                {
                    //calls client side mods that you defined above
                    if (file.ToUpper().Contains(client1.ToUpper()))
                    {
                        File.Delete(file);
                    }
                }
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client2.ToUpper()))
                    {
                        File.Delete(file);
                    }
            }
            }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://twitter.com/Red7s");
            }
            catch { }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.se7ensins.com/forums/threads/the-modding-of-isaac-vita-edition-the-binding-of-isaac-rebirth-mods-on-playstation-vita.1557403/");
            }
            catch { }
        }
    }
}
