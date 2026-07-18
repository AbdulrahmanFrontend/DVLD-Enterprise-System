using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Enterprise_System.UI.Core.BaseForms
{
    public partial class frmAddUpdate : Form
    {
        public frmAddUpdate()
        {
            InitializeComponent();
        }

        public enum frmMode { AddNew = 0, Update = 1 }

        [Category("Custom Properties")]
        public frmMode Mode { get; set; }

        [Category("Custom Properties")]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public bool ButtonDeleteVisible
        {
            get => ctrlbtnDelete.Visible;
            set => ctrlbtnDelete.Visible = value;
        }

        [Category("Custom Properties")]
        public new Panel Container => pnlContainer;
    }
}
