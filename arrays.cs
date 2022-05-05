namespace Arrays_example
{
    class Program
    {
        static void Main(string[] args){
            int c, aux, i;
            int [] x = new int[15];

            for (c = 0; c < 15; c++) {
                Console.WriteLine("Digite o {0}° valor:", c+1);
                x[c] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
        for(c = 1; c < 15; c++){ 
        for(i = 0; i < 14; i++){
            if (x[i] > x[i + 1]){
                aux = x[i];
                x[i] = i + 1;
                x[i + 1] = aux;
            }
        }
        }
        for(c = 0; c < 15; c++){
            Console.Write(x[c] + ",");
        }
}
}
}
