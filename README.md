
# Bitcoin Address Generator

Bitcoin Address Generator is a Windows Forms application that allows users to generate Bitcoin addresses from a passphrase. The application supports generating various types of addresses, including Legacy, Segwit, SegwitP2SH, and Taproot addresses, in both compressed and uncompressed formats.

## Features

- Generate SHA256 hash from passphrase
- Display private and public keys in both compressed and uncompressed formats
- Generate Legacy, Segwit, SegwitP2SH, and Taproot Bitcoin addresses
- Display addresses in both compressed and uncompressed formats

## Prerequisites

- .NET Framework (version required for the project)
- Visual Studio (for running and building the project)

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/oaslananka/BitcoinFullAddressGeneratorCSharp.git
    ```

2. Open the project in Visual Studio.
3. Restore the NuGet packages.
4. Build the project.

## Usage

1. Run the application.
2. Enter a passphrase in the provided textbox.
3. The application will automatically generate and display the corresponding Bitcoin addresses, private keys, and public keys in both compressed and uncompressed formats.

## Code Overview

### Program.cs

The `Program.cs` file contains the main entry point for the application.

```csharp
namespace Bitcoin_Address_Generator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
```

### Form1.cs

The `Form1.cs` file contains the logic for generating Bitcoin addresses and keys based on the passphrase entered by the user.

```csharp
using System.Text;
using System.Security.Cryptography;
using System.Numerics;
using NBitcoin;

namespace Bitcoin_Address_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passphrase_textBox_TextChanged(object sender, EventArgs e)
        {
            // Logic for handling text change event and generating keys and addresses
        }

        // Additional methods for generating keys and addresses
    }
}
```

### Form1.Designer.cs

The `Form1.Designer.cs` file contains the UI elements for the application.

```csharp
namespace Bitcoin_Address_Generator
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            // UI components initialization
        }
    }
}
```

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
