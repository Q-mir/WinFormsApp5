namespace WinFormsApp5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            RegistrationForm form = new RegistrationForm(this);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            EntryForm entryForm = new EntryForm(this);
            entryForm.ShowDialog();
        }
    }
}
