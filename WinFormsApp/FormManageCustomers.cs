﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormManageCustomers : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManageCustomers()
        {
            _layer = new();
            InitializeComponent();
        }

        private void buttonCustomerIdFind_Click(object sender, EventArgs e)
        {

        }
    }
}