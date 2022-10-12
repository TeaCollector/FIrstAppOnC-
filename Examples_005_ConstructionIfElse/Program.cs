Console.Write("Введите имя пользователя ");
String username = Console.ReadLine();

if (username.ToLower() == "Маша") {
    Console.WriteLine ("Ура, это же Маша!!!!!");
}
else {
    Console.Write("Привет, " + username);
}