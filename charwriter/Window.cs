namespace charwriter
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            text_area.SelectAll();
        }

        private void text_area__key_down(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.O)
            {
                var open_file_dialog_result = open_file_dialog.ShowDialog();

                if (open_file_dialog_result != DialogResult.OK) return;

                FileStream file_stream = new FileStream(open_file_dialog.FileName, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(file_stream);

                text_area.Text = reader.ReadToEnd();

                reader.Dispose();
            }
        }
    }
}
