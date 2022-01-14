namespace Charwriter.Logic;

/// <summary>
/// Manage read and write to files
/// </summary>
public static class File_management
{
    /// <summary>
    /// Read all content from file
    /// </summary>
    /// <param name="file_name">File name</param>
    /// <returns>Content</returns>
    public static string read(string file_name)
    {
        FileStream file_stream_in = new FileStream(file_name, FileMode.Open, FileAccess.Read);
        StreamReader file_reader = new StreamReader(file_stream_in);

        var content = file_reader.ReadToEnd();
        file_reader.Close();

        return content;
    }

    /// <summary>
    /// Write content to file
    /// </summary>
    /// <param name="file_name">File name</param>
    /// <param name="content">Content</param>
    public static void write(string file_name, string content)
    {
        FileStream file_stream_out = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Write);

        StreamWriter file_writer = new StreamWriter(file_stream_out);

        file_writer.Write(content);

        file_writer.Dispose();
    }
}
