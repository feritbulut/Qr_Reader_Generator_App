using QRCoder;

namespace MyQrApp;

public partial class generate : ContentPage
{
    public generate()
    {
        InitializeComponent();
    }

    private void Generatebtn_Clicked(object sender, EventArgs e)
    {

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(InputText.Text, QRCodeGenerator.ECCLevel.L);
        PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
        byte[] qrCodeBytes = qRCode.GetGraphic(20);
        QrCodeImage.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));

    }
}