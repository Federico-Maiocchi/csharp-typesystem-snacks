namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //------------------------------
            //Snack 1
            //L’utente inserisce due numeri in successione.
            //Il software stampa il maggiore.

            //int numero1;
            //int numero2;

            //Console.WriteLine("Inserisci un numero");
            //numero1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Inserisci un altro numero");
            //numero2 = Convert.ToInt32(Console.ReadLine());

            //if (numero1 > numero2)
            //{
            //    Console.WriteLine($"Il primo numero che hai scelto ({numero1}) è più grande rispetto il secondo ({numero2})");
            //}
            //else
            //{
            //    Console.WriteLine($"Il secondo numero che hai scelto ({numero2}) è più grande rispetto il primo ({numero1})");
            //}

            //------------------------------
            //Snack 2
            //L’utente inserisce due parole in successione.
            //Il software stampa prima la parola più corta, poi la parola più lunga.

            //Console.WriteLine("Inserisci una parola");
            //string parola1 = Console.ReadLine();

            //Console.WriteLine("Inserisci un'altra parola");
            //string parola2 = Console.ReadLine();

            //if (parola1.Length > parola2.Length)
            //{
            //    Console.WriteLine($"Prola più piccola:  {parola2} (Seconda ad essere inserita)");
            //    Console.WriteLine($"Parola più lunga: {parola1} (prima ad essere inserita)");
            //}
            //else
            //{
            //    Console.WriteLine($"Prola più piccola: {parola1} (prima ad essere inserita)");
            //    Console.WriteLine($"Parola più lunga: {parola2} (Seconda ad essere inserita)");
            //}


            //Snack 3
            //Il software deve chiedere per 10 volte all’utente di inserire un numero.
            //Il programma stampa la somma di tutti i numeri inseriti.

            //int totale = 0;

            //for (int i = 0; i < 10; i++ )
            //{
            //    Console.WriteLine($"Inserisci un numero {i + 1}");
            //    int numeroUser; 
            //    numeroUser = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"{i + 1} - numero scelto: {numeroUser}");

            //    totale += numeroUser;

            //}

            //Console.WriteLine(totale);

            //Snack 4
            //Calcola la somma e la media dei numeri da 2 a 10.

            int[] arrayNumeri = { 2, 3, 4, 5, 6, 7, 8, };

            int somma = 0;

            for (int i = 0; i < arrayNumeri.Length; i++)
            {
                Console.WriteLine(arrayNumeri[i]);

                somma += arrayNumeri[i];
            }

            Console.WriteLine($"La somma dei numeri: {somma}");

            int media = somma / arrayNumeri.Length;
            Console.WriteLine($"La media è: {media}");

            //Snack 5
            //Il software chiede all’utente di inserire un numero.
            //Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

            Console.WriteLine("Inserisci un numero");
            int numeroInserito;
            numeroInserito = Convert.ToInt32(Console.ReadLine());

            if (numeroInserito % 2 == 0)
            {
                Console.WriteLine($"il tuo numero {numeroInserito} è pari");
            } else
            {
                int numeroSuccessivo = ++numeroInserito;
                Console.WriteLine($"Numero successivo {numeroSuccessivo}");
            }


            //Snack 6
            //In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
            //Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

            string[] nomiLista = { "Leopoldo", "Marcobaldo", "Ginevra", "Artorias", "Pingu" };

            Console.WriteLine("Benvenuto alla festa del grande Gatsby, mi può dire il suo nome?");
            string nomeUser = Console.ReadLine();


            for (int i = 0; i < nomiLista.Length; i++)
            {
                if (nomiLista[i] == nomeUser)
                {
                    Console.WriteLine("Puoi entrare");
                }
                else
                {
                    Console.WriteLine("Non puoi entrare");
                }

            }

            //int pos = Array.IndexOf(nomiLista, nomeUser);

            //if (pos > - 1)
            //{
            //    Console.WriteLine("Puoi entrare");
            //} else
            //{
            //    Console.WriteLine("Non puoi entrare");
            //}


            //Snack 7
            //Crea un array vuoto.
            //Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

            //Snack 8
            //Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

            //Snack 9
            //Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
            //Continua a chiedere i numeri all’utente e a inserirli nell’array, fino 
            //a quando la somma degli elementi è minore di 50.

            //Snack 10
            //Fai inserire un numero, che chiameremo N, all’utente.
            //Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
            //Ogni volta che ne crei uno, stampalo a schermo.

        }
    }
}
