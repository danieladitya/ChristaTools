using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Watermark;

namespace watermarkit {
    public partial class MainForm : Form {
        private Watermarker m_watermarker;
        private OpenFileDialog m_ofd;
        private FolderBrowserDialog m_pathsave;
         public MainForm() {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog() {
            m_ofd = new OpenFileDialog();
            m_ofd.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff|All Files|*.*";
            m_pathsave = new FolderBrowserDialog();
            // Feed the dummy name to the save dialog
        }

        private void btnAddImage_Click(object sender, EventArgs e) {
            if (m_watermarker == null) {                
                MessageBox.Show(this, "Please load an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textWatermark.Text == "") {                
                MessageBox.Show(this, "Please choose an image to watermark", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkReset.Checked) {
                m_watermarker.ResetImage(); 
            }

            try {
                m_watermarker.DrawImage(textWatermark.Text);
                picturePreview.Image = m_watermarker.Image;
            } catch (Exception ex) {
                MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAddText_Click(object sender, EventArgs e) {
            if (m_watermarker == null) {
                MessageBox.Show(this, "Please load an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }

            if (textTextToAdd.Text == "") {                
                MessageBox.Show(this, "Please specify text to watermark", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (m_watermarker != null) {

                if (checkReset.Checked) {
                    m_watermarker.ResetImage();
                }

                m_watermarker.DrawText(textTextToAdd.Text);
                picturePreview.Image = m_watermarker.Image;
               
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e) {
            picturePreview.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void stretchToolStripMenuItem_Click(object sender, EventArgs e) {
            picturePreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e) {
            picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnSourceImage_Click(object sender, EventArgs e) {            
            if (m_ofd.ShowDialog() == DialogResult.OK) {
                textSourceImage.Text = m_ofd.FileName;

                Image img = Image.FromFile(m_ofd.FileName);
                m_watermarker = new Watermarker(img);

                picturePreview.Image = img;
                propertyGrid.SelectedObject = m_watermarker;
            }
        }

        private void btnResetImage_Click(object sender, EventArgs e) {
            if (m_watermarker != null) {
                m_watermarker.ResetImage();
                picturePreview.Image = m_watermarker.Image;
            }
        }

        private void btnWatermark_Click(object sender, EventArgs e) {
            if (m_ofd.ShowDialog() == DialogResult.OK) {
                textWatermark.Text = m_ofd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtSavePath.Text))
            {
                MessageBox.Show(this, "Please Set path folder to save image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string FileName = Path.GetFileName(m_ofd.FileName);
                string PathSave = string.Format("{0}\\{1}", txtSavePath.Text, FileName);
                picturePreview.Image.Save(PathSave, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show(this, "Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void propertyGrid_Click(object sender, EventArgs e)
        {

        }

        private void btnPathImage_Click(object sender, EventArgs e)
        {
           
            if (m_pathsave.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = m_pathsave.SelectedPath;
            
            }

             
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
