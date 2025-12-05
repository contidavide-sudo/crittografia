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

        static char[] Trasposizione(char[] nome, int k)
        {
            char[] vetTras = new char[nome.Length];

            int indFin;

            for(int i = 0; i<nome.Length; i++)
            {

                if (i + k > nome.Length - 1)
                {
                    indFin = k - (nome.Length - i);

                    vetTras[indFin] = nome[i];

                }
                else
                {
                    vetTras[i + k] = nome[i];
                }
                
                
            }
            return vetTras;
        }

        static char[] TrasposizioneInv(char[] nome, int k)
        {
            char[] vetTras = new char[nome.Length];

            int indFin;

            for (int i = 0; i < nome.Length; i++)
            {

                if (i - k < 0)
                {
                    indFin = nome.Length + (i - k);

                    vetTras[indFin] = nome[i];

                }
                else
                {
                    vetTras[i - k] = nome[i];
                }


            }
            return vetTras;
        }

        static char[] SostituzioneInv(char[] alfabeto, char[] nome, int k)
        {
            int indFin;

            for (int i = 0; i < nome.Length; i++)
            {
                int indAlf = 0;

                while (nome[i] != alfabeto[indAlf])
                {
                    indAlf++;

                }

                if (indAlf - k < 0)
                {

                    indFin = alfabeto.Length + (indAlf - k);

                    nome[i] = alfabeto[indFin];

                }
                else
                {
                    nome[i] = alfabeto[indAlf - k];

                }

            }
            return nome;
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

            Console.Write("Parola con sostituzione: ");

            for (int i = 0; i < parolaSostituzione.Length; i++)
            {
                Console.Write(parolaSostituzione[i]);  
            }

            Console.WriteLine();

            char[] parolaTraslazione = Trasposizione(parolaSostituzione, key);

            Console.Write("Parola con trasposizione: ");

            for (int i = 0; i < parolaSostituzione.Length; i++)
            {
                Console.Write(parolaTraslazione[i]);
            }

            Console.WriteLine();

            char[] parolaTraslazioneInv = TrasposizioneInv(parolaTraslazione, key);

            Console.Write("Parola con trasposizione decifrata: ");

            for (int i = 0; i < parolaSostituzione.Length; i++)
            {
                Console.Write(parolaTraslazioneInv[i]);
            }

            Console.WriteLine();

            char[] parolaSostituzioneInv = SostituzioneInv(alfa, parolaArray, key);

            Console.Write("Parola con sostituzione decifrata: ");

            for (int i = 0; i < parolaSostituzione.Length; i++)
            {
                Console.Write(parolaSostituzioneInv[i]);
            }
        }
    }
}
