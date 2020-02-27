using System;
using System.Windows.Forms;
using log4net;

namespace Log4Net
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Info("Load");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            log.Info("Click");
        }
    }
}
