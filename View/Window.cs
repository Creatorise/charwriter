using Charwriter.Logic;

namespace charwriter;

public partial class Window : Form
{
    public bool do_save_with_dialog { get; set; } = true;

    public string active_file_name { get; set; } = "";

    public Window()
    {
        InitializeComponent();

        active_file_name = "untitled.txt";
        open_file_dialog.FileName = active_file_name;

        this.Text = open_file_dialog.SafeFileName;

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
    }

    private void open_file()
    {
        var open_file_dialog_result = open_file_dialog.ShowDialog();

        if (open_file_dialog_result != DialogResult.OK) return;

        text_area.Text = File_management.read(open_file_dialog.FileName);

        active_file_name = open_file_dialog.FileName;
        do_save_with_dialog = false;
        this.Text = open_file_dialog.SafeFileName;
    }

    private void save_file()
    {
        if (do_save_with_dialog)
        {
            DialogResult save_file_dialog_result = save_file_dialog.ShowDialog();

            if (save_file_dialog_result != DialogResult.OK) return;

            active_file_name = save_file_dialog.FileName;
        }

        File_management.write(active_file_name, text_area.Text);
    }
}
