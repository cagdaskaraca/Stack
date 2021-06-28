# Stack

Soru 2- Tek bir dizi içerisinde, 3 tane stack tutmak isterseniz, bunu nasıl yaparsınız?



**Çözüm açıklaması:**

3 tane stack olacağı için bir dizinin içerisinde mod3 e göre sıralanabilirler.

Örneğin:

Stack1: 1, 2, 3, 4

Stack2: 'a', 'b'

Stack3: "x", "y", "z"

*Not: 4 elemana kadar bu yöntem ile kullanılabilir. 5. elemana geldiğimizde 2 ile 4 ün ebobu 1 dışında bir sayı(2) olduğundan bu mantık çakışmalara neden olacaktır.*

push(int x, int sn) –> x'i 'sn' yığın numarasına iter, burada sn 0 ile k-1 arasındadır
pop(int sn) –> sn'nin 0 ile k arasında olduğu 'sn' yığın numarasından bir öğe çıkarır -
Yöntem 1 (Diziyi n/k boyutundaki yuvalara bölünür) k yığını uygulamanın basit bir yolu, diziyi her biri n/k boyutunda k yuvaya bölmek ve yuvaları farklı yığınlar için sabitlemektir, yani arr[0 kullanın ] ilk yığın için dizi[n/k-1] ve dizi[n/k] ila dizi[2n/k-1] yığın2 için burada dizi[] iki yığını ve dizinin boyutunu uygulamak için kullanılacak dizidir.

Bu yöntemle ilgili sorun, dizi alanının verimsiz kullanılmasıdır. Bir yığın ekleme işlemi, dizi[] içinde kullanılabilir alan olsa bile yığın taşmasına neden olabilir. Örneğin, k'nin 2 ve dizi boyutunun (n) 6 olduğunu ve birinciye 3 öğeyi ittiğimizi ve ikinci ikinci yığına hiçbir şey itmediğimizi varsayalım. 4. elemanı birinciye bastığımızda dizide 3 eleman için daha yerimiz olsa bile taşma olacaktır.

Yöntem 2 (Alanı verimli kullanan bir uygulama) Fikir, bir dizideki k yığının verimli bir şekilde uygulanması için iki ekstra dizi kullanmaktır. Bu, tamsayı yığınları için pek anlamlı olmayabilir, ancak yığın öğeleri, örneğin her öğenin yüzlerce bayt olduğu çalışan, öğrenci vb. yığınları gibi büyük olabilir. Bu tür büyük yığınlar için, fazladan boşluk olarak iki tamsayı dizisi kullandığımızdan, kullanılan ekstra alan nispeten daha azdır .

Aşağıdaki iki ekstra dizi kullanılır:
1) top[]: Bu, k boyutundadır ve tüm yığınlarda üst öğelerin dizinlerini saklar.
2) next[]: Bu, n boyutundadır ve arr[] dizisindeki öğeler için sonraki öğenin dizinlerini saklar. Burada arr[], k yığınını depolayan gerçek dizidir.
k yığınıyla birlikte, arr[] içindeki bir boş yuva yığını da korunur. Bu yığının üst kısmı 'free' değişkeninde saklanır.

top[] içindeki tüm girişler, tüm yığınların boş olduğunu belirtmek için -1 olarak başlatılır. Tüm sonraki[i] girişleri i+1 olarak başlatılır çünkü tüm yuvalar başlangıçta boştur ve bir sonraki yuvayı gösterir. Boş yığının başında, boş 0 olarak başlatılır.

Yukarıdaki fikrin uygulanması aşağıdadır.
