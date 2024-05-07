namespace Notes;

public partial class NotePage : ContentPage
{
	string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

	public NotePage()
	{
		InitializeComponent();
		if (File.Exists(_fileName))
			TextEditor.Text = File.ReadAllText(_fileName);
	}
}