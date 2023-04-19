[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- Senaryo -->
## Senaryo

Aşağıdaki tablolarda detayları verilmiş indirim tablosuna göre, kullanıcı sepetine eklenecek rastgele ürünler ile satın
alım fiyatının hesaplanması istenmektedir.

Uygulamadan beklenilen:

- [x] Sepete 7 adede kadar ürün eklenmesi beklenmektedir.
- [x] Eklenecek ürünler ve sepet miktarları rastgele seçilmeli.
- [x] Ürün fiyatları uygulama başlangıcında programcı tarafından belirlenmeli
- [x] Ürün fiyatları 100-1000 TL arasında verilmelidir.
- [x] Sepete eklenen ürünler en az 1, en fazla 10 adet olabilir.
- [x] Ürün adedi 1 olması durumunda indirimoranı hesaplamaya tabi tutulmaz.
- [x] İndirim hesabı yapılırken, her grubu kendi grup toplamına karşılık gelen indirim oranı uygulanır.


### 🔗 İNDİRİM TABLOSU

| Fiyat Aralığı (TL)  | İndirim Oranı|
| -------------       | -------------|
| 0.1-1000            |      %0      |
| 1001 - 2000         |      %1      |
| 2001 - 3000         |      %2      |
| 3001 - 4000         |      %3      |
| 4001 - 5000         |      %4      |
| 5001 - 6000         |      %5      |
| 6001 - 7000         |      %6      |


### 🔗 ÜRÜN GRUPLARI
| 1.Grup                | 2.Grup     |  3.Grup          |
| --------------------- |------------|------------------|
| Bilgisayar            | Masa       | Eldiven          |
| Monitör               | Sandalye   | Sedye            |
| Yazıcı                | Koltuk     | Diş Ünitesi      |
| Laptop                | Sehpa      | Ultrason Cihazı  |
| Projeksiyon Cihazı    | Keson      | MR Cihazı        |


### 🔗 ÖRNEK
| Ürün       | Birim Fiyat | Sipariş Adet | Toplam    | İndirimli Tutar |
| ---------- | -----------| ------------| ---------| ----------------|
| Bilgisayar | 200 TL     | 20          | 4000 TL | 3840 TL         |
| Yazıcı     | 50 TL      | 15          | 750 TL  | 720 TL          |
| MR Cihazı  | 1000 TL    | 1           | 1000 TL | 1000 TL         |
| Sedye      | 300 TL     | 10          | 3000 TL | 2940 TL         |
| Masa       | 75 TL      | 20          | 1500 TL | 1485 TL         |
|Sepet Tutarı:    9985 TL         


<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

[![dotnet][dotnet]][dotnet-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Getting Started -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

What needs to be installed on the device in order to run the codes.

* C#
* Visual Studio


### Installation

You can use the following command to download the repository.

1. Clone the repo
   ```sh
   git clone https://github.com/emredemirr/CartProblem
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Emre Demir - [email](mailto:emreedemir@yahoo.com)

<p align="right">(<a href="#readme-top">back to top</a>)</p>




<!-- MARKDOWN LINKS & IMAGES -->
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/emredemirr/Beginner-Level-Java-Development/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/emredemirr/
[dotnet]: https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white
[dotnet-url]: https://microsoft.com/
