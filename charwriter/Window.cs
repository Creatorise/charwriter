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
                open_file();
                return;
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                save_to_file();
                return;
            }
        }

        private void open_file()
        {
            var open_file_dialog_result = open_file_dialog.ShowDialog();

            if (open_file_dialog_result != DialogResult.OK) return;

            FileStream file_stream_in = new FileStream(open_file_dialog.FileName, FileMode.Open, FileAccess.Read);

            StreamReader file_reader = new StreamReader(file_stream_in);

            text_area.Text = file_reader.ReadToEnd();

            file_reader.Dispose();
        }

        private void save_to_file()
        {
            DialogResult save_file_dialog_result = save_file_dialog.ShowDialog();

            if (save_file_dialog_result != DialogResult.OK) return;

            // Choose how to write down, writable and other options
            FileStream file_stream_out = new FileStream(save_file_dialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            System.Diagnostics.Debug.WriteLine(FileMode.OpenOrCreate);

            StreamWriter file_writer = new StreamWriter(file_stream_out);

            file_writer.Write(text_area.Text);

            file_writer.Dispose();
        }
    }
}
