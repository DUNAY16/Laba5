﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Opus : Form
    {
        public Opus()
        {
            InitializeComponent();
        }

        private void linkLabel_AES_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://docs.microsoft.com/ru-ru/dotnet/api/system.security.cryptography.aes?redirectedfrom=MSDN&view=net-6.0");
        }

        private void linkLabel_Rijndael_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/ru-ru/dotnet/api/system.security.cryptography.rijndael?redirectedfrom=MSDN&view=net-6.0");
        }

        private void linkLabel_RC2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/ru-ru/dotnet/api/system.security.cryptography.rc2?redirectedfrom=MSDN&view=net-6.0");
        }

        private void linkLabel_DES_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/ru-ru/dotnet/api/system.security.cryptography.des?redirectedfrom=MSDN&view=net-6.0");
        }

        private void linkLabel_TriplDES_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/ru-ru/dotnet/api/system.security.cryptography.tripledes?redirectedfrom=MSDN&view=net-6.0");
        }
    }
}
