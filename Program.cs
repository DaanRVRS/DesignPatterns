using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            PrintBeverage(espresso);

            Beverage doppio = new Espresso();
            doppio = new EspressoCondiment(doppio);
            PrintBeverage(doppio);

            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage macchiato = new Espresso();
            macchiato = new Milk_Foam(macchiato);
            PrintBeverage(macchiato);

            Beverage corretta = new Espresso();
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            Beverage con_Panna = new Espresso();
            con_Panna.Size = Size.GRANDE;
            con_Panna = new Whip(con_Panna);
            PrintBeverage(con_Panna);

            Beverage cappucino = new Espresso();
            cappucino = new Steamed_Milk(cappucino);
            cappucino = new Milk_Foam(cappucino);
            PrintBeverage(cappucino);

            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            Beverage caffé_Latte = new Espresso();
            caffé_Latte = new Steamed_Milk(caffé_Latte);
            caffé_Latte = new Steamed_Milk(caffé_Latte);
            caffé_Latte = new Milk_Foam(caffé_Latte);
            PrintBeverage(caffé_Latte);

            Beverage flat_white = new Espresso();
            flat_white = new EspressoCondiment(flat_white);
            flat_white = new Steamed_Milk(flat_white);
            flat_white = new Milk_Foam(flat_white);
            PrintBeverage(flat_white);

            Beverage romana = new Espresso();
            romana = new Lemon(romana);
            PrintBeverage(romana);

            Beverage morochino = new Espresso();
            morochino = new ChocolateCondiment(morochino);
            morochino = new Milk_Foam(morochino);
            PrintBeverage(morochino);

            Beverage mocha = new Espresso();
            mocha = new ChocolateCondiment(mocha);
            mocha = new Steamed_Milk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage bicerin = new Espresso();
            bicerin = new ChocolateCondiment(bicerin);
            bicerin = new White_Chocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            Beverage breve = new Espresso();
            breve = new Milk_Foam(breve);
            breve = new Steamed_Milk(breve);
            PrintBeverage(breve);

            Beverage raf_coffee = new Espresso();
            raf_coffee = new Cream(raf_coffee);
            raf_coffee = new Vanilla_Sugar(raf_coffee);
            PrintBeverage(raf_coffee);

            Beverage mead_Raf = new Espresso();
            mead_Raf = new Honey(mead_Raf);
            mead_Raf = new Cream(mead_Raf);
            PrintBeverage(mead_Raf);

            Beverage galao = new Espresso();
            galao = new Milk_Foam(galao);
            galao = new Milk_Foam(galao);
            PrintBeverage(galao);

            Beverage caffé_affogato = new Espresso();
            caffé_affogato = new EspressoCondiment(caffé_affogato);
            caffé_affogato = new Ice_Cream(caffé_affogato);
            PrintBeverage(caffé_affogato);

            Beverage vienna_coffee = new Espresso();
            vienna_coffee = new Whip(vienna_coffee);
            vienna_coffee = new Whip(vienna_coffee);
            vienna_coffee = new EspressoCondiment(vienna_coffee);
            PrintBeverage(vienna_coffee);

            Beverage glace = new Espresso();
            glace = new Ice_Cream(glace);
            PrintBeverage(glace);

            Beverage chocolate_milk = new Chocolate();
            chocolate_milk = new Milk(chocolate_milk);
            chocolate_milk = new Milk(chocolate_milk);
            PrintBeverage(chocolate_milk);

            Beverage demi_Creme = new Espresso();
            demi_Creme = new Cream(demi_Creme);
            demi_Creme = new Cream(demi_Creme);
            demi_Creme = new EspressoCondiment(demi_Creme);
            PrintBeverage(demi_Creme);

            Beverage latte_machiato = new Espresso();
            latte_machiato = new Steamed_Milk(latte_machiato);
            latte_machiato = new Steamed_Milk(latte_machiato);
            latte_machiato = new Milk_Foam(latte_machiato);
            PrintBeverage(latte_machiato);

            Beverage freddo = new Espresso();
            freddo = new Liqour(freddo);
            freddo = new Ice_Cream(freddo);
            PrintBeverage(freddo);

            Beverage frappucino = new Espresso();
            frappucino = new Ice(frappucino); 
            frappucino = new Steamed_Milk(frappucino);
            frappucino = new Whip(frappucino);
            PrintBeverage(frappucino);

            Beverage caramel_frappucino = new Espresso();
            caramel_frappucino = new Ice(caramel_frappucino);
            caramel_frappucino = new Steamed_Milk(caramel_frappucino);
            caramel_frappucino = new Cream(caramel_frappucino);
            caramel_frappucino = new Syrup(caramel_frappucino);
            PrintBeverage(caramel_frappucino);

            Beverage frappe = new Espresso();
            frappe = new Steamed_Milk(frappe);
            frappe = new Steamed_Milk(frappe);
            frappe = new Ice_Cream(frappe);
            PrintBeverage(frappe);

            Beverage irish_Coffee = new Espresso();
            irish_Coffee.Size = Size.TALL;
            irish_Coffee = new Whiskey(irish_Coffee);
            irish_Coffee = new Whip(irish_Coffee);
            irish_Coffee = new EspressoCondiment(irish_Coffee);
            PrintBeverage(irish_Coffee);

        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $ " + beverage.cost().ToString("#.##"));
        }
    }
}