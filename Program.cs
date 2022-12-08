class program
{
    public static void Main(string[] args)
    {
        const int RESULTCOUNT = 10;

        string[] firstNameResult = new string[RESULTCOUNT];
        string[] middleNameResult = new string[RESULTCOUNT];
        string[] lastNameResult = new string[RESULTCOUNT];
        string[] firstNameMen = new string[] { "Michael", "Ted", "Luke", "John", "Christian", "Robert", "Bruce", "Chandler", "Joey", "Andrew" };
        string[] middleNameMen = new string[] { "William", "Thomas", "Peter", "Oscar", "Charles", "Gabriel", "John", "Jim", "Robert", "David" };
        string[] firstNameWomen = new string[] { "Rachel", "Jennifer", "Monica", "Lily", "Alexandra", "Mary", "Elizabeth", "Hailee", "Maddie", "Michelle" };
        string[] middleNameWomen = new string[] { "Rose", "Grace", "Jane", "Amy", "Victoria", "Catherine", "Kate", "Claire", "Alice", "Abigail" };
        string[] lastNames = new string[] { "Jhonson", "Carter", "Skywalker", "Cooper", "Brown", "Connor", "Olsen", "Smith", "Walker", "Wayne" };
        char[] consonant = new char[] { 'B', 'c', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
        char[] vocals = new char[] { 'A', 'E', 'I', 'O', 'U' };
        var stringChars = new char[8];

        var r = new Random();
        for (int i = 0; i < RESULTCOUNT; i++)
        {
            //generate random names
            string randomFirstMales = firstNameMen[r.Next(firstNameMen.Length)];
            string randommiddleNameMen = middleNameMen[r.Next(middleNameMen.Length)];
            string randomLastNames = lastNames[r.Next(lastNames.Length)];
            while (!IsNameUnique(randomFirstMales, randommiddleNameMen, randomLastNames, firstNameResult,
                                middleNameResult, lastNameResult, i))
            {
                //generate new male first and middle names
                randomFirstMales = firstNameMen[r.Next(firstNameMen.Length)];
                randommiddleNameMen = middleNameMen[r.Next(middleNameMen.Length)];
                randomLastNames = lastNames[r.Next(lastNames.Length)];
            }


            //store our names
            firstNameResult[i] = randomFirstMales;
            middleNameResult[i] = randommiddleNameMen;
            lastNameResult[i] = randomLastNames;

            //TODO:add further assignments here to store the rest of the names

            i++;
            string randomFirstFemales = firstNameWomen[r.Next(firstNameWomen.Length)];
            string randommiddleNameWomen = middleNameWomen[r.Next(middleNameWomen.Length)];
            randomLastNames = lastNames[r.Next(lastNames.Length)];

            while (!IsNameUnique(randomFirstFemales, randommiddleNameWomen, randomLastNames, firstNameResult,
                                middleNameResult, lastNameResult, i))
            {
                //generate new female first and middle names
                randomFirstFemales = firstNameWomen[r.Next(firstNameWomen.Length)];
                randommiddleNameWomen = middleNameWomen[r.Next(middleNameWomen.Length)];
                randomLastNames = lastNames[r.Next(lastNames.Length)];
            }
            //generate the jobs
            firstNameResult[i] = randomFirstFemales;
            middleNameResult[i] = randommiddleNameWomen;
            lastNameResult[i] = randomLastNames;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(firstNameResult[i] + " " + middleNameResult[i] + " " + lastNameResult[i] + " ");
            

        }
    }

    private static bool IsNameUnique(string first, string mid, string last,
                                   string[] firstsUsed, string[] midsUsed, string[] lastsUsed, int size)
    {
        for (int i = 0; i < size; i++)
        {
            if (first == firstsUsed[i] && mid == midsUsed[i] && last == lastsUsed[i])
            {
                return false;
            }
        }
        return true;
    }
}

