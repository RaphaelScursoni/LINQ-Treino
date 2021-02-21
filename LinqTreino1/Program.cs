using System;
using System.Linq;

namespace LinqTreino1 {
    class Program {
        static void Main(string[] args) {

            //Especificar o Data source

            int[] numbers = new int[] { 2, 3, 4, 5 };

            // define a query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Executar a consulta

            foreach (int x in result) {
                Console.WriteLine(x);
            }

        }
    }
}
