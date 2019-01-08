using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oizoMusicPlayerCsharp
{
    public partial class MusicPlayer : Form
    {
        //Variables
        OpenFileDialog folderOpen;
        OpenFileDialog filesOpen;
        //Process viewHelp;
        APropos ap;

        public MusicPlayer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Toolstrip exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Toolstrip open folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderOpen = new OpenFileDialog();
        }

        /// <summary>
        /// Toolstrip open files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filesOpen = new OpenFileDialog();
        }

        /// <summary>
        /// Toolstrip view help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://karlzawisla.fr/help.html");

        }

        /// <summary>
        /// Toolstrip about
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ap = new APropos();
            ap.Show();
        }
    }
}
