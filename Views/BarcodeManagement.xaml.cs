namespace ReloCheck.Views;

public partial class BarcodeManagement : ContentPage
{
	public BarcodeManagement()
    {
        InitializeComponent();

        
    }

    private void cameraView_CamerasLoaded(object sender, EventArgs e)
    {
		cameraView.Camera = cameraView.Cameras.First();

		MainThread.BeginInvokeOnMainThread(async() =>
		{
			await cameraView.StopCameraAsync();
            await cameraView.StartCameraAsync();

			
        });

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		barcode.Source = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.PNG);
    }

    private void cameraView_BarcodeDetected(object sender,
        Camera.MAUI.ZXingHelper.BarcodeEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            barcodeResult.Text = $"{args.Result[0].BarcodeFormat} : { args.Result[0]
                .Text }";
        });

        }
}