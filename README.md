# QR Code Generator and Reader App

This is a .NET MAUI mobile application that allows users to generate and read QR codes. The application includes two main functionalities:

- **Generate QR Code**: Users can enter text and generate a QR code based on the entered data.
- **Read QR Code**: Users can scan a QR code using their device's camera and see the decoded text.

## Features

- **QR Code Generation**: Generate QR codes from text input.
- **QR Code Reading**: Use the device's camera to scan and decode QR codes.
- **Responsive Design**: The app is built using .NET MAUI to work seamlessly on Android and iOS devices.

## Technologies Used

- **.NET MAUI**: Cross-platform mobile app development framework.
- **QRCoder**: Library used for generating QR codes.
- **ZXing.Net.MAUI**: Barcode scanning library for reading QR codes.

## How to Use

1. **Generate QR Code**:
   - Open the app and go to the "Generate" page.
   - Enter the data you want to encode in the input field.
   - Click on the "Generate" button to generate the QR code.
   - The generated QR code will be displayed below.

2. **Read QR Code**:
   - Open the "Reader" page and use the camera to scan a QR code.
   - The decoded data from the QR code will be displayed on the screen.

## Installation

To run this project locally, follow these steps:

1. Clone the repository:
   ```
   git clone https://github.com/yourusername/QR-Code-App.git
   ```

2. Open the project in Visual Studio.

3. Run the project on an Android or iOS emulator, or connect a device.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
