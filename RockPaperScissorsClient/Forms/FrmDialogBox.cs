using System;
using System.Windows.Forms;

namespace ClientRPS.Forms {
    public partial class FrmDialogBox : Form {

        public string Input { get; set; }

        #region Değişkenler
        private bool _moveFlag = false, _showInputBox = false;
        private int _mouseX, _mouseY;
        #endregion

        #region Yapıcı Methodlar
        /// <summary>
        /// Tek buton içeren bir DialogBox oluşturur. Oluşan buton, "Onaylama" görevi görür.
        /// </summary>
        /// <param name="titleMessage">DialogBox'un başlığını belirler.</param>
        /// <param name="dialogMessage">DialogBox'un ana mesajını belirler.</param>
        /// <param name="acceptButtonText">Onaylama görevi gören butonun yazısını belirler.</param>
        public FrmDialogBox(string titleMessage, string dialogMessage, string acceptButtonText, bool showInputBox = false, string inputBoxText = "") {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            lblTitleText.Text = titleMessage;
            lblDialogText.Text = dialogMessage;
            btnAccept.Text = acceptButtonText;
            btnAccept.Visible = true;
            btnAccept.Width = 368;

            btnAccept.Click += btnAccept_Click;

            _showInputBox = showInputBox;

            TxtInput.Visible = _showInputBox;
            TxtInput.Text = inputBoxText;

            ShowDialog();
        }

        /// <summary>
        /// Çift buton içeren bir DialogBox oluşturur. Oluşan butonlardan biri "Onaylama" görevi, diğeri ise "Reddetme" görevi görür.
        /// </summary>
        /// <param name="titleMessage">DialogBox'un başlığını belirler.</param>
        /// <param name="dialogMessage">DialogBox'un ana mesajını belirler.</param>
        /// <param name="acceptButtonText">"Onaylama" görevi gören butonun yazısını belirler.</param>
        /// <param name="declineButtonText">"Reddetme" görevi gören butonun yazısını belirler.</param>
        public FrmDialogBox(string titleMessage, string dialogMessage, string acceptButtonText, string declineButtonText, bool showInputBox = false, string inputBoxText = "") {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            lblTitleText.Text = titleMessage;
            lblDialogText.Text = dialogMessage;
            btnAccept.Text = acceptButtonText;
            btnDecline.Text = declineButtonText;
            btnAccept.Visible = true;
            btnDecline.Visible = true;

            btnAccept.Click += btnAccept_Click;
            btnDecline.Click += btnDecline_Click;

            _showInputBox = showInputBox;

            TxtInput.Visible = _showInputBox;
            TxtInput.Text = inputBoxText;

            ShowDialog();
        }
        #endregion

        #region Tıklama Event'ları
        private void btnAccept_Click(object sender, EventArgs e) {
            if (_showInputBox) {
                Input = TxtInput.Text;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDecline_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Form Görsel Event'ları
        private void Form_MouseDown(object sender, MouseEventArgs e) {
            _moveFlag = true;
            _mouseX = Cursor.Position.X - Left;
            _mouseY = Cursor.Position.Y - Top;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e) {
            if (_moveFlag) {
                Top = Cursor.Position.Y - _mouseY;
                Left = Cursor.Position.X - _mouseX;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e) {
            _moveFlag = false;
        }
        #endregion

    }
}