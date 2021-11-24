using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rB_CRC32.Checked = true;
        }

        private byte[] myEncoding(byte[] inArr)
        {
            byte[] result = { 0 };
            if (rB_CRC32.Checked == true)
            {
                uint a = Crc.Crc32(inArr);
                return BitConverter.GetBytes(a);
            }
            if (rB_HAVAL.Checked == true)
            {
                HashAlgorithm sha = KeyedHashAlgorithm.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_RIPEMD160.Checked == true)
            //{
            //    HashAlgorithm sha = RIPEMD160.Create();
            //    return sha.ComputeHash(inArr);
            //}
            if (rB_MD5.Checked == true)

            {
                HashAlgorithm sha = MD5.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA1.Checked == true)
            {
                HashAlgorithm sha = SHA1.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA256.Checked == true)
            {
                HashAlgorithm sha = SHA256.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA384.Checked == true)
            {
                HashAlgorithm sha = SHA384.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA512.Checked == true)
            {
                HashAlgorithm sha = SHA512.Create();
                return sha.ComputeHash(inArr);
            }
            return result;
        }

        private void bInFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Шлях до файлу
                    string fileINpath = openFileDialog.FileName;
                    tInFilePath.Text = fileINpath;
                }
            }
            
        }



        private void bOutFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Шлях до файлу
                string fileOUTpath = saveFileDialog.FileName;
                tOutFilePath.Text = fileOUTpath;
            }
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] inArr = File.ReadAllBytes(tInFilePath.Text); // читаємо байти з файлу
            File.WriteAllBytes(tOutFilePath.Text, myEncoding(inArr)); // створюємо новий файл і записуємо у нього байти

            FileInfo fileIN = new FileInfo(tInFilePath.Text);
            long size = fileIN.Length;
            label3.Text = ("Вхідний файл: " + size.ToString() + " байт");

            FileInfo fileOUT = new FileInfo(tOutFilePath.Text);
            long size1 = fileOUT.Length;
            label4.Text = ("Вхідний файл: " + size1.ToString() + " байт");

            string result = BitConverter.ToString(myEncoding(inArr)).Replace("-", "");
            MessageBox.Show(" У файлі записане число(контрольна сума вхідного файлу):\n" + result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bClean_Click(object sender, EventArgs e)
        {
            tInFilePath.Text = "";
            tOutFilePath.Text = "";
            label3.Text = ("Вхідний файл:");
            label4.Text = ("Вхідний файл:");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opus Opus = new Opus();
            Opus.Show();
        }
    }
}
