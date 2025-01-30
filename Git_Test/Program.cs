using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            import numpy as np

# Create an array
data = np.array([10, 20, 30, 40, 50])

# Perform operations
squared = data * *2
sum_of_elements = np.sum(data)
mean_value = np.mean(data)

# Add and multiply arrays
added_array = data + 5
multiplied_array = data * 2

# Display results
print("Original Array:", data)
print("Squared Array:", squared)
print("Sum of Elements:", sum_of_elements)
print("Mean Value:", mean_value)
print("Array + 5:", added_array)
print("Array * 2:", multiplied_array)

# Matrix example
matrix = np.array([[1, 2], [3, 4]])
matrix_transpose = np.transpose(matrix)
matrix_product = np.dot(matrix, matrix_transpose)

print("\nMatrix:\n", matrix)
print("Transpose of Matrix:\n", matrix_transpose)
print("Matrix Product:\n", matrix_product)

            Console.WriteLine("==========jfajlfk=======");
        }
    }
}
