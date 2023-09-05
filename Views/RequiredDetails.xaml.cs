using Microsoft.Maui.Storage;
using System.IO;

namespace ReloCheck.Views;

public partial class RequiredDetails : ContentPage
{
	public RequiredDetails()
	{
		InitializeComponent();
	}

	public async void TakePhoto()
	{
		if (MediaPicker.Default.IsCaptureSupported) 
		{
            FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

			if (photo != null)
			{
				string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

				using Stream sourceStream = await photo.OpenReadAsync();
				using FileStream localFilestream = File.OpenWrite(localFilePath);

				await sourceStream.CopyToAsync(localFilestream);
			}
		}
	}

}