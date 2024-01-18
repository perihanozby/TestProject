ToString() Yöntemi:

Her veri türü değişkeninin bir ToString() yöntemi bulunmaktadır. Bu yöntem, belirli bir tür üzerinde nasıl uygulandığına bağlı olarak çalışır. Genellikle temel değerlerde genişletme dönüştürmesi gerçekleştirir.
//string message = first.ToString() + second.ToString();


Parse() Yöntemi:

Sayısal veri türlerinin çoğunda, bir dizeyi o veri türüne dönüştüren bir Parse() yöntemi bulunmaktadır. Örneğin, int.Parse() metodu, bir dizeyi int türüne dönüştürebilir.
//int sum = int.Parse(afirst) + int.Parse(asecond);

(Convert sınıfı) yardımıyla bir değeri bir türden diğerine dönüştürmek:
ToInt32() yöntemi, C# programlama dilinin int anahtar kelimesine eşleşen .NET Sınıf Kitaplığındaki temel alınan veri türünün adı olan System.Int32'ye dayanmaktadır. Bu isimlendirme standardı, .NET Sınıf Kitaplığındaki veri türlerini belirtir.

Convert Sınıfının Avantajları:

Convert sınıfı, özellikle kesirli sayıları tam sayılara dönüştürmek için en uygun seçenektir. Bu nedenle, beklenen davranışı sağlamak adına yuvarlama işlemlerini doğru bir şekilde gerçekleştirir. 
//int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);

/////////////////////////////////////////////
Özetle, Convert sınıfı geniş bir veri türü dönüştürme yeteneğine sahiptir ve ToInt32() gibi yöntemleri, .NET Sınıf Kitaplığındaki standart adlandırmaya uygun olarak isimlendirilmiştir. TryParse() yöntemi ise güvenli dönüşümler için önerilmektedir.
//////////////////////////////////////////////

TryParse() yöntemini kullanın
TryParse() yöntemi aynı anda birkaç şeyi yapar:

Bir dizeyi verilen sayısal veri türüne göre ayrıştırmayı dener.
Başarılı olursa, dönüştürülen değeri aşağıdaki bölümde açıklanan bir out parametresinde depolar.
Eylemin başarılı mı yoksa başarısız mı olduğunu belirtmek için bir bool döndürür.

///////////////////////////////////////////////////////

Özet:

TryParse() yöntemi, dizeyi sayısal bir veri türüne güvenli bir şekilde dönüştürmek için kullanışlı bir araçtır. Bu kısa özetle birkaç önemli noktayı belirtmek istiyorum:

Bir dizeyi sayısal bir veri türüne dönüştürmek istiyorsanız, TryParse() yöntemini tercih edin.

TryParse() yöntemi, dönüştürme başarılı olduğunda true, başarısız olduğunda ise false döndürür.

out parametreleri, bir yöntemin ikincil bir çıkışı olarak kullanılır. TryParse() yöntemi örneğinde, dönüştürülen değeri içeren bir değişken, out parametresi aracılığıyla elde edilir.

out parametresi kullanırken, bir değişkenin değerini döndüren yönteme bağımsız bir değişken geçirirken out anahtar kelimesini kullanmalısınız. Bu sayede dönüştürülen değeri döndüren ve başarısız durumda sıfır değeri atanmış bir değişkeni belirten daha güvenli bir yapı elde edilir.
///////////////////////////////////////////////////////////////////