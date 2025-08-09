namespace program {
class App {
    static void Main(string[] args) {
            int rows;
            int choice;
            string star="";
            Console.Write("Choose a star [*] [★] [✦] [✹] [✪]  (numbered from 1 to 5): ");
            string? userchoice = Console.ReadLine();
            while(!int.TryParse(userchoice, out choice)) {
                Console.Write("Please insert a proper number: ");
                userchoice = Console.ReadLine();
            }
            switch(choice) {case 1: star="*"; break; case 2: star="★"; break; case 3: star="✦"; break;
            case 4: star="✹"; break; case 5: star="✪"; break; default: Console.Write("Invalid Input");
            return;}
            Console.Write("Insert number of rows : ");
            string? userrows = Console.ReadLine();
            while(!int.TryParse(userrows, out rows)) {
                Console.Write("Please insert a proper number: ");
                userrows = Console.ReadLine();
            }
            Console.WriteLine($"Number of rows is : {rows}");
            int basestars = rows*2 - 1;
            int totalstars = 0;
            for(int a = 0; a < rows; a++) {
                totalstars += 1 + 2*a; //im so embarassed i didn't realize that totalstars was just the number of rows squared
                                        // i don't wanna remove this loop cuz i spent too much time figuring out how to calculate
                                        //the total number of stars :sob:
            }
            Console.Clear();
            Console.WriteLine("Star model : " + star);
            Console.WriteLine("Number of rows : " + rows);
            Console.WriteLine($"Total number of stars is : {totalstars}");
            if(basestars != 0) {Console.WriteLine($"Number of stars in the base is : {basestars}"); }
                else{Console.WriteLine($"Number of stars in the base is : {basestars}");}
            Console.WriteLine("-");
            List<char> spaces = new List<char>() {};   
            for(int x = 0; x <= rows; x++) {
                spaces.Add(' ');
            }
            for(int i = basestars; i>0; i-=2) {
                if(i <= basestars) {
                    Console.Write($"{string.Join("", spaces)}");
                    spaces.Remove(' ');
                }
                for(int j = basestars; j >= i; j--) {
                    Console.Write(star); 
                    if(j == i) {
                        Console.WriteLine(" ");
                    }
                }
            }  
        }
    }
}

