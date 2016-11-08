using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net;
using MetroFramework;
using System.Media;
using System.Diagnostics;

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
            {
                
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();
            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                //List Client side mods to remove here
                string client1 = "optifine";
                string client2 = "liteloader";
                string client3 = "fastcraft";
                string client4 = "damageindicators";
                string client5 = "custommainmenu";
                string client6 = "resourceloader";
                string client7 = "SoundFilters";
                string client8 = "voxelMap";
                string client9 = "reis";
                string client10 = "Schematica";
                string client11 = "Watson";
                string client12 = "shaders";
                string client13 = "InventoryTweaks";
                string client14 = "ArmorStatusHUD";
                string client15 = "StatusEffectHUD";
                string client16 = "IngameInfo";
                string client17 = "bUpload";
                string client18 = "TabbyChat";
                string client19 = "ding";
                string client20 = "Macro";

                //search for clients in the selected folder
                string[] Files = Directory.GetFiles(fbd.SelectedPath);
                foreach (string file in Files)
                {


                    //removes optifine
                    if (file.ToUpper().Contains(client1.ToUpper()))
                    {
                        File.Delete(file);
                    }
                }


                //removes liteloader
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client2.ToUpper()))
                    {
                        File.Delete(file);
                    }


                //removes fastcraft
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client3.ToUpper()))
                    {
                        File.Delete(file);
                    }


                //removes damageindicators
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client4.ToUpper()))
                    {
                        File.Delete(file);
                    }


                //removes custommainmenu
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client5.ToUpper()))
                    {
                        File.Delete(file);
                    }


                //removes resourceloader
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client6.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes SoundFilters
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client7.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes voxelMap
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client8.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes reis minimap
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client9.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes scemetica
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client10.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes watson
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client11.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes shaders
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client12.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes inventory tweaks
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client13.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes armorstatushud
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client14.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes statuseffecthud
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client15.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes ingameinfo
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client16.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes bUpload
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client17.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes tabbychat
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client18.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes ding
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client19.ToUpper()))
                    {
                        File.Delete(file);
                    }
                //removes macros
                foreach (string file in Files)
                    if (file.ToUpper().Contains(client20.ToUpper()))
                    {
                        File.Delete(file);
                    }
            }
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
            System.Windows.Forms.MessageBox.Show("All client side mods have been removed!");
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            {
                if (!new WebClient().DownloadString("http://pastebin.com/raw/BprUvZwZ").Contains("1.1"))
                {
                    MessageBox.Show("Update Found!");
                    MessageBox.Show("Your browser will now open and download the latest update!");
                    Process.Start("https://kancolle.redthetrainer.com/yolo/Server%20Crafter.zip");

                }
                else
                {
                    MessageBox.Show("You're on the latest update!");


                }
            }
        }
    }
}
