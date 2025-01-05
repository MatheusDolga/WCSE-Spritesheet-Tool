using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace We_Can_Sprite_Everything
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public static class global
        {
            public static String currentPath = "";
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            string newPath;
            DialogResult newBrowserResult = folderBrowser.ShowDialog();
            if (newBrowserResult == DialogResult.OK)
            {
                newPath = folderBrowser.SelectedPath;
            }
            else
            {
                return;
            }

            global.currentPath = newPath;
            lbl_path.Text = $"Current path: {newPath}";

            if (nud_width.Value + nud_height.Value == 0)
            {
                Bitmap firstSprite = new Bitmap(Directory.GetFileSystemEntries(global.currentPath)[0]);
                nud_width.Value = firstSprite.Width;
                nud_height.Value = firstSprite.Height;
            }
        }

        private void btn_output_Click(object sender, EventArgs e)
        {

            // D:\Matheus\Documentos\We Can Sprite Everything
            if (global.currentPath == "")
            {
                
                return;
            }
            if (nud_width.Value == 0 || nud_height.Value == 0 || nud_horizontal.Value == 0 || nud_vertical.Value == 0)
            {
                return;
            }

            int[] dimensions = { Convert.ToInt32(nud_width.Value), Convert.ToInt32(nud_height.Value) };
            int[] spriteNumbers = { Convert.ToInt32(nud_horizontal.Value), Convert.ToInt32(nud_vertical.Value) };
            int[] currentSpriteNumber = { 1 , 1 };

            Bitmap fullSprite = new Bitmap(dimensions[0] * spriteNumbers[0], dimensions[1] * spriteNumbers[1]);
            int spriteAmmount = Directory.GetFileSystemEntries(global.currentPath).Length;
            if (spriteAmmount == 0)
            {
                return;
            }

            for (int i = 0; i < spriteAmmount; i++)
            {
                Bitmap currentSprite = new Bitmap(Directory.GetFileSystemEntries(global.currentPath)[i]);

                if (currentSpriteNumber[0] > spriteNumbers[0])
                {
                    if (currentSpriteNumber[1] < spriteNumbers[1])
                    {
                        currentSpriteNumber[0] = 1;
                        currentSpriteNumber[1]++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int xCoord = 0; xCoord < dimensions[0]; xCoord++)
                {
                    for (int yCoord = 0; yCoord < dimensions[1]; yCoord++)
                    {
                        Color originalPixelColor = currentSprite.GetPixel(xCoord, yCoord);
                        fullSprite.SetPixel( xCoord + ( dimensions[0] * (currentSpriteNumber[0] - 1) ), yCoord + (dimensions[1] * (currentSpriteNumber[1] - 1)), originalPixelColor);
                    }
                }

                currentSpriteNumber[0]++;

            }

            fullSprite.Save(@"D:\Matheus\Documentos\We Can Sprite Everything\Sprite.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
