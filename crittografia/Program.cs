namespace crittografia
{
    internal class Program
    {
        static char[] Sostituzione(char[] alfabeto, char[] nome, int k)
        {
            int indFin;

            for(int i = 0; i < nome.Length; i++)
            {
                int indAlf = 0;

                while (nome[i] != alfabeto[indAlf])
                {                                      
                   indAlf++;

                }

                if (indAlf + k > alfabeto.Length - 1)
                {

                    indFin = k - (alfabeto.Length - indAlf);

                    nome[i] = alfabeto[indFin];

                }
                else
                {
                    nome[i] = alfabeto[indAlf + k];

                }

            }
            return nome;
        }

        static char[] Traslazione(char[] nome, int k)
        {
            char[] vetTras = new char[nome.Length];

            for(int i = 0; i<nome.Length; i++)
            {

                vetTras[i] = nome[(i + k) % k];
                
            }
        }
        static void Main(string[] args)
        {
            int key = 2;
            char[] alfa = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string parola;

            Console.Write("Inserisci la parola: ");
            parola = Console.ReadLine();

            char[] parolaArray = parola.ToCharArray();

            char[] parolaSostituzione = Sostituzione(alfa, parolaArray, key);

            for (int i = 0; i < parolaSostituzione.Length; i++)
            {
                Console.Write(parolaSostituzione[i]);  
            }

            char[] parolaTraslazione = Traslazione(parolaSostituzione, key);

            for (int i = 0; i < parolaSostituzione.Length; i++)
            {
                Console.Write(parolaTraslazione[i]);
            }
        }
    }
}
