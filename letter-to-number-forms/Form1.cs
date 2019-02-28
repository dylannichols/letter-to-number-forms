﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letter_to_number_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Greeting.Text = Messages.Greeting;
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            Result.Text = WordPercentage.WordToPercent(UserInputBox.Text);
        }
    }
}
