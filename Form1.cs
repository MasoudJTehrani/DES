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
using FontAwesome.Sharp;

namespace DES
{
    public partial class Form1 : Form
    {
        private string mode = "";
        private string input = "";
        private string key = "";
        private int allBlocks = 0;
        private string[] keyArray = new string[16];
        private int blockNum;
        StringBuilder theOutput = new StringBuilder();
        private int[] roundshift = new int[] { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };
        private int[] keyPermutation = new int[] { 57, 49, 41, 33, 25, 17, 9,
                     1, 58, 50, 42, 34, 26, 18,
                     10, 2, 59, 51, 43, 35, 27,
                     19, 11, 3, 60, 52, 44, 36,
                     63, 55, 47, 39, 31, 23, 15,
                     7, 62, 54, 46, 38, 30, 22,
                     14, 6, 61, 53, 45, 37, 29,
                     21, 13, 5, 28, 20, 12, 4 };
        private int[] initialPerm = new int[]{58, 50, 42, 34, 26, 18, 10, 2,
                             60, 52, 44, 36, 28, 20, 12, 4,
                             62, 54, 46, 38, 30, 22, 14, 6,
                             64, 56, 48, 40, 32, 24, 16, 8,
                             57, 49, 41, 33, 25, 17, 9, 1,
                             59, 51, 43, 35, 27, 19, 11, 3,
                             61, 53, 45, 37, 29, 21, 13, 5,
                             63, 55, 47, 39, 31, 23, 15, 7 };
        private int[] finalPerm = new int[]{40, 8, 48, 16, 56, 24, 64, 32,
                           39, 7, 47, 15, 55, 23, 63, 31,
                           38, 6, 46, 14, 54, 22, 62, 30,
                           37, 5, 45, 13, 53, 21, 61, 29,
                           36, 4, 44, 12, 52, 20, 60, 28,
                           35, 3, 43, 11, 51, 19, 59, 27,
                           34, 2, 42, 10, 50, 18, 58, 26,
                           33, 1, 41, 9, 49, 17, 57, 25 };
        private int[] keyCompression = new int[] { 14, 17, 11, 24, 1, 5,
                         3, 28, 15, 6, 21, 10,
                         23, 19, 12, 4, 26, 8,
                         16, 7, 27, 20, 13, 2,
                         41, 52, 31, 37, 47, 55,
                         30, 40, 51, 45, 33, 48,
                         44, 49, 39, 56, 34, 53,
                         46, 42, 50, 36, 29, 32 };
        private int[] expansionPermutation = new int[] {31, 0, 1, 2, 3, 4, 3, 4, 5, 6, 7, 8,
            7, 8, 9, 10, 11, 12, 11, 12, 13, 14, 15, 16,
            15, 16, 17, 18, 19, 20, 19, 20, 21, 22, 23, 24,
            23, 24, 25, 26, 27, 28, 27, 28, 29, 30, 31, 0};
        private int[] straightPermutation = new int[] { 16, 7, 20, 21,
                    29, 12, 28, 17,
                    1, 15, 23, 26,
                    5, 18, 31, 10,
                    2, 8, 24, 14,
                    32, 27, 3, 9,
                    19, 13, 30, 6,
                    22, 11, 4, 25 };
        private int[][][] sbox = new int[][][] 
        {
            new int[][]{   
                new int[]{ 14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7 },
                new int[]{ 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8 },
                new int[]{ 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0 },
                new int[]{ 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 
                }
            },
            new int[][]{   
                new int[]{ 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10 },
                new int[]{ 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5 },
                new int[]{ 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15 },
                new int[]{ 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 
                }
            },
            new int[][]{   
                new int[]{ 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8 },
                new int[]{ 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1 },
                new int[]{ 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7 },
                new int[]{ 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12 
                }
            },
            new int[][]{   
                new int[]{ 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15 },
                new int[]{ 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9 },
                new int[]{ 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4 },
                new int[]{ 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 
                }
            },
            new int[][]{   
                new int[]{ 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9 },
                new int[]{ 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6 },
                new int[]{ 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14 },
                new int[]{ 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 
                }
            },
            new int[][]{   
                new int[]{ 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11 },
                new int[]{ 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8 },
                new int[]{ 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6 },
                new int[]{ 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 
                }
            },
            new int[][]{   
                new int[]{ 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1 },
                new int[]{ 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6 },
                new int[]{ 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2 },
                new int[]{ 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 
                }
            },
            new int[][]{   
                new int[]{ 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7 },
                new int[]{ 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2 },
                new int[]{ 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8 },
                new int[]{ 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 
                }
            }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // // Interface Methods \\
        //
        // Opening a File
        private string openFile(RichTextBox byteprev, RichTextBox binaryprev)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    byte[] fileBytes = File.ReadAllBytes(fileName);
                    StringBuilder sb = new StringBuilder();
                    StringBuilder sb2 = new StringBuilder();
                    foreach (byte b in fileBytes)
                    {
                        sb2.Append(b);
                        sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                    }
                    byteprev.Text = sb2.ToString();
                    binaryprev.Text = sb.ToString();
                    return sb.ToString();
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                MessageBox.Show("There was an error loading your file.");
                return "";
            }
        }
        // Saving a file
        private void saveFile(RichTextBox prevName)
        {
            // Error handling
            if (prevName.Text == "")
            {
                MessageBox.Show("There is nothing to save");
                return;
            }
            //
            //
            var data = GetBytesFromBinaryString(prevName.Text);
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save The Selected text";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, data);
            }
        }
        // Convert string to binary
        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            theOutput = new StringBuilder();
            string block = "";
            blockNum = 0;
            keyArray = generateKeyArray(key);
            if (mode == "enc")
            {
                addPadding();
                this.Invoke(new MethodInvoker(delegate {
                    ProgressBar pbar = progressBar1;
                    pbar.Maximum = (input.Length / 64) * 16;
                }));
                allBlocks = progressBar1.Maximum / 16;
                while (input.Length > 0)
                {
                    block = input.Substring(0, 64);
                    block = Permutaion(block, initialPerm);
                    block = performDES(block);
                    block = Permutaion(block, finalPerm);
                    theOutput.Append(block);
                    input = input.Remove(0, 64);
                    blockNum += 1;
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
            }
            else
            {
                this.Invoke(new MethodInvoker(delegate {
                    ProgressBar pbar = progressBar1;
                    pbar.Maximum = (input.Length / 64) * 16;
                }));
                allBlocks = progressBar1.Maximum / 16;
                keyArray = reverseKeyArray(keyArray);
                while (input.Length > 0)
                {
                    block = input.Substring(0, 64);
                    block = Permutaion(block, initialPerm);
                    block = performDES(block);
                    block = Permutaion(block, finalPerm);
                    theOutput.Append(block);
                    input = input.Remove(0, 64);
                    blockNum += 1;
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
                removePadding();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage != 0)
            {
                progressBar1.PerformStep();
                progresslabel.Text = "Progress: " + (progressBar1.Value * 100 / progressBar1.Maximum) + "%";
                blockNumlabel.Text = "Processing block Number " + blockNum + "/" + allBlocks;
            }
            else
            {
                progressBar1.Value = 0;
                progresslabel.Text = "Progress: 0%";
                blockNumlabel.Text = "Processing block Number ";
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                cbinarytext.Text = theOutput.ToString();
            }
        }

        private void addPadding()
        {
            if (input.Length % 64 == 0)
                return;
            int pad = (64 - (input.Length % 64)) / 8;
            StringBuilder paddedinput = new StringBuilder();
            paddedinput.Append(input);
            for (int i = 0; i < pad; i++)
            {
                paddedinput.Append(Convert.ToString(pad, 2).PadLeft(8, '0'));
            }
            input = paddedinput.ToString();     
        }

        private void removePadding()
        {
            string outputstr = theOutput.ToString();
            string addedpaddingstr = outputstr.Substring(theOutput.Length - 8);
            int addedPadding = Convert.ToInt32(addedpaddingstr, 2);
            for (int i = 2; i <= addedPadding; i++)
            {
                if (outputstr.Substring(theOutput.Length - (8 * i) , 8) != addedpaddingstr)
                {
                    return;
                }
            }
            string newoutput = outputstr.Substring(0, theOutput.Length - (8 * addedPadding));
            theOutput = new StringBuilder();
            theOutput.Append(newoutput);
            this.Invoke(new MethodInvoker(delegate {
                RichTextBox tbox = cbinarytext;
                tbox.Text = theOutput.ToString();
            }));
        }

        private string Permutaion(string block, int[] Perm)
        {
            StringBuilder Result = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                Result.Append(block[Perm[i] - 1]);
            }
            return Result.ToString();
        }

        private string performDES(string block)
        {
            StringBuilder Result = new StringBuilder();
            string Lblock = block.Substring(0, 32);
            string Rblock = block.Substring(32);
            string swapTemp = "";
            string compressedKey = "";
            for (int round = 0; round < 16; round++)
            {
                key = keyArray[round];
                swapTemp = Rblock;
                compressedKey = compressKey(key);
                swapTemp = expansionPbox(swapTemp);
                swapTemp = theXOR(swapTemp, compressedKey);
                swapTemp = sBox(swapTemp);
                swapTemp = straightPbox(swapTemp);
                swapTemp = theXOR(swapTemp, Lblock);
                Lblock = Rblock;
                Rblock = swapTemp;
                backgroundWorker1.ReportProgress(1);
            }
            Result.Append(Rblock);
            Result.Append(Lblock);
            return Result.ToString();
        }
        private string[] generateKeyArray(string passedkey)
        {
            StringBuilder Result;
            string[] ResultArr = new string[16];
            for (int i = 0; i < 16; i++)
            {
                Result = new StringBuilder();
                Result.Append(shiftToLeft(passedkey.Substring(0, 28), i));
                Result.Append(shiftToLeft(passedkey.Substring(28), i));
                ResultArr[i] = Result.ToString();
                passedkey = Result.ToString();
            }
            return ResultArr;
        }

        private string shiftToLeft(string block, int times)
        {
            StringBuilder Result;
            times = roundshift[times];
            for (int i = 0; i < times; i++)
            {
                Result = new StringBuilder();
                Result.Append(block.Substring(1));
                Result.Append(block.Substring(0, 1));
                block = Result.ToString();
            }
            return block;
        }

        private string compressKey(string key)
        {
            StringBuilder Result = new StringBuilder();
            for (int i = 0; i < 48; i++)
            {
                Result.Append(key[keyCompression[i] - 1]);
            }
            return Result.ToString();
        }
        
        private string expansionPbox(string Rblock)
        {
            StringBuilder Result = new StringBuilder();
            for (int i = 0; i < 48; i++)
            {
                Result.Append(Rblock[expansionPermutation[i]]);
            }
            return Result.ToString();
        }

        private string theXOR(string Rblock, string key)
        {
            StringBuilder Result = new StringBuilder();
            for (int i = 0; i < Rblock.Length; i++)
            {
                Result.Append(Int32.Parse(Rblock[i].ToString()) ^ Int32.Parse(key[i].ToString()));
            }
            return Result.ToString();
        }

        private string sBox(string Rblock)
        {
            StringBuilder Result = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                Result.Append(sBoxConvertor(Rblock.Substring( i * 6 ,6), i));
            }
            
            return Result.ToString();
        }

        private string sBoxConvertor(string input, int index)
        {
            StringBuilder row = new StringBuilder();
            StringBuilder column = new StringBuilder();
            row.Append(input[0]);
            row.Append(input[5]);
            column.Append(input.Substring(1, 4));
            return Convert.ToString(sbox[index][Convert.ToInt32(row.ToString(), 2)][Convert.ToInt32(column.ToString(), 2)], 2).PadLeft(4, '0');
        }

        private string straightPbox(string Rblock)
        {
            StringBuilder Result = new StringBuilder();
            for(int i = 0; i < 32; i++)
            {
                Result.Append(Rblock[straightPermutation[i] - 1]);
            }
            return Result.ToString();
        }
        private string[] reverseKeyArray(string[] input)
        {
            string[] Result = new string[16];
            int j = 0;
            for (int i = 15; i >= 0; i--)
            {
                Result[j] = input[i];
                j++;
            }
            return Result;
        }
        
        private string keyPermute(string key)
        {
            StringBuilder Result = new StringBuilder();
            for (int i = 0; i < 56; i++)
            {
                Result.Append(key[keyPermutation[i] - 1]);
            }
            return Result.ToString();
        }
        private void open_Click(object sender, EventArgs e)
        {
            input = openFile(ptext, pbinarytext);
        }

        private void randomkey_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            StringBuilder rndkey = new StringBuilder();
            for(int i = 0; i < 64; i++)
            {
                rndkey.Append(rnd.Next(0, 2));
            }
            keytext.Text = rndkey.ToString();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (keytext.Text == "" || pbinarytext.Text == "")
            {
                MessageBox.Show("Please enter the key and the file");
                return;
            }
            mode = "enc";
            input = pbinarytext.Text;
            key = keyPermute(keytext.Text);
            progressBar1.Value = 0;
            progresslabel.Text = "Progress: 0%";
            blockNumlabel.Text = "Processing block Number ";
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            mode = "dec";
            input = pbinarytext.Text;
            key = keyPermute(keytext.Text);
            progressBar1.Value = 0;
            progresslabel.Text = "Progress: 0%";
            blockNumlabel.Text = "Processing block Number ";
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void dnlowdresult_Click(object sender, EventArgs e)
        {
            saveFile(cbinarytext);
        }

        private void cancelProgressbtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        private void keytext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.Back);
        }

        private void keyHextext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyHextext.Text.Length >= 16)
            {
                MessageBox.Show("The key cannot be more than 16 hexadecimal characters");
                e.Handled = true;
                return;
            } 
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back ||
                e.KeyChar == (char)Keys.A || e.KeyChar == (char)Keys.B || e.KeyChar == (char)Keys.C ||
                e.KeyChar == (char)Keys.D || e.KeyChar == (char)Keys.E || e.KeyChar == (char)Keys.F ||
                e.KeyChar == 'a' || e.KeyChar == 'b' || e.KeyChar == 'c' || e.KeyChar == 'd'
                || e.KeyChar == 'e' || e.KeyChar == 'f');
        }

        private void keyHextext_TextChanged(object sender, EventArgs e)
        {
            keytext.Text = String.Join(String.Empty, keyHextext.Text.Select( c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0') ));
        }
    }
}
