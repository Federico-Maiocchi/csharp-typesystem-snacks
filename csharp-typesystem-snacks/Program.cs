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

            //int[] arrayNumeri = { 2, 3, 4, 5, 6, 7, 8, };

            //int somma = 0;

            //for (int i = 0; i < arrayNumeri.Length; i++)
            //{
            //    Console.WriteLine(arrayNumeri[i]);

            //    somma += arrayNumeri[i];
            //}

            //Console.WriteLine($"La somma dei numeri: {somma}");

            //int media = somma / arrayNumeri.Length;
            //Console.WriteLine($"La media è: {media}");

            //Snack 5
            //Il software chiede all’utente di inserire un numero.
            //Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

            //Console.WriteLine("Inserisci un numero");
            //int numeroInserito;
            //numeroInserito = Convert.ToInt32(Console.ReadLine());

            //if (numeroInserito % 2 == 0)
            //{
            //    Console.WriteLine($"il tuo numero {numeroInserito} è pari");
            //} else
            //{
            //    int numeroSuccessivo = ++numeroInserito;
            //    Console.WriteLine($"Numero successivo {numeroSuccessivo}");
            //}


            //Snack 6
            //In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
            //Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

            //string[] nomiLista = { "Leopoldo", "Marcobaldo", "Ginevra", "Artorias", "Pingu" };

            //Console.WriteLine("Benvenuto alla festa del grande Gatsby, mi può dire il suo nome?");
            //string nomeUser = Console.ReadLine();


            //for (int i = 0; i < nomiLista.Length; i++)
            //{
            //    if (nomiLista[i] == nomeUser)
            //    {
            //        Console.WriteLine("Puoi entrare");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Non puoi entrare");
            //    }

            //}

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

            //Creo arrayVuoto di lunghezza 6 elementi
            int[] arrayVuoto = new int[6];

            //DIchiaro una variabile per tracciare i numeri
            int indice = 0;

            for (int i = 0; i < 6; i++)
            {
                //CHiedo all'utente di inserire un numero
                Console.WriteLine("Inserisci un numero:");
                int userNumero = Convert.ToInt32(Console.ReadLine());

                //controllo se il numero inserito dall'utente è dispari
                if (userNumero % 2 == 1)
                {
                    //il numero dispari lo inserisocnell'array 
                    arrayVuoto[indice] = userNumero;

                    //INCREMENTO l'indice per passare al prossimo elemento dell'array
                    indice++;
                }
            }

            //CIclo for per vedere quanti elementi sono all'intrno del mio array
            for (int j = 0; j < indice; j++)
            {
                //Stampo ogni elemento dell'array
                Console.WriteLine($"Numeri dispari inseriti: {arrayVuoto[j]}");
            }

            //Snack 8
            //Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

            //Creo l'array di numeri da 2 a 8
            int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Inizializzo la somma dei numeri con indice dispari
            int sommaIndiciDispari = 0;

            //Ciclo l'array di numeri 
            for (int i = 0; i < arrayInt.Length; i++)
            {
                //Console.WriteLine($"indice: {i} - numero: {arrayInt[i]}");

                //COntrollo per prendere solo i numeri che hanno indice dispari
                if (i % 2 == 1)
                {
                    Console.WriteLine($"Indice dispari{i} - NUmero {arrayInt[i]}");
                    sommaIndiciDispari += arrayInt[i];
                }

            }

            Console.WriteLine($"Totale somma numeri con indice dispari: {sommaIndiciDispari}");


            //Snack 9
            //Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
            //Continua a chiedere i numeri all’utente e a inserirli nell’array, fino 
            //a quando la somma degli elementi è minore di 50.

            //Creo un array vuoto di dimensione 100
            int[] arrayVuoto2 = new int[100];

            //Dichiaro una variabile per la somma
            int somma2 = 0;

            //Dichiaro una variabile per l'indice dei numeri
            int indice2 = 0;

            //Ciclo WHILE che continua a funzionare finchè la somma è minore di 50
            while (somma2 < 50)
            {
                //Numeri inseriti dall'utent
                Console.Write("Scrivi un numero -");
                int numeroUser3 = Convert.ToInt32(Console.ReadLine());

                //Assegno il numero inserito dall'utente all'array
                arrayVuoto2[indice2] = numeroUser3;

                //Aggiornoo la soma degli elementi
                somma2 += numeroUser3;

                //Incremento indice per passare al prossimo array
                indice2++;
            }

            //Somma di tutti gli elementi
            Console.WriteLine("SOmmma: " + somma2);

            //Messaggio di interruzione degli elementi
            Console.WriteLine("La somma degli elementi è maggiore o uguale a 50.");

            //Ciclo per stampare gli elemnti inseriti 
            for (int i = 0; i < indice2; i++)
            {
                //Stampo di ogni elemento nell'array
                Console.WriteLine($"Gli elementi inseriti sono: {arrayVuoto2[i]}");
            }

            //Snack 10
            //Fai inserire un numero, che chiameremo N, all’utente.
            //Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
            //Ogni volta che ne crei uno, stampalo a schermo.

            //Chiedo all'utente il numero da inserire
            Console.WriteLine("Inserisci un numero");

            //numero della variabile per la quantità degli array
            int N;
            //Conversione della stringa in numero
            N = Convert.ToInt32(Console.ReadLine());

            //Utilizzo classe Random
            Random random = new Random();

            //Ciclo FOR per creare gli array in base ad N
            for (int i = 1; i <= N; i++)
            {
                //Creo un array con 10 elementi 
                int[] arrayNumeri3 = new int[10];

                //Ciclo for per per riempire gli array con elementi random 
                for (int j = 0; j < arrayNumeri3.Length; j++)
                {
                    //Creo una variabile dove andrò a inserire numeri generati random da 1 a 100 
                    int numeriRandom = random.Next(1, 100);
                    arrayNumeri3[j] = numeriRandom;
                }

            }

        }
    }
}
