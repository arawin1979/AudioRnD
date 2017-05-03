using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioUpdateLibrary
{
    public partial class BulkUpdateView : Form
    {
        public BulkUpdateView()
        {
            InitializeComponent();
        }

        private void btnBulkUpdate_Click(object sender, EventArgs e)
        {
            //C: \Users\Aravinth\Documents\Vuze Downloads\Aaytha Ezhuthu (2004)

            BulkUpdate bu = new BulkUpdate();
            bu.FolderName = txtFolderPath.Text;

            bu.AlbumAritist = txtAlbumArtist.Text.Trim();
            bu.AlbumName = txtAlbumName.Text.Trim();
            bu.Composer = txtComposer.Text.Trim();
            bu.Genre = txtGener.Text.Trim();

            bu.IncludeSubFolder = chkSubFolders.Checked;
            bu.UpdateFSASTitle = chkUpdateFNasTitle.Checked;
            bu.UpdateFolderNameAsAlbumName = chkAblbumAutoUpdate.Checked;

            int x;
            if (Int32.TryParse(txtYear.Text, out x))
                bu.Year = x;

            bu.ExecuteBulkUpdte();
        }

        private void btnFldr_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            
        }

        private void chkAblbumAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAblbumAutoUpdate.Checked){                 txtAlbumName.Text = "";
                txtAlbumName.ReadOnly = true;
            }
            else {
                txtAlbumName.ReadOnly = false;
            }
        }
    }
}
