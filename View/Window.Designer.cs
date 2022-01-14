namespace charwriter;

partial class Window
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.text_area = new System.Windows.Forms.RichTextBox();
        this.background = new System.Windows.Forms.Panel();
        this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
        this.save_file_dialog = new System.Windows.Forms.SaveFileDialog();
        this.background.SuspendLayout();
        this.SuspendLayout();
        // 
        // text_area
        // 
        this.text_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        this.text_area.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.text_area.Dock = System.Windows.Forms.DockStyle.Fill;
        this.text_area.Font = new System.Drawing.Font("Fira Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.text_area.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        this.text_area.Location = new System.Drawing.Point(16, 16);
        this.text_area.Margin = new System.Windows.Forms.Padding(10);
        this.text_area.Name = "text_area";
        this.text_area.Size = new System.Drawing.Size(412, 359);
        this.text_area.TabIndex = 0;
        this.text_area.Text = "Charwriter\n\nUse default shortcuts like ctrl+o to open and ctrl+s to save";
        this.text_area.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_area__key_down);
        // 
        // background
        // 
        this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        this.background.Controls.Add(this.text_area);
        this.background.Dock = System.Windows.Forms.DockStyle.Fill;
        this.background.Location = new System.Drawing.Point(0, 0);
        this.background.Name = "background";
        this.background.Padding = new System.Windows.Forms.Padding(16);
        this.background.Size = new System.Drawing.Size(444, 391);
        this.background.TabIndex = 1;
        // 
        // open_file_dialog
        // 
        this.open_file_dialog.FileName = "openFileDialog1";
        // 
        // Window
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(444, 391);
        this.Controls.Add(this.background);
        this.KeyPreview = true;
        this.Name = "Window";
        this.Text = "Form1";
        this.background.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private RichTextBox text_area;
    private Panel background;
    private OpenFileDialog open_file_dialog;
    private SaveFileDialog save_file_dialog;
}
