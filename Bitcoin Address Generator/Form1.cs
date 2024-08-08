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
            string input = passphrase_textBox.Text;

            if (!string.IsNullOrEmpty(input))
            {
                byte[] privateKey = ComputeSha256Hash(input);
                secretExponent_textBox.Text = BitConverter.ToString(privateKey).Replace("-", "");

                string uncompressedPrivateKeyWif = ConvertPrivateKeyToWIF(privateKey, false);
                privateKeyUnComp_textBox.Text = uncompressedPrivateKeyWif;

                string compressedPrivateKeyWif = ConvertPrivateKeyToWIF(privateKey, true);
                privateKeyComp_textBox.Text = compressedPrivateKeyWif;

                string uncompressedPubKeyHex = UncompressedPublicKey(privateKey);
                publicKeyUnComp_textBox.Text = uncompressedPubKeyHex;

                string compressedPubKeyHex = CompressedPublicKey(privateKey);
                publicKeyComp_textBox.Text = compressedPubKeyHex;

                string uncompressedAddress = UncompressedAddress(uncompressedPubKeyHex);
                legacyAddresUnComp_textBox.Text = uncompressedAddress;

                string compressedAddress = CompressedAddress(compressedPubKeyHex);
                legacyAddresComp_textBox.Text = compressedAddress;

                string segwitAddressUncompressed = SegwitAddressUncompressed(uncompressedPubKeyHex);
                segwitUnComp_textBox.Text = segwitAddressUncompressed;

                string segwitAddressCompressed = SegwitAddressCompressed(compressedPubKeyHex);
                segwitComp_textBox.Text = segwitAddressCompressed;

                string segwitP2SHAddressUncompressed = SegwitP2SHAddressUncompressed(uncompressedPubKeyHex);
                segwitP2SHUnComp_textBox.Text = segwitP2SHAddressUncompressed;

                string segwitP2SHAddressCompressed = SegwitP2SHAddressCompressed(compressedPubKeyHex);
                segwitP2SHComp_textBox.Text = segwitP2SHAddressCompressed;

                string taprootBIP86AddressCompressed = TaprootBIP86AddressCompressed(compressedPubKeyHex);
                taprootBIP86Comp_textBox.Text = taprootBIP86AddressCompressed;

            }
            else
            {
                secretExponent_textBox.Text = "";
                privateKeyUnComp_textBox.Text = "";
                privateKeyComp_textBox.Text = "";
                publicKeyUnComp_textBox.Text = "";
                publicKeyComp_textBox.Text = "";
                legacyAddresUnComp_textBox.Text = "";
                legacyAddresComp_textBox.Text = "";

            }
        }

        private byte[] ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            }
        }

        static string ConvertPrivateKeyToWIF(byte[] privateKey, bool compressed)
        {
            // Versiyon baytýný ekleyin (Bitcoin için 0x80)
            byte[] extendedKey = new byte[privateKey.Length + (compressed ? 2 : 1)];
            extendedKey[0] = 0x80; // Versiyon baytý
            Buffer.BlockCopy(privateKey, 0, extendedKey, 1, privateKey.Length);

            // Sýkýþtýrma baytýný ekleyin
            if (compressed)
            {
                extendedKey[extendedKey.Length - 1] = 0x01;
            }

            // Ýlk SHA256 hash
            byte[] firstSHA = SHA256.Create().ComputeHash(extendedKey);

            // Ýkinci SHA256 hash
            byte[] secondSHA = SHA256.Create().ComputeHash(firstSHA);

            // Ýlk 4 baytýný alýn (checksum)
            byte[] checksum = secondSHA.Take(4).ToArray();

            // Versiyon baytý, özel anahtar ve checksum'ý birleþtirin
            byte[] finalKey = new byte[extendedKey.Length + 4];
            Buffer.BlockCopy(extendedKey, 0, finalKey, 0, extendedKey.Length);
            Buffer.BlockCopy(checksum, 0, finalKey, extendedKey.Length, checksum.Length);

            // Base58 encode
            return Base58Encode(finalKey);
        }

        static string Base58Encode(byte[] array)
        {
            const string Base58Chars = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";

            // Base58 encoding için uzunluðu artýrýlmýþ bir big integer hesaplayýn
            BigInteger intData = array.Aggregate<byte, BigInteger>(0, (current, t) => current * 256 + t);

            // Base58 karakter dizisi
            var result = new StringBuilder();
            while (intData > 0)
            {
                int remainder = (int)(intData % 58);
                intData /= 58;
                result.Insert(0, Base58Chars[remainder]);
            }

            // Önde gelen sýfýrlarý korumak için `1` karakterini ekleyin
            foreach (var t in array.TakeWhile(t => t == 0))
            {
                result.Insert(0, '1');
            }

            return result.ToString();
        }

        static string UncompressedPublicKey(byte[] privateKey)
        {
            var key = new Key(privateKey);
            string uncompressedPublicKey = key.PubKey.Decompress().ToHex();
            return uncompressedPublicKey;
        }

        static string CompressedPublicKey(byte[] privateKey)
        {
            var key = new Key(privateKey);
            string compressedPublicKey = key.PubKey.Compress().ToHex();
            return compressedPublicKey;
        }

        static string UncompressedAddress(string uncompressedPubKeyHex)
        {
            var publicKey = new PubKey(uncompressedPubKeyHex);
            var uncompressedAddress = publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main).ToString();
            return uncompressedAddress;
        }

        static string CompressedAddress(string compressedPubKeyHex)
        {
            var publicKey = new PubKey(compressedPubKeyHex);
            var compressedAddress = publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main).ToString();
            return compressedAddress;
        }

        static string SegwitAddressUncompressed(string uncompressedPubKeyHex)
        {
            var publicKey = new PubKey(uncompressedPubKeyHex);
            var segwitAddress = publicKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main).ToString();
            return segwitAddress;
        }

        static string SegwitAddressCompressed(string compressedPubKeyHex)
        {
            var publicKey = new PubKey(compressedPubKeyHex);
            var segwitAddress = publicKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main).ToString();
            return segwitAddress;
        }

        static string SegwitP2SHAddressUncompressed(string uncompressedPubKeyHex)
        {
            var publicKey = new PubKey(uncompressedPubKeyHex);
            var segwitP2SHAddress = publicKey.GetAddress(ScriptPubKeyType.SegwitP2SH, Network.Main).ToString();
            return segwitP2SHAddress;
        }

        static string SegwitP2SHAddressCompressed(string compressedPubKeyHex)
        {
            var publicKey = new PubKey(compressedPubKeyHex);
            var segwitP2SHAddress = publicKey.GetAddress(ScriptPubKeyType.SegwitP2SH, Network.Main).ToString();
            return segwitP2SHAddress;

        }

        static string TaprootBIP86AddressCompressed(string compressedPubKeyHex)
        {
            var publicKey = new PubKey(compressedPubKeyHex);
            var taprootBIP86Address = publicKey.GetAddress(ScriptPubKeyType.TaprootBIP86, Network.Main).ToString();
            return taprootBIP86Address;
        }

        private void segwitComp_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
