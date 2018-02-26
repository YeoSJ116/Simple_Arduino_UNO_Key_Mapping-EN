using System.Windows.Forms;

namespace Arduino_UNO_Key_Mapping_Host_Software
{
    public partial class Programe_Info : Form
    {
        public Programe_Info()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/YeoSJ116/Simple_Arduino_UNO_Key_Mapping-EN");
        }
    }
}
