
//variablelara mutleq deyer set olunmalidir yeni deyer assign olunmalidir başqa bir dildə desək dəyər mənimsədilməlidir. Əks təqdirdə biz onu nə ekrana çıxara bilmərik nə də başqa bir variabla mənimsədə bilmərik. Buradan anlıyırıq ki variablelara default dəyər avtomatik olaraq set olunmur




using CS303_05172024;

//className objectName = new className(); bu anlayış reference almaqdır, reference almaqdır və ya object newlamaqdır.
//bərabərliyin sol tərəfi  reference hissə adlanır və stack yaddaşda saxlanılır.

// Bərabərliyin sağ tərəfi isə bu referenceın reference etdiyi dəyəri yəni obyektin dəyəri və ya obyektin özü heap yaddaşda saxlanılacaq. Və nə zaman mən bu obyektə müraciət etmək istəsəm onun referencenı çağıracam və üzərində əməliyyatlar aparacam.

Students studentMehemmed = new Students()
{
    name = "Mehemmed",
    surname = "Baxışov",
};

Console.WriteLine(studentMehemmed.name);
//studentMehemmed.name => bizim üçün get etməkdir. Yəni datanı oxumaq üçün ramdan çağırırıq.

studentMehemmed.name = "Mehemmed";
studentMehemmed.surname = "Baxışov";
studentMehemmed.age = 20;
studentMehemmed.email = "mehemmed.baxisov@code.edu.az";
studentMehemmed.pinCode = "123ABCD";
studentMehemmed.username = "mehemmedCrazyBoy";
studentMehemmed.password = "parolusindirma";
studentMehemmed.phoneNumber = "+994502111111";
studentMehemmed.address = "Azərbaycan, Baku";

Console.WriteLine($"{studentMehemmed.name} {studentMehemmed.surname} {studentMehemmed.age} ");
