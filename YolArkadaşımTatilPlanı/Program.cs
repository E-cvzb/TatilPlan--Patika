using System.Collections.Concurrent;
bool tatilSonuç= false;
do
{
    string konum = " ";
    int fiyat = 0;// her konumun fşyatını heaplamak için boş değer verilmiştir
    bool geçerlikonum = false;//döngüyü tekrar etirebilmek için yapılıyor 
    do
    {
        Console.WriteLine("Merhaba hoşgeldiniz size tatil planları için yardımcı olayım \n Bodrum için başlangıç fiyatımız -> 4000 \n Marmaris için paket başlangıç fiyatımımz ->3000 \n Çeşme için paket başlangıç fiyatımız -> 5000");
        Console.WriteLine("Hangi lokasyonu tercih edersiniz");
        konum = Console.ReadLine().ToUpper();


        switch (konum)
        {
            case "BODRUM":
                Console.WriteLine("Bodrum için fiyatımız -> 4000");
                Console.WriteLine("Bodrum çok kalabalık eğlenmek için çok güzel bir ortam var \n Bu aylarda sıcağa karşı güneş kreminizi unutmayınız!");
                geçerlikonum = true;
                fiyat = 4000;
                break;
            case "MARMARİS":
                Console.WriteLine("Marmaris için fiyatımız -> 3000");
                Console.WriteLine("Marmaris bu aylarda çok güzel olur nispeten sakin ve kafa dinlemelik bir ortam hakim \n Marmarsin mavi doğası vr tabiatı ile sizi bekliyoruz güneş kremiznizi unutmayın!");
                geçerlikonum = true;
                fiyat = 3000;
                break;
            case "ÇESME":
                Console.WriteLine("Çeşme için fiyatımız ->5000");
                Console.WriteLine("Çeşmenin eşsiz denizi sizi kendin ehayran bırakacak ");
                geçerlikonum = true;
                fiyat = 5000;
                break;
            default:
                Console.WriteLine("Lütfen tekrar belirtiniz");
                break;

        }
    } while (!geçerlikonum);

    Console.WriteLine("Kaç kişi tatil yapmayı planlıyorsunnuz");
    int kişi = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Tatile ne şekilde gitmel istersiniz");
    Console.WriteLine("İki seçeneğimiz var");
    Console.WriteLine("1- Kara yolu kişi başı fiyatımız (gidiş-dönüş)->1500 tl ");
    Console.WriteLine("2- Hava yolu kişi başı fiyatımı (gidiş-dönüş) ->4000 tl ");
    int yol = Convert.ToInt32(Console.ReadLine());
    int ulaşım = 0;// ulaşım fiyatını hesaplamak için depo ediliyor 
    bool ulaşımsonuç = false;
    do
    {
        switch (yol)
        {
            case 1:
                Console.WriteLine("Bu ulaşım türü için kişi başı 1500 tl hesaplayacağım");
                ulaşım = kişi * 1500;
                Console.WriteLine(ulaşım);
                ulaşımsonuç=true;

                break;
            case 2:
                Console.WriteLine("Bu ulaşım türü için kişi başı 4000 tl hesaplayacağım");
                ulaşım = kişi * 4000;
                Console.WriteLine(ulaşım);
                ulaşımsonuç = true;
                break;
            default:
                Console.WriteLine("yalış işlem yaptınız tekrar deneyiniz");
                break;


        }

    } while (!ulaşımsonuç);


    int total = ulaşım + fiyat;
    Console.WriteLine($"Tatil toplam ücreti {total} tl. İyi eğlenceler dileriz :)");


    Console.WriteLine("Tekrar bir tatil planlamak istiyorsanız 'EVET' yazınız");
    tatilSonuç = Console.ReadLine().ToUpper() == "EVET";

} while (tatilSonuç);

Console.WriteLine("İyi günler görüşmek üzere");

