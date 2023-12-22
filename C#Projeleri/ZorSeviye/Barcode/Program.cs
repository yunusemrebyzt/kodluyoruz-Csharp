using System;
using System.IO;
using SkiaSharp;
using ZXing;
using ZXing.SkiaSharp;
using ZXing.SkiaSharp.Rendering;

class Program
{
    static void Main()
    {
        bool devam = true;
        
        while(devam)
        {

            Console.WriteLine("\nYapmak istediğiniz işlemi seçiniz : ");
            Console.WriteLine("1->QR code oluştur \n2->QR code oku \n3->Çıkış yap");
            int secim = int.Parse(Console.ReadLine());


            if(secim == 1)
            {
                Console.WriteLine("Oluşturacağını QR code içeriğinde ne yazsın : ");
                string qrCodeContent = Console.ReadLine();

                Console.WriteLine("\nOluşturulacak olan qr Code un dosya ismi ne olsun? ");
                string fileName = Console.ReadLine();

                // QR kodu oluşturucu
                BarcodeWriter skBarcodeWriter = new BarcodeWriter();
                skBarcodeWriter.Format = BarcodeFormat.QR_CODE;

                // SkiaSharp renderer'ını ayarla
                skBarcodeWriter.Renderer = new SKBitmapRenderer();

                // QR kodunu SKBitmap'e dönüştürme
                SKBitmap barcodeBitmap = skBarcodeWriter.Write(qrCodeContent);

                // QR kodunu bir dosyaya kaydetme
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //string fileName = "QRCode.png";
                string filePath = Path.Combine(desktopPath, $"{fileName}.png");

                // Dosyayı masaüstüne kaydet
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    barcodeBitmap.Encode(SKEncodedImageFormat.Png, 100).SaveTo(stream);
                }

                Console.WriteLine($"\nQR kodu başarıyla oluşturulup masaüstüne kaydedildi: {filePath}");
            }

            else if(secim == 2)
            {
                
                Console.WriteLine("\nOkumak istediğiniz QR code dosyasının ismini giriniz  (Örn: qrcode.png) : ");
                string qrName = Console.ReadLine();

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, qrName);


                BarcodeReader barcodeReader = new BarcodeReader();


                SKBitmap qrCodeBitmap = SKBitmap.Decode(filePath);


                ZXing.Result result = barcodeReader.Decode(qrCodeBitmap);

                if(result != null)
                {
                    Console.WriteLine($"\nokunan QR Kodu : {result.Text}");
                }
                else{
                    Console.WriteLine("Qr kodu okunamadı ");
                }

            }
            else if(secim == 3)
            {
                devam = false;
            }
        }
        // QR kodu içeriği
       // string qrCodeContent = "Hello, ZXing.Net!";

        
        
        

        

        


        
    }
}
