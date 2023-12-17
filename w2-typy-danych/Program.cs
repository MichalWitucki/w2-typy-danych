namespace w2_typy_danych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex1();
            ex2();
            ex3();
            ex4();
            ex5();
        }

        private static void ex5()
        {
            Console.Write("Podaj imię: ");
            String name = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            String lastname = Console.ReadLine();
            Console.Write("Podaj nr telefonu: ");
            String phoneNumber = Console.ReadLine();
            Console.Write("Podaj adres e-mail: ");
            String email = Console.ReadLine();
            Console.Write("Podaj wzrost: ");
            String heightStr = Console.ReadLine();
            float height = float.Parse(heightStr);
            Console.Write("Podaj wagę: ");
            String weightStr = Console.ReadLine();
            float weight = float.Parse(weightStr);
            Console.Write("Podaj wiek: ");
            String ageStr = Console.ReadLine();
            int age = Int32.Parse(ageStr);
            Console.Write("Podaj rok urodzenia: ");
            String yearOfBirthStr = Console.ReadLine();
            int yearOfBirth = Int32.Parse(yearOfBirthStr);
            Console.Write("Podaj numer buta: ");
            String shoeSizeStr = Console.ReadLine();
            float shoeSize = float.Parse(shoeSizeStr);

            Console.WriteLine($"{name} {lastname}, @: {email}, M: {phoneNumber}, H: {height}, W: {weight}, Lat: {age}, Urodzony: {yearOfBirth}");
        }

        private static void ex4()
        {
            int a;
            String b;
            float c;

            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5f;
        }

        private static void ex3()
        {
            Console.WriteLine("zad.3:");
            int a, b;
            double diagonal;
            
            do
            {
                Console.Write("podaj długość pierwszego boku: ");
                String aString = Console.ReadLine();
                Console.Write("podaj długość drugiego boku: ");
                String bString = Console.ReadLine();
                _ = (Int32.TryParse(aString, out a) && Int32.TryParse(bString, out b)) 
                    ? diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) 
                    : diagonal = 0;
            } while (diagonal <= 0);
            Console.WriteLine($"Przekątna = {diagonal}");
        }

        private static void ex2()
        {
            Console.WriteLine("zad.2:");
            char a = 'a';
            char b = 'b';
            char c = 'c';
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }

        private static void ex1()
        {
            Console.WriteLine("zad.1:");
            String name;
            String lastName;
            int age;
            Sex sex;
            uint pesel;
            uint id;
        }
    }

    public enum Sex
    {
        male,
        female
    }
}