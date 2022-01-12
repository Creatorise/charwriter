namespace charwriter
{
    public partial class Window : Form
    {
        protected bool is_active_file_present = false;

        private string _active_file_name = "";

        protected string active_file_name
        {
            get => _active_file_name;
            set
            {
                this.Text = value;
                _active_file_name = value;
            }
        }

        public Window()
        {
            InitializeComponent();

            active_file_name = "untitled.txt";

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
                save_file();
                return;
            }

            this.Text = "* " + _active_file_name;
        }

        private void open_file()
        {
            var open_file_dialog_result = open_file_dialog.ShowDialog();

            if (open_file_dialog_result != DialogResult.OK) return;

            FileStream file_stream_in = new FileStream(open_file_dialog.FileName, FileMode.Open, FileAccess.Read);
            StreamReader file_reader = new StreamReader(file_stream_in);

            text_area.Text = file_reader.ReadToEnd();

            file_reader.Dispose();

            active_file_name = open_file_dialog.FileName;
        }

        private void save_file()
        {
            if (!is_active_file_present)
            {
                DialogResult save_file_dialog_result = save_file_dialog.ShowDialog();

                if (save_file_dialog_result != DialogResult.OK) return;

                active_file_name = save_file_dialog.FileName;
            }

            FileStream file_stream_out = new FileStream(active_file_name, FileMode.OpenOrCreate, FileAccess.Write);
            System.Diagnostics.Debug.WriteLine(FileMode.OpenOrCreate);

            StreamWriter file_writer = new StreamWriter(file_stream_out);

            file_writer.Write(text_area.Text);

            file_writer.Dispose();

            this.Text = _active_file_name;
        }
    }
}
