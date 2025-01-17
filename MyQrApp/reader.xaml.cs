namespace MyQrApp;

public partial class reader : ContentPage
{
	public reader()
	{
		InitializeComponent();
		barcodereader.Options = new ZXing.Net.Maui.BarcodeReaderOptions
		{ 
			Formats = ZXing.Net.Maui.BarcodeFormat.QrCode,
			AutoRotate = true,
			Multiple = true

		};

	}

    private void barcodereader_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
		var first = e.Results?.FirstOrDefault();

		if (first is null)
			return;

		Dispatcher.DispatchAsync(async () => 
		{
			await DisplayAlert("Barcode Found", first.Value, "OK");
		}); 
    }
}