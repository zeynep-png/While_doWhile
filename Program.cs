Console.WriteLine("Lütfen bir limit değeri giriniz: ");

int limit = 0;
bool validInput = false;

while(!validInput)
{
    string input = Console.ReadLine(); 
    if(int.TryParse(input, out limit) && limit >= 0 && limit != 0) // int ve pozitif bir değer alıp almadığımızı kontrol ediyoruz. Ayrıca 0 girdiğimizde de ekrana bir çıktı veriyor bunu kontrol edebilmek için 0 girdisini de eledim
    {
        validInput = true;
    }
    else
    {
        Console.WriteLine("Geçerli bir sayı giriniz: ");
    }
}

int sayac = 0; 

do
{
    Console.WriteLine("Ben bir Patikalı'yım");
    sayac++;
}
while(sayac <= limit);



Console.WriteLine("------------------------------------------------------");

int i = 0;
while (i <= limit)
{
    Console.WriteLine("Ben bir Patikalıyım");
    i++;

}
// do-while da döngü içeriği ilk yazılır sonra koşul yazılır bu sebepten döngü içeriği en az bir kere çalışır. while da ise ilk koşul kontrol edilir koşul tutmazsa döngüye girmez