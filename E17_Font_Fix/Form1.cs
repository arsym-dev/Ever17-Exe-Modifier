using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E17_Font_Fix
{
    public partial class Form1 : Form
    {
        string exe_name = "ever17PC_us.exe";
        string backup_name = "ever17PC_us.original.exe";

        int h1_offset = 0x1365b;
        int w1_offset = 0x13665;
        int h2_offset = 0x13674;
        int w2_offset = 0x1367e;
        int h3_offset = 0x1368d;
        int w3_offset = 0x13697;
        int h4_w4_offset = 0x136a1;
        int h5_offset = 0x136bc;
        int w5_offset = 0x136c6;
        int h6_offset = 0x136d5;
        int w6_offset = 0x136df;

        public Form1()
        {
            InitializeComponent();

            // Read the current font name
            string font_name;
            try
            {
                using (StreamReader ini_stream = new StreamReader("ever17PC_us.ini", false))
                {
                    string data = ini_stream.ReadToEnd();
                    int index = data.IndexOf('\x00');
                    font_name = data.Substring(2, index - 2);
                }
            }
            catch
            {
                font_name = "Courier New";
            }
            textboxFontName.Text = font_name;


            // Read the font sizes
            try
            {
                using (FileStream exe_stream = new FileStream(exe_name, FileMode.Open, FileAccess.Read))
                {
                    exe_stream.Seek(h1_offset, SeekOrigin.Begin);
                    textboxH1.Text = exe_stream.ReadByte().ToString();
                    exe_stream.Seek(w1_offset, SeekOrigin.Begin);
                    textboxW1.Text = exe_stream.ReadByte().ToString();

                    exe_stream.Seek(h2_offset, SeekOrigin.Begin);
                    textboxH2.Text = exe_stream.ReadByte().ToString();
                    exe_stream.Seek(w2_offset, SeekOrigin.Begin);
                    textboxW2.Text = exe_stream.ReadByte().ToString();

                    exe_stream.Seek(h3_offset, SeekOrigin.Begin);
                    textboxH3.Text = exe_stream.ReadByte().ToString();
                    exe_stream.Seek(w3_offset, SeekOrigin.Begin);
                    textboxW3.Text = exe_stream.ReadByte().ToString();

                    exe_stream.Seek(h4_w4_offset, SeekOrigin.Begin);
                    textboxHW4.Text = exe_stream.ReadByte().ToString();

                    exe_stream.Seek(h5_offset, SeekOrigin.Begin);
                    textboxH5.Text = exe_stream.ReadByte().ToString();
                    exe_stream.Seek(w5_offset, SeekOrigin.Begin);
                    textboxW5.Text = exe_stream.ReadByte().ToString();

                    exe_stream.Seek(h6_offset, SeekOrigin.Begin);
                    textboxH6.Text = exe_stream.ReadByte().ToString();
                    exe_stream.Seek(w6_offset, SeekOrigin.Begin);
                    textboxW6.Text = exe_stream.ReadByte().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open " + exe_name + ": " + ex.Message);
            }


            

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (textboxFontName.Text == "")
                return;

            bool success = ApplyPatches(false);
            if (success)
                MessageBox.Show("Success");
        }

        private void buttonApplyRun_Click(object sender, EventArgs e)
        {
            if (textboxFontName.Text == "")
                return;

            ApplyPatches(true);
        }


        private bool ApplyPatches(bool run_game = false)
        {
            string font = textboxFontName.Text;

            // Change the .ini file with new font name
            using (StreamWriter ini_stream = new StreamWriter("ever17PC_us.ini", false))
            {
                string str = "01" + font + "\x00" + font + "\x00" + "010";
                ini_stream.Write(str);
            }


            // Create backup of .exe if there isn't one already
            try
            {
                if (!File.Exists(backup_name))
                    File.Copy(exe_name, backup_name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No patches applied. Error creating backup of " + exe_name + ": " + ex.Message);
                return false;
            }



            FileStream file = null;

            try
            {
                file = new FileStream(exe_name, FileMode.Open, FileAccess.ReadWrite);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open " + exe_name + ": " + ex.Message);
                return false;
            }


            // Apply font size changes
            WriteByteAtOffset(file, h1_offset, byte.Parse(textboxH1.Text));
            WriteByteAtOffset(file, w1_offset, byte.Parse(textboxW1.Text));
            WriteByteAtOffset(file, h2_offset, byte.Parse(textboxH2.Text));
            WriteByteAtOffset(file, w2_offset, byte.Parse(textboxW2.Text));
            WriteByteAtOffset(file, h3_offset, byte.Parse(textboxH3.Text));
            WriteByteAtOffset(file, w3_offset, byte.Parse(textboxW3.Text));
            WriteByteAtOffset(file, h4_w4_offset, byte.Parse(textboxHW4.Text));
            WriteByteAtOffset(file, h5_offset, byte.Parse(textboxH5.Text));
            WriteByteAtOffset(file, w5_offset, byte.Parse(textboxW5.Text));
            WriteByteAtOffset(file, h6_offset, byte.Parse(textboxH6.Text));
            WriteByteAtOffset(file, w6_offset, byte.Parse(textboxW6.Text));


            // Apply font patch
            if (checkboxFontFix.Checked)
            {
                WriteByteAtOffset(file, 0x137FC, new byte[]
                {
                    0x68, 0x20, 0xA3, 0x7C, 0x00, 0x56, 0xFF, 0x15, 0x34, 0xA0, 0x43, 0x00, 0x56, 0x6A, 0x00, 0xFF,
                    0x15, 0x5C, 0xA2, 0x43, 0x00, 0x33, 0xc0, 0x5e, 0xc3
                });

                WriteByteAtOffset(file, 0x3A034, new byte[]
                {
                    0xA0, 0xD2, 0x03, 0x00, 0x74
                });

                WriteByteAtOffset(file, 0x3CA5C, new byte[]
                {
                    0x20, 0xA3, 0x7C
                });
            }

            // Apply music patch
            if (checkboxMusicFix.Checked)
            {
                // NOP out the check
                WriteByteAtOffset(file, 0xE286, new byte[]
                {
                    0x90,0x90,0x90,0x90,0x90,0x90,
                });
            }


            // Apply speed patch
            if (checkboxSkipSpeed.Checked)
            {
                WriteByteAtOffset(file, 0x14AF7, 0x00);

                // Jump to codecave
                WriteByteAtOffset(file, 0x14B52, new byte[]
                {
                    0xE9, 0x29, 0x47, 0x02, 0x00, 0x90, 0x90, 0x90, 0x90, 0x90
                });

                // Injected code
                WriteByteAtOffset(file, 0x39280, new byte[]
                {
                    0x83, 0x3D, 0x8C, 0x99, 0x45, 0x00, 0x01, 0x75, 0x24, 0x8B, 0x46, 0x20, 0x8A, 0x08, 0x80, 0xF9,
                    0x00, 0x74, 0x0B, 0x80, 0xf9, 0x02, 0x74, 0x06, 0x80, 0xF9, 0x0D, 0x75, 0x06, 0x90, 0xE9, 0x21,
                    0xA9, 0xFD, 0xFF, 0xC7, 0x05, 0x08, 0x7E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x5F, 0x5E, 0x5D,
                    0x5B, 0x81, 0xC4, 0x18, 0x01, 0x00, 0x00, 0xC3
                });
            }


            // Remove the useless "Returns" from the rightclick menus
            if (checkboxRightclickMenu.Checked)
            {
                WriteByteAtOffset(file, 0xE286, new byte[]
                {
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90
                });

                WriteByteAtOffset(file, 0x1365B, 0x32);
                WriteByteAtOffset(file, 0x13665, 0x32);
                WriteByteAtOffset(file, 0x13674, 0x24);
                WriteByteAtOffset(file, 0x1367E, 0x28);
                WriteByteAtOffset(file, 0x136D5, 0x1C);
                WriteByteAtOffset(file, 0x136DF, 0x20);

                WriteByteAtOffset(file, 0x137FC, new byte[]
                {
                    0x68, 0x20, 0xA3, 0x7C, 0x00, 0x56, 0xFF, 0x15, 0x34, 0xA0, 0x43, 0x00
                });


                WriteByteAtOffset(file, 0x32049, 0x05);
                WriteByteAtOffset(file, 0x3209A, new byte[]
                {
                    0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,
                    0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90
                });

                WriteByteAtOffset(file, 0x32199, 0x05);
                WriteByteAtOffset(file, 0x321EA, new byte[]
                {
                    0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,
                    0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90,0x90
                });


                // In-game menu
                // Remove "Return" and put Save/Load at the root of the menu
                // 129 byte codecave created
                WriteByteAtOffset(file, 0x30C1C, new byte[]
                {
                    0x39, 0x2D,
                    0x2C, 0x9A, 0x45, 0x00, 0x75, 0x15, 0x55, 0xE8, 0xF6, 0x16, 0x00, 0x00, 0x83, 0xC4, 0x04, 0x3B,
                    0xC3, 0x74, 0x09, 0x39, 0x1D, 0x24, 0x9C, 0x45, 0x00, 0x74, 0x01, 0x45, 0x8B, 0x0D, 0x70, 0xCD,
                    0x45, 0x00, 0x68, 0x6C, 0x4E, 0x45, 0x00, 0x6A, 0x16, 0x55, 0x51, 0xFF, 0xD6, 0x8B, 0x0D, 0x70,
                    0xCD, 0x45, 0x00, 0x68, 0x60, 0x4E, 0x45, 0x00, 0x6A, 0x17, 0x55, 0x51, 0xFF, 0xD6, 0x8B, 0x15,
                    0x70, 0xCD, 0x45, 0x00, 0x55, 0x55, 0x68, 0x00, 0x08, 0x00, 0x00, 0x52, 0xFF, 0xD6, 0x85, 0xED,
                    0x75, 0x23, 0x68, 0x00, 0x01, 0x00, 0x00, 0xE8, 0xA6, 0x16, 0x00, 0x00, 0x83, 0xC4, 0x04, 0x85,
                    0xC0, 0x68, 0x34, 0x4D, 0x45, 0x00, 0xFF, 0x35, 0x38, 0xCE, 0x45, 0x00, 0x74, 0x03, 0x53, 0xEB,
                    0x11, 0x6A, 0x10, 0xEB, 0x0D, 0x68, 0x34, 0x4D, 0x45, 0x00, 0xFF, 0x35, 0x38, 0xCE, 0x45, 0x00,
                    0x6A, 0x11, 0xFF, 0x35, 0x70, 0xCD, 0x45, 0x00, 0xFF, 0xD6, 0x68, 0x28, 0x4D, 0x45, 0x00, 0xFF,
                    0x35, 0x20, 0xCD, 0x45, 0x00, 0x85, 0xED, 0x75, 0x04, 0x6A, 0x10, 0xEB, 0x02, 0x6A, 0x11, 0xFF,
                    0x35, 0x70, 0xCD, 0x45, 0x00, 0xFF, 0xD6, 0x55, 0x55, 0x68, 0x00, 0x08, 0x00, 0x00, 0xFF, 0x35,
                    0x70, 0xCD, 0x45, 0x00, 0xFF, 0xD6, 0x68, 0x18, 0x4D, 0x45, 0x00, 0xFF, 0x35, 0x4C, 0xCF, 0x45,
                    0x00, 0x85, 0xED, 0x75, 0x04, 0x6A, 0x10, 0xEB, 0x02, 0x6A, 0x11, 0xFF, 0x35, 0x70, 0xCD, 0x45,
                    0x00, 0xFF, 0xD6, 0x33, 0xED, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90,
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90,
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90,
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90,
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90,
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90,
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90,
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90,
                    0x90, 0x90, 0x90, 0x90, 0x90, 0x90
                });

                // Enable debug menu
                // Requires the codecave created from the earlier steps
                WriteByteAtOffset(file, 0x1D18A, new byte[]
                {
                    0x0E, 0x4F, 0x01, 0x00
                });

                
                WriteByteAtOffset(file, 0x3209C, new byte[]
                {
                    0x36, 0x81, 0x0D, 0x60, 0x91, 0x45, 0x00, 0x00, 0x60, 0x00, 0x00, 0xE9, 0x74, 0x48, 0xFE, 0xFF
                });

            }

            file.Flush();
            file.Close();
            file.Dispose();


            // Start game
            if (run_game)
            {
                try
                {
                    var p = new Process();
                    p.StartInfo.FileName = exe_name;  // just for example, you can use yours.
                    p.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not launch " + exe_name);
                }
            }

            return true;
        }

        private void TextboxNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }


        void WriteByteAtOffset(FileStream file, int offset, byte b)
        {
            file.Seek(offset, SeekOrigin.Begin);
            file.WriteByte(b);
        }

        void WriteByteAtOffset(FileStream file, int offset, byte[] b)
        {
            file.Seek(offset, SeekOrigin.Begin);
            file.Write(b, 0, b.Length);
        }
    }
}
