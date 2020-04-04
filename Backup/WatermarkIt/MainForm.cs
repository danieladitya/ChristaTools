using System;
using System.Drawing;
using System.Windows.Forms;
using Watermark;

namespace watermarkit {
    public partial class MainForm : Form {
        private Watermarker m_watermarker;
        private OpenFileDialog m_ofd;

        public MainForm() {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog() {
            m_ofd = new OpenFileDialog();
            m_ofd.Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff|All Files|*.*";

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
    }
}
