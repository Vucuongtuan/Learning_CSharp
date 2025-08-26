// This program demonstrates various ways to declare, initialize, and iterate through
// single-dimensional, multi-dimensional, and jagged arrays in C#.

Console.WriteLine("--- Array Demonstrations in C# ---");

// --- 1. Single-Dimensional Arrays ---
Console.WriteLine("\n1. Single-Dimensional Arrays:");

// Initialize an array with values directly.
string[] names = { "Vũ", "Cường", "Huy", "Tâm", "Hà" };

Console.WriteLine("\nIterating with a for loop (provides index):");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"  Index {i}: {names[i]}");
}

Console.WriteLine("\nIterating with a foreach loop (simpler, no index):");
foreach (var name in names)
{
    Console.WriteLine($"  Name: {name}");
}

// Declare an array and initialize it later.
string[] productNames = new string[3];
productNames[0] = "Iphone";
productNames[1] = "Samsung";
productNames[2] = "Nokia";
Console.WriteLine($"\nInitialized product array with {productNames.Length} elements.");


// --- 2. Multi-Dimensional Array (2D Array / Matrix) ---
Console.WriteLine("\n\n2. Multi-Dimensional (2D) Array:");
string[,] matrix =
{
    { "A1", "B1" },
    { "A2", "B2" }
};

Console.WriteLine("Iterating through the 2D array:");
for (int i = 0; i < matrix.GetLength(0); i++) // Gets the size of the first dimension
{
    for (int j = 0; j < matrix.GetLength(1); j++) // Gets the size of the second dimension
    {
        Console.Write($"  {matrix[i, j]}");
    }
    Console.WriteLine();
}


// --- 3. Jagged Array (Array of Arrays) ---
Console.WriteLine("\n\n3. Jagged Array (Array of Arrays):");
// A jagged array is an array whose elements are arrays, possibly of different sizes.
int[][] jaggedArray =
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 5 },
    new int[] { 6, 7, 8, 9 }
};

Console.WriteLine("Iterating through the jagged array:");
for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write($"  Row {i}:");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write($" {jaggedArray[i][j]}");
    }
    Console.WriteLine();
}
// --- 4. Array of Objects ---
Console.WriteLine("\n4. Array of Objects:");

// Define an array of objects with name, price and status
var products = new[]
{
    new { Name = "Laptop", Price = 999.99m, Status = "In Stock" },
    new { Name = "Phone", Price = 599.99m, Status = "Out of Stock" },
    new { Name = "Tablet", Price = 299.99m, Status = "In Stock" },
    new { Name = "Smartwatch", Price = 199.99m, Status = "Low Stock" }
};

Console.WriteLine("Product Information:" + products.Rank);
foreach (var product in products)
{
    Console.WriteLine($"  Name: {product.Name}, Price: ${product.Price}, Status: {product.Status}");
}
