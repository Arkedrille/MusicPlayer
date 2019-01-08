using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oizoMusicPlayerCsharp
{
    public partial class NewPlaylist : Form
    {
        string plName;
        NewPlaylist newP;
        MusicPlayer mp;

        public NewPlaylist()
        {
            InitializeComponent();
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            plName = TbPLaylistName.Text;

            mp = new MusicPlayer(plName);

            newP = new NewPlaylist();
            newP.Close();
        }

        private void BtRetour_Click(object sender, EventArgs e)
        {
            newP = new NewPlaylist();
            newP.Close();
        }

    }
}
