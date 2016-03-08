﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Yuri;

namespace YuriHalation.YuriForms
{
    public partial class MsgLayerForm : Form
    {
        public MsgLayerForm()
        {
            InitializeComponent();
            this.numericUpDown1.Maximum = Halation.project.Config.GameMsgLayerCount - 1;
        }

        /// <summary>
        /// 按钮：确定
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Halation.GetInstance().DashMsgLayer(this.numericUpDown1.Value.ToString());
            this.Close();
        }
    }
}
