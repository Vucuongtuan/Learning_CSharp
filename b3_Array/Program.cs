// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Array Number 
int[] numbers = { 1, 2, 3, 4, 5 };
// Array String
string[] names = { "Vũ", "Cường", "Huy", "Tâm", "Hà" };

// Array Number Empty
int[] emptyNumbers = new int[5];
emptyNumbers[0] = 1;
emptyNumbers[1] = 2;


// IN ra màn hình sử dụng ForEach , không hỗ trợ index
Array.ForEach<string>(names, (string n) =>
{
    Console.WriteLine($"{n}");
});

// Sử dụng for truyền thống
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{i} - {names[i]}");
}


// -- NEW -- 

// Có thể khởi tạo 1 mảng ko gán giá trị  \
// Nhưng phải gán giá trị sau khi khởi tạo
string[] productNames = new string[3];
productNames[0] = "Iphone";
productNames[1] = "Samsung";
productNames[2] = "Nokia";

// Có thể khởi tạo 1 mảng ko gán số lượng phần tử lúc này mảng sẽ tự động theo value được truyền vào 

string[] n = new string[] { "iphone", "samsung", "nokia" };
// =>> length = 3
// Console.WriteLine(n.Length);